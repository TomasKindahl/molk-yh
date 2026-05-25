/*
 BASED ON: Repeating WiFi Web Client, by Tom Igoe and Federico Vanzati

 This code is STILL in the public domain.

 Find the full UNO R4 WiFi Network documentation here:
 https://docs.arduino.cc/tutorials/uno-r4-wifi/wifi-examples#wi-fi-web-client-repeating

*/

#include "WiFiS3.h"
#include "DHT_Async.h"

/* Uncomment according to your sensortype. */
#define DHT_SENSOR_TYPE DHT_TYPE_11
//#define DHT_SENSOR_TYPE DHT_TYPE_21
//#define DHT_SENSOR_TYPE DHT_TYPE_22
static const int DHT_SENSOR_PIN = 7;   // <--- SIGNAL-pin från DHT11:n till GPIO 7!
DHT_Async dht_sensor(DHT_SENSOR_PIN, DHT_SENSOR_TYPE);  // <---

#include "arduino_secrets.h" 
///////please enter your sensitive data in the Secret tab/arduino_secrets.h
char ssid[] = SECRET_SSID;        // your network SSID (name)
char pass[] = SECRET_PASS;        // your network password (use for WPA, or use as key for WEP)
int keyIndex = 0;                 // your network key index number (needed only for WEP)

int status = WL_IDLE_STATUS;

// Initialize the WiFi client library
WiFiClient client;

// server address:
// char server[] = "example.org";
IPAddress server(192,168,1,54);  // TomKi:s Windows 10 in VirtualBox

unsigned long lastConnectionTime = 0;            // last time you connected to the server, in milliseconds
const unsigned long postingInterval = 10L * 1000L; // delay between updates, in milliseconds

char response[128];
int rix = 0;

/* -------------------------------------------------------------------------- */
void setup() {
/* -------------------------------------------------------------------------- */  
    //Initialize serial and wait for port to open:
    pinMode(DHT_SENSOR_PIN, OUTPUT);
    Serial.begin(9600);
    while (!Serial) {
        ; // wait for serial port to connect. Needed for native USB port only
    }

    // check for the WiFi module:
    if (WiFi.status() == WL_NO_MODULE) {
        Serial.println("Communication with WiFi module failed!");
        // don't continue
        while (true);
    }

    String fv = WiFi.firmwareVersion();
    if (fv < WIFI_FIRMWARE_LATEST_VERSION) {
        Serial.println("Please upgrade the firmware");
    }

    // attempt to connect to WiFi network:
    while (status != WL_CONNECTED) {
        Serial.print("Attempting to connect to SSID: ");
        Serial.println(ssid);
        // Connect to WPA/WPA2 network. Change this line if using open or WEP network:
        status = WiFi.begin(ssid, pass);

        // wait 10 seconds for connection:
        delay(10000);
    }
    // you're connected now, so print out the status:
    printWifiStatus();

    rix = 0;

    digitalWrite(DHT_SENSOR_PIN, LOW);
}

/* just wrap the received data up to 80 columns in the serial print*/
/* -------------------------------------------------------------------------- */
void read_request() {
    /* -------------------------------------------------------------------------- */  
    uint32_t received_data_num = 0;
    int temp, humid;

    while (client.available()) {
        /* actual data reception */
        char c = client.read();
        if(c != 0x0A)
            response[rix++] = c;
        else {
            response[rix] = '\0';
            /*
            Serial.print("\nAgain <");
            Serial.print(response);
            Serial.println(">");
            */
            if(0 == strncmp(response, "Report", 6)) {
                sscanf(response, "Report temp %d humid %d", &temp, &humid);
                Serial.print("\nTEMP ");
                Serial.print(temp);
                Serial.print(" HUMID ");
                Serial.println(humid);
            }
            else if(0 == strncmp(response, "WARN", 4)) {
                digitalWrite(8, HIGH);
            }
            else if(0 == strncmp(response, "NOWARN", 6)) {
                digitalWrite(8, LOW);
            }
            rix = 0;
        }
        /* print data to serial port */
        Serial.print(c);
        /* wrap data to 80 columns*/  // <---
        received_data_num++;
        if (received_data_num % 80 == 0) { 
        
        }
    }
}

/*
 * Poll for a measurement, keeping the state machine alive.  Returns
 * true if a measurement is available.
 */
static bool measure_environment(float *temperature, float *humidity) {   // <--- HELA funktionen
    static unsigned long measurement_timestamp = millis();

    /* Measure once every four seconds. */
    if (millis() - measurement_timestamp > 4000ul) {
        if (dht_sensor.measure(temperature, humidity)) {
            measurement_timestamp = millis();
            return (true);
        }
    }

    return (false);
}

/* -------------------------------------------------------------------------- */
void loop() {
    /* Temp/humid DHT11/DHT22 */
    float temperature; // <---
    float humidity;    // <---
    /* -------------------------------------------------------------------------- */  
    // if there's incoming data from the net connection.
    // send it out the serial port.  This is for debugging
    // purposes only:
    read_request();
  
    /* Measure temperature and humidity.  If the functions returns
       true, then a measurement is available. */

    // if ten seconds have passed since your last connection,
    // then connect again and send data:
    if (millis() - lastConnectionTime > postingInterval) {
        /* Measure temperature and humidity.  If the functions returns
            true, then a measurement is available. */
        if (measure_environment(&temperature, &humidity)) {  // <--- hela if-satsen
            Serial.print("T = ");
            Serial.print(temperature, 1);
            Serial.print(" deg. C, H = ");
            Serial.print(humidity, 1);
            Serial.println("%");
            httpRequest(temperature, humidity);
        }
    }
}

// this method makes a HTTP connection to the server:
/* -------------------------------------------------------------------------- */
void httpRequest(float temperature, float humidity) {
    int temp = (int)(temperature*10), humid = (int)(humidity*10);
    /* -------------------------------------------------------------------------- */  
    // close any connection before send a new request.
    // This will free the socket on the NINA module
    client.stop();

    // if there's a successful connection:
    if (client.connect(server, 5000)) {
        Serial.println("connecting...");
        // send the HTTP GET request:
        // client.println("GET / HTTP/1.1");
        // GET / HTTP/1.1
        Serial.print("GET /climate/temp/");

        Serial.print(temp);
        Serial.print("/humid/");
        Serial.print(humid);
        Serial.println(" HTTP/1.1");

        client.print("GET /climate/temp/");
        client.print(temp);
        client.print("/humid/");
        client.print(humid);
        client.println(" HTTP/1.1");

        client.println("Host: 192.168.1.54"); // TomKi:s Windows Server in VirtualBox
        client.println("User-Agent: ArduinoWiFi/1.1");
        client.println("Connection: close");
        client.println();
        // note the time that the connection was made:
        lastConnectionTime = millis();
    } else {
        // if you couldn't make a connection:
        Serial.println("connection failed");
        delay(5000);
    }
}

/* -------------------------------------------------------------------------- */
void printWifiStatus() {
    /* -------------------------------------------------------------------------- */  
    // print the SSID of the network you're attached to:
    Serial.print("SSID: ");
    Serial.println(WiFi.SSID());

    // print your board's IP address:
    IPAddress ip = WiFi.localIP();
    Serial.print("IP Address: ");
    Serial.println(ip);

    // print the received signal strength:
    long rssi = WiFi.RSSI();
    Serial.print("signal strength (RSSI):");
    Serial.print(rssi);
    Serial.println(" dBm");
}
