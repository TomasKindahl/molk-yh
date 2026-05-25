#include <stdio.h>

void iswap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}

int main(int argc, char **argv) {
    int m = 1, n = 2;
    printf("%d - %d\n", m, n);    /* ska ge "1 - 2" */
    iswap(&m, &n);
    printf("%d - %d\n", m, n);    /* ska ge "2 - 1" */
    return 0;
}