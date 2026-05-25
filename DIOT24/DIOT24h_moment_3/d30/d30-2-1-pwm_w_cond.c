#define PWMOUT 6

void setup() {
    // put your setup code here, to run once:
    pinMode(PWMOUT, OUTPUT);
}

void loop() {
    // put your main code here, to run repeatedly:
    analogWrite(PWMOUT, 64);
    delay(500);
    analogWrite(PWMOUT, 255);
    delay(100);
}
