#define AOUT 6
#define AIN A5

int ts, ts2;
bool isOn = true;

void serialprint3(int lb, int val, int ub);

void setup() {
    // Initieringskod:
    pinMode(AOUT, OUTPUT);
    pinMode(AIN, INPUT);
    Serial.begin(9600);

    ts = ts2 = millis();
}

void loop() {
    int in = analogRead(AIN);
    int wait = 1000, wait2 = 50;
    int t = millis();
    if(t - ts < wait*0.12) {
        // 12% av tiden hög
        analogWrite(AOUT, 255);
    }
    else {
        // resten låg:
        analogWrite(AOUT, 0);
    }
    if(t - ts >= wait) {
        ts = t;
    }
    if(t - ts2 >= wait2) {
        ts2 = t;
        serialprint3(0, in, 1023);
    }
}

void serialprint3(int lb, int val, int ub) {
    Serial.print(lb);
    Serial.print(" ");
    Serial.print(val);
    Serial.print(" ");
    Serial.println(ub);
}