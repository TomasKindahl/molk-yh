#include <EEPROM.h>

unsigned int last;
unsigned char LB, UB;

void setup() {
    // put your setup code here, to run once:
    pinMode(4, INPUT_PULLUP);
    Serial.begin(9600);
    LB = EEPROM.read(0);
    UB = EEPROM.read(1);
    last = (int)(UB)<<8 | LB;
}

void loop() {
    // put your main code here, to run repeatedly:
    Serial.println((int)last);
    if(digitalRead(4) == LOW) {
        Serial.println("halting the system");
        unsigned char UB = last >> 8, LB = last;
        EEPROM.write(0, LB);
        EEPROM.write(1, UB);
        delay(3600000L);
    }
    last++;
    delay(1000);
}
