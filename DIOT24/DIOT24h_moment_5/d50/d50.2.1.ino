/****************************************************************
 * Originally from the Arduino example code
 *   File > Examples > MQTT > ArduinoWiFi101
 *   by Gilberto Conti, https://github.com/256dpi/arduino-mqtt
 *   MIT license
 ****************************************************************
 * Modifications:
 *   1. WiFiS3.h (for Uno R4 WiFi) instead of WiFi101.h,
 *   2. added arduino_secrets.h,
 *   3. improved status reporting with code from 
 *      WiFiWebClientRepeating (Public Domain),
 *   4. fixed indent,
 *   5. added serveraddr as a string.
 *
 *   MIT license retained
 ****************************************************************
 */

#include <WiFiS3.h>
#include <MQTT.h>
#include "arduino_secrets.h"

const char ssid[] = SECRET_SSID;
const char pass[] = SECRET_PASS;

const char serveraddr[] = "XX.YY.ZZ.TT"; // MQTT BROKER ADDRESS
WiFiClient net;
MQTTClient client;

unsigned long lastMillis = 4000;

void printWifiStatus();

void connect() {
    Serial.print("---- checking wifi ");
    while (WiFi.status() != WL_CONNECTED) {
        Serial.print(".");
        delay(1000);
    }
    Serial.println(" OK");
    printWifiStatus();

    Serial.print("\n---- connecting to MQTT broker ");
    while (!client.connect("arduino", "public", "public")) {
        Serial.print(".");
        delay(1000);
    }
    Serial.println(" OK");

    Serial.println("\nconnected!");

    client.subscribe("sensor/arduino/setLED");
    // client.unsubscribe("sensor/arduino/setLED");
}

/* "LAMP" status declarations: */
const int lamp_pin = 7;
int lamp_status;
/* "LAMP" status end. */

/* button pin declarations: */
const int button_pin = 8;
const int button_delay = 200; // Button contact bounce
int button_millis = 0;
/* button pin end. */

void messageReceived(String &topic, String &payload) {
    Serial.println("incoming: " + topic + " - " + payload);

    /* "LAMP" on/off messages: */
    if(topic == "sensor/arduino/setLED") {
        if(payload == "on") {
            lamp_status = HIGH;
        }
        else {
            lamp_status = LOW;
        }
        digitalWrite(lamp_pin, lamp_status);
    }
    /* "LAMP" on/off end. */
}

void setup() {
    /* "LAMP" setup calls: */
    pinMode(lamp_pin, OUTPUT);
    lamp_status = LOW;
    digitalWrite(lamp_pin, lamp_status);
    /* "LAMP" setup end. */

    /* button setup calls: */
    pinMode(button_pin, INPUT_PULLUP);
    /* button setup end. */

    Serial.begin(115200);
    WiFi.begin(ssid, pass);

    // Note: Local domain names (e.g. "Computer.local" on OSX) are not supported
    // by Arduino. You need to set the IP address directly.
    client.begin(serveraddr, net);
    client.onMessage(messageReceived);

    connect();
    lastMillis = 0;
}

void loop() {
    client.loop();

    if (!client.connected()) {
        connect();
    }

    if (millis() - button_millis > button_delay) {
        int button = digitalRead(button_pin);
        button_millis = millis();
        if(button == LOW) {
            if(lamp_status == LOW)
                lamp_status = HIGH;
            else
                lamp_status = LOW;
            digitalWrite(lamp_pin, lamp_status);
        }
    }

    // publish a message roughly every 2nd second.
    if (millis() - lastMillis > 1000) {
        lastMillis = millis();
        if(lamp_status == LOW) {
            client.publish("sensor/arduino/LED", "off");
            Serial.println("publishing: sensor/arduino/LED off");
        }
        else {
            client.publish("sensor/arduino/LED", "on");
            Serial.println("publishing: sensor/arduino/LED on");
        }
    }
}

void printWifiStatus() {
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
