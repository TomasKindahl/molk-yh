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

void messageReceived(String &topic, String &payload) {
    Serial.println("incoming: " + topic + " - " + payload);

    // Note: Do not use the client in the callback to publish, subscribe or
    // unsubscribe as it may cause deadlocks when other things arrive while
    // sending and receiving acknowledgments. Instead, change a global variable,
    // or push to a queue and handle it in the loop after calling `client.loop()`.

}

void setup() {
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

    // publish a message roughly every 2nd second.
    if (millis() - lastMillis > 1000) {
        lastMillis = millis();
        client.publish("sensor/arduino/LED", "off");
        Serial.println("publishing: sensor/arduino/LED off");
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
