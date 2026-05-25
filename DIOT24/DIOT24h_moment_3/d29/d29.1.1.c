#define AOUT 6
#define AIN A5

void setup() {
    // put your setup code here, to run once:
    pinMode(AOUT, OUTPUT);
    pinMode(AIN, INPUT);
    Serial.begin(9600);
}

void serialprint3(int lb, int val, int ub);

void loop() {
    // put your main code here, to run repeatedly:
    int in = analogRead(AIN);
    serialprint3(0, in, 1023);
}

void serialprint3(int lb, int val, int ub) {
    Serial.print(lb);
    Serial.print(" ");
    Serial.print(val);
    Serial.print(" ");
    Serial.println(ub);
}