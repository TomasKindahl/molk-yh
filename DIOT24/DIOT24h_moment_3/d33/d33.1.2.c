void setup() {
    // put your setup code here, to run once:
    pinMode(7, INPUT);
    pinMode(LED_BUILTIN, OUTPUT);
}

void loop() {
    // put your main code here, to run repeatedly:
    int val = digitalRead(7);
    if(val == HIGH)
        digitalWrite(LED_BUILTIN, LOW);
    else
        digitalWrite(LED_BUILTIN, HIGH);
}
