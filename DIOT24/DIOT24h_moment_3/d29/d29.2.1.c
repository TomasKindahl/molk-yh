#define AOUT A0

void setup() {
    // put your setup code here, to run once:
    pinMode(AOUT, OUTPUT);
}

void loop() {
    // put your main code here, to run repeatedly:
    digitalWrite(AOUT, HIGH);
    delay(100);
    digitalWrite(AOUT, LOW);
    delay(100);
}
