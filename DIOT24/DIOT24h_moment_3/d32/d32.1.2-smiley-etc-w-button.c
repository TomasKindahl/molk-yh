#include "Arduino_LED_Matrix.h"

ArduinoLEDMatrix matrix;

void setup() {
    Serial.begin(115200);
    pinMode(4, INPUT_PULLUP);
    matrix.begin();
}

const uint32_t happy[] = {
    0x19819,
    0x80000001,
    0x81f8000
};
const uint32_t heart[] = {
    0x3184a444,
    0x44042081,
    0x100a0040
};

int happyOn = 1;

void loop(){
    if(digitalRead(4) == LOW) {
        happyOn = 1 - happyOn; 
    }
    if(happyOn == 1) {
        matrix.loadFrame(happy);
    }
    else {
        matrix.loadFrame(heart);
    }
    delay(200);
}