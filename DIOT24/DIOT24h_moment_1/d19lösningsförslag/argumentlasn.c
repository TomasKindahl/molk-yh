#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main(int argc, char **argv) {
    printf("argumentlasn:\n");
    for(int i = 1; i < argc; i++)
        printf("  argument %d = %s\n", i, argv[i]);
    return 0;
}