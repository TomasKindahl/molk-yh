void setup() {
    pinMode(6, OUTPUT);
}
       
int currentvalue = 4;
       
void loop() {
    if(currentvalue == 4)
        currentvalue = 0;
    else
        currentvalue = 4;
    analogWrite(6, currentvalue);
    delay(1000);
}