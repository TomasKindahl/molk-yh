void setup() {
    pinMode(6, OUTPUT);
}
       
int currentvalue = 128;
       
void loop() {
    if(currentvalue == 128)
        currentvalue = 0;
    else
        currentvalue = 128;
    analogWrite(6, currentvalue);
    delay(1000);
}