#include <stdio.h>

int tria(int n) {
    int sum = 0;
    for(int i = 1; i <= n; i++)
        sum += i;
    return sum;
}

/* ALTERNATIV:
int tria(int n) {
    return (n+1)*n/2;
}
*/

int main(int argc, char **argv) {
    for(int i = 1; i <= 6; i++)
        printf("%d  %d\n", i, tria(i));
    return 0;
}