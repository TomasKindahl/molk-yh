void setup() {
    // put your setup code here, to run once:
    Serial.begin(9600);
    pinMode(A5, INPUT);
}

void loop() {
    // put your main code here, to run repeatedly:
    int mic = analogRead(A5);
    Serial.print(0); Serial.print(" ");
    Serial.print(mic); Serial.print(" ");
    Serial.println(1023);
    delay(20);
}
