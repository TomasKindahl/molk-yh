void setup() {
    pinMode(6, OUTPUT);
}
       
int ix = 0;
int pwm_out[] = {
    0, 1, 2, 4, 8, 16, 32, 64, 128, 255, -1
};
       
void loop() {
    analogWrite(6, pwm_out[ix]);
    delay(1000);
    ix++;
    if(pwm_out[ix] == -1) ix = 0;
}