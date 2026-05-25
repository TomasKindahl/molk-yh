#include <stdlib.h>
#include <stdio.h>
#include <string.h>
#include <stdbool.h>

char *bin_to_str8(char* buf, char B);

bool is_bit_3_set(char val);

int main() {
    char word[100];
    char buf[10];
    char val;
    do {
        printf("write a number: ");
        fgets(word, 100, stdin);
        if(0 == strcmp(word, "quit\n"))
            break;
        val = atoi(word);
        if(is_bit_3_set(val))
            printf("bit 3 is set on %d (%s)\n", val, bin_to_str8(buf, val));
        else
            printf("bit 3 is NOT set on %d (%s)\n", val, bin_to_str8(buf, val));
    }
    while(true);
}

/* TITTA UPP, INTE NER! */

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
