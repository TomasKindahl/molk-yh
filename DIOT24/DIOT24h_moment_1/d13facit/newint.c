#include <stdlib.h>
#include <stdio.h>

int *newint(int value) {
    int *newvalue = malloc(sizeof(int));
    *newvalue = value;
    return newvalue;
}

int main(int argc, char **argv) {
    int *intp = newint(42);
    printf("%d\n", *intp);
    return 0;
}