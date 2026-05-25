// This example uses an Arduino/Genuino Zero together with
// a WiFi101 Shield or a MKR1000 to connect to shiftr.io.
//
// IMPORTANT: This example uses the new WiFi101 library.
//
// You can check on your device after a successful
// connection here: https://www.shiftr.io/try.
//
// by Gilberto Conti
// https://github.com/256dpi/arduino-mqtt

#include <WiFiS3.h>                // ÄNDRA!!
#include <MQTT.h>
#include "arduino_secrets.h"       // ÄNDRA!!

const char ssid[] = SECRET_SSID;   // ändrat
const char pass[] = SECRET_PASS;   // ändrat

WiFiClient net;
MQTTClient client;

unsigned long lastMillis = 0;

void connect() {
  Serial.print("checking wifi...");
  while (WiFi.status() != WL_CONNECTED) {
    Serial.print(".");
    delay(1000);
  }

  Serial.print("\nconnecting...");
  while (!client.connect("arduino", "public", "public")) {
    Serial.print(".");
    delay(1000);
  }

  Serial.println("\nconnected!");

  client.subscribe("sensor/arduino/setLED");  // ändrat
  // client.unsubscribe("/hello");
}

void messageReceived(String &topic, String &payload) {
  Serial.println("incoming: " + topic + " - " + payload);

  // Sätt på eller stäng av LED här:
}

int lamp_mode = LOW;
const int lamp_pin = LED_BUILTIN;
const int button_pin = 7;

void setup() {
  pinMode(button_pin, INPUT_PULLUP);
  pinMode(lamp_pin, OUTPUT);

  Serial.begin(115200);
  WiFi.begin(ssid, pass);

  // Note: Local domain names (e.g. "Computer.local" on OSX) are not supported
  // by Arduino. You need to set the IP address directly.
  client.begin("192.168.1.54", net);   // ÄNDRA!!
  client.onMessage(messageReceived);

  connect();
}

void loop() {
  client.loop();

  if (!client.connected()) {
    connect();
  }

  // publish a message roughly every second.
  if (millis() - lastMillis > 1000) {
    lastMillis = millis();
    // Kanske en if-sats här beroende på om LED:en är på eller av.
    client.publish("sensor/arduino/LED", "off");  // ändrat
  }
}
