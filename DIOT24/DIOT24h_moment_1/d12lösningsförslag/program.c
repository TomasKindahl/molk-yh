#include <stdio.h>

int main(int argc, char **argv) {
    char name[200]; /* 200 element stor array */
    printf("Hello, World!\n");
    printf("What is your name? ");
    fgets(name, 200, stdin);
    printf("Hello, %s!", name);
    return 0;
}