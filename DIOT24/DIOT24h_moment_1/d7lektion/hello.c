#include <stdio.h>

int main() {
    char name[128];
    printf("Hello, what is your name? ");
    fgets(name, 128, stdin);
    printf("Hello, %s\n", name);
    for(int i = 0; i < 10; i++) {
        printf("%d ^ 2 = %d\n", i, i*i);
    }
    return 0;
}