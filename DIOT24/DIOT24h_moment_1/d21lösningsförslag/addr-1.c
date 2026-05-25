#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main(int argc, char **argv) {
    int A = 10;
    int *dum = alloca(sizeof(char)*10);
    int *eum = alloca(sizeof(char));
    int B = 12;
    printf("&B = %lX\n", (long)&B);
    printf("&A = %lX\n", (long)&A);
    printf("&dum = %lX\n", (long)dum);
    printf("&eum = %lX\n", (long)eum);
    return 0;
}