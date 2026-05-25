#define AOUT A0
#define AIN A5

int ts;
bool isOn = true;

void setup() {
    // put your setup code here, to run once:
    pinMode(AOUT, OUTPUT);
    pinMode(AIN, INPUT);
    ts = micros();
}

void loop() {
    int in = analogRead(AIN);
    int wait = 20*in;
    int t = micros();
    if(t - ts >= wait) {
        ts = t;
        if(isOn) {
            digitalWrite(AOUT, HIGH);
            isOn = false;
        }
        else {
            digitalWrite(AOUT, LOW);
            isOn = true;
        }
    }
}

