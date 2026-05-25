#include <stdio.h>
#include <stdbool.h>

bool isPrime(long N);

int main() {
    for(long i = 2; i < 50; i++)
        if(isPrime(i))
            printf("%ld\n", i);
    printf("Tryck enter för att fortsätta ...");
    char ch = fgetc(stdin);
    return 0;
}
