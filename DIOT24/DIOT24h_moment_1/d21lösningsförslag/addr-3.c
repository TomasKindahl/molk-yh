#include <stdlib.h>
#include <stdio.h>
#include <string.h>

void dum(int n) {
    printf("&n = %lX\n", (long)&n);
    if(n > 0) dum(n-1);
}

int main(int argc, char **argv) {
    dum(2);
    return 0;
}