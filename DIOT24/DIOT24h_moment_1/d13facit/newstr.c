#include <stdlib.h>
#include <stdio.h>
#include <string.h>

char *newstr(int size) {
    char *newvalue = malloc(sizeof(char)*size);
    newvalue[0] = '\0';
    return newvalue;
}

int main(int argc, char **argv) {
    char *str = newstr(10);
    strcpy(str, "test");
    printf("%s\n", str);
    return 0;
}