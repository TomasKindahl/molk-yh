#include <mosquitto.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>

int main(int argc, char *argv[]) {
    struct mosquitto *mosq;
    const char *broker = "192.168.1.87"; // Change to your broker's address
    int port = 1883;                     // Change to your broker's port
    const char *topic = "sensor/arduino/setLED"; // Topic to publish to
    const char *message = "on";          // Message to publish
    int qos = 0;                         // Quality of Service
    int retain = 0;                      // Retain flag

    // Initialize the Mosquitto library
    mosquitto_lib_init();

    // Create a new Mosquitto client instance
    mosq = mosquitto_new(NULL, true, NULL);
    if (!mosq) {
        fprintf(stderr, "Failed to create Mosquitto instance.\n");
        mosquitto_lib_cleanup();
        return EXIT_FAILURE;
    }

    // Connect to the broker
    if (mosquitto_connect(mosq, broker, port, 60) != MOSQ_ERR_SUCCESS) {
        fprintf(stderr, "Failed to connect to broker.\n");
        mosquitto_destroy(mosq);
        mosquitto_lib_cleanup();
        return EXIT_FAILURE;
    }

    // Publish a message
    int publish_result = mosquitto_publish(mosq, NULL, topic, strlen(message), message, qos, retain);
    if (publish_result != MOSQ_ERR_SUCCESS) {
        fprintf(stderr, "Failed to publish message: %s\n", mosquitto_strerror(publish_result));
    } else {
        printf("Message '%s' published to topic '%s'.\n", message, topic);
    }

    // Disconnect and clean up
    mosquitto_disconnect(mosq);
    mosquitto_destroy(mosq);
    mosquitto_lib_cleanup();

    return EXIT_SUCCESS;
}
