#include <mosquitto.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void on_connect(struct mosquitto *mosq, void *obj, int rc) {
    if (rc == 0) {
        printf("Connected to broker successfully.\n");
        // Subscribe to sensor/arduino/LED:
        int subscribe_LED = mosquitto_subscribe(mosq, NULL, "sensor/arduino/LED", 0);
        if (subscribe_LED != MOSQ_ERR_SUCCESS) {
            fprintf(stderr, "Failed to subscribe: %s\n", mosquitto_strerror(subscribe_LED));
        } else {
            printf("Subscribed to topic: sensor/arduino/LED\n");
        }
        // Subscribe to sensor/arduino/LED:
        int subscribe_setLED = mosquitto_subscribe(mosq, NULL, "sensor/arduino/setLED", 0);
        if (subscribe_setLED != MOSQ_ERR_SUCCESS) {
            fprintf(stderr, "Failed to subscribe: %s\n", mosquitto_strerror(subscribe_setLED));
        } else {
            printf("Subscribed to topic: sensor/arduino/setLED\n");
        }
    } else {
        fprintf(stderr, "Connection failed with code %d\n", rc);
    }
}

void on_message(struct mosquitto *mosq, void *obj, const struct mosquitto_message *msg) {
    printf("Received message: %s on topic %s\n", (char *)msg->payload, msg->topic);
}

int main(int argc, char *argv[]) {
    struct mosquitto *mosq;
    const char *broker = "192.168.1.87"; // Change to your broker's address
    int port = 1883; // Usually keep!

    // Initialize the Mosquitto library
    mosquitto_lib_init();

    // Create a new Mosquitto client instance
    mosq = mosquitto_new(NULL, true, NULL);
    if (!mosq) {
        fprintf(stderr, "Failed to create Mosquitto instance.\n");
        mosquitto_lib_cleanup();
        return EXIT_FAILURE;
    }

    // Set callbacks
    mosquitto_connect_callback_set(mosq, on_connect);
    mosquitto_message_callback_set(mosq, on_message);

    // Connect to the broker
    if (mosquitto_connect(mosq, broker, port, 60) != MOSQ_ERR_SUCCESS) {
        fprintf(stderr, "Failed to connect to broker.\n");
        mosquitto_destroy(mosq);
        mosquitto_lib_cleanup();
        return EXIT_FAILURE;
    }

    // Start the loop in a background thread
    if (mosquitto_loop_start(mosq) != MOSQ_ERR_SUCCESS) {
        fprintf(stderr, "Failed to start Mosquitto loop.\n");
        mosquitto_destroy(mosq);
        mosquitto_lib_cleanup();
        return EXIT_FAILURE;
    }

    // Wait for user input to exit
    printf("Press Enter to exit...\n");
    getchar();

    // Clean up
    mosquitto_disconnect(mosq);
    mosquitto_destroy(mosq);
    mosquitto_lib_cleanup();

    return EXIT_SUCCESS;
}
