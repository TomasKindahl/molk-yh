#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int fact(int n) {
    printf("&n = %lX\n", (long)&n);
    if(n == 0) return 1;
    int factnext = fact(n-1);
    printf("&factnext = %lX\n", (long)&factnext);
    int result = n*factnext;
    printf("&result = %lX\n", (long)&result);
    return result;
}

int main(int argc, char **argv) {
    printf("fact(3) = %d\n", fact(3));
    return 0;
}