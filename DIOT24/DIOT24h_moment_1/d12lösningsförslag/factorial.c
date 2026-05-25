#include <stdio.h>

int factorial(int n) {
    int prod = 1;
    for(int i = 1; i <= n; i++)
        prod *= i;
    return prod;
}

int main(int argc, char **argv) {
    for(int i = 1; i <= 6; i++)
        printf("%d  %d\n", i, factorial(i));
    return 0;
}