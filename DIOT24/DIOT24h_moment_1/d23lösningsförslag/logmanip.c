#include <stdlib.h>
#include <stdio.h>
#include <string.h>

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

unsigned char bit(unsigned char B, int n) {
    return 0; /* FIXME!! */
}

unsigned char set_bit(unsigned char B, int n) {
    return 0; /* FIXME!! */
}

unsigned char inv(unsigned char B) {
    return 0; /* FIXME!! */
}

unsigned char clear_bit(unsigned char B, int n) {
    return 0; /* FIXME!! */
}

unsigned char flip_bit(unsigned char B, int n) {
    return 0; /* FIXME!! */
}

int main(int argc, char **argv) {
    char buf[9];
    unsigned char A = 0b10110100;
    printf("A = %s\n", bin_to_str8(buf, A));
    printf("---- bit ----\n");
    for(int i = 7; i >= 0; i--)
        printf("%d: %d\n", i, bit(A, i));
    printf("---- set ----\n");
    for(int i = 0; i < 8; i++)
        printf("set %d: %s\n", i, bin_to_str8(buf, set(A, i)));
    printf("---- inv ----\n");
    printf("inv(A) = %s\n", bin_to_str8(buf, inv(A)));
    printf("---- clear ----\n");
    for(int i = 0; i < 8; i++)
        printf("clear %d: %s\n", i, bin_to_str8(buf, clear(A, i)));
    printf("---- flip ----\n");
    for(int i = 0; i < 8; i++)
        printf("flip %d: %s\n", i, bin_to_str8(buf, flip(A, i)));
    return 0;
}