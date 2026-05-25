#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main(int argc, char **argv) {
    int a = 12;
    char b = 7;
    char *sarr = alloca(8);
    char *harr = malloc(8);
    printf("&a = %lX\n", (long)&a);
    printf("&b = %lX\n", (long)&a);
    printf("sarr = %lX\n", (long)sarr);
    printf("harr = %lX\n", (long)harr);
    free(harr);
    harr = malloc(8);
    printf("harr = %lX\n", (long)harr);
    return 0;
}
