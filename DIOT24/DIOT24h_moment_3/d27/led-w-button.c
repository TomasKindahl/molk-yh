void setup() {
    // initialize digital pin LED_BUILTIN as an output.
    pinMode(7, OUTPUT);
    pinMode(4, INPUT_PULLUP);
    Serial.begin(9600);
}

int currentvalue = HIGH;

// the loop function runs over and over again forever
void loop() {
    if(digitalRead(4) == LOW) {
        Serial.println("switch");
        if(currentvalue == HIGH) {
            Serial.println("to low");
            currentvalue = LOW;
        }
        else {
            Serial.println("to high");
            currentvalue = HIGH;
        }
    }
    digitalWrite(7, currentvalue);
    delay(200);
}