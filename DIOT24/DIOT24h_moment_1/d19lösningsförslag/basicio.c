#include <stdio.h>
#include <string.h>

int main(int argc, char **argv) {
    char line[100];
    printf("Mata in ditt namn: ");
    fgets(line, 100, stdin);
    if(0 == strcmp(line, "\n")) {
        printf("Hej, Världen!\n");
    }
    else {
        int len = strlen(line);
        line[len-1] = 0; /* ta bort nyradstecknet på slutet! */
        printf("Hej, %s!\n", line);
    }
    return 0;
}