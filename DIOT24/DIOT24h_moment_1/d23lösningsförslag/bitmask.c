#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#define GPIO_1         1
#define GPIO_1_PULLUP  2
#define GPIO_2         4
#define GPIO_2_PULLUP  8
#define GPIO_3         16
#define GPIO_3_PULLUP  32
#define GPIO_3_PWM_HI  64

char *bin_to_str8(char* buf, char B) {
    buf[8] = '\0';
    for(int i = 7; i >= 0; i--) {
        if(B & 1 != 0) 
            buf[i] = '1';
        else
            buf[i] = '0';
        B = B >> 1;
    }
    return buf;
}

int main(int argc, char **argv) {
    char buf[9];
    unsigned char GPIO_REG = 0b00000000;
    printf("GPIO_REG = %s\n", bin_to_str8(buf, GPIO_REG));
    /* Uppgift 23.2.1:
     *    sätt GPIO_1 PÅ med PULLUP-register AV */

    /* Utskrift ska bli 00000001 */
    printf("GPIO_REG = %s\n", bin_to_str8(buf, GPIO_REG));
    /* Uppgift 23.2.2:
     *    sätt GPIO_2 PÅ med PULLUP-register PÅ */

    /* Utskrift ska bli 00001101 */
    printf("GPIO_REG = %s\n", bin_to_str8(buf, GPIO_REG));
    /* Uppgift 23.2.3:
     *    sätt GPIO_3 PÅ med PULLUP-register AV och PWM_HI resolution PÅ */

    /* Utskrift ska bli 01011101 */
    printf("GPIO_REG = %s\n", bin_to_str8(buf, GPIO_REG));

    GPIO_REG = 0b00000000; /* NOLLSTÄLLER */ 
    /* Uppgift 23.2.4:
     *    sätt GPIO_3 exakt som ovan, men med endast TVÅ programrader */

    /* Utskrift ska bli 01011101 */
    printf("GPIO_REG = %s\n", bin_to_str8(buf, GPIO_REG));
    return 0;
}
