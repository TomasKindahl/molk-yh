#include <stdio.h>

void reverse(double darr[], int len) {
    int half = len / 2;
    for(int i = 0; i <= half; i++) {
        double temp = darr[i];
        darr[i] = darr[len - 1 - i];
        darr[len - 1 - i] = temp;
    }
}

int main() {
    double darr[5] = {1.2, -12.5, 6, 2.15, 77.3};
    for(int i = 0; i < 5; i++)
        printf("%g ", darr[i]);
    printf("\n");
    reverse(darr, 5);
    for(int i = 0; i < 5; i++)
        printf("%g ", darr[i]);
    printf("\n");
    return 0;
}