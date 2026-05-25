#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main(int argc, char **argv) {
    printf("Number of arguments = %d\n", argc);
    for(int i = 0; i < argc; i++)
        printf("  %d: %s\n", i, argv[i]);
    return 0;
}