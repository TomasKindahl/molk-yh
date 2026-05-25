unsigned char last;

void setup() {
    // put your setup code here, to run once:
    pinMode(4, INPUT_PULLUP);
    Serial.begin(9600);
    last = 0;
}

void loop() {
    // put your main code here, to run repeatedly:
    Serial.println((int)last);
    if(digitalRead(4) == LOW) {
        Serial.println("halting the system");
        delay(3600000L);
    }
    last++;
    delay(1000);
}
