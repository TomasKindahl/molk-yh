void setup() {
    pinMode(6, OUTPUT);
}
       
int currentvalue = 0;
       
void loop() {
    if(currentvalue == 0)
        currentvalue = 1;
    else if(currentvalue == 1)
        currentvalue = 2;
    else if(currentvalue == 2)
        currentvalue = 4;
    else if(currentvalue == 4)
        currentvalue = 8;
    else if(currentvalue == 8)
        currentvalue = 16;
    else if(currentvalue == 16)
        currentvalue = 32;
    else if(currentvalue == 32)
        currentvalue = 64;
    else if(currentvalue == 64)
        currentvalue = 128;
    else if(currentvalue == 128)
        currentvalue = 255;
    else if(currentvalue == 255)
        currentvalue = 0;
    else
        currentvalue = 0;
    analogWrite(6, currentvalue);
    delay(1000);
}