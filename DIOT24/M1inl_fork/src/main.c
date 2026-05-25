#include <stdio.h>
#include <string.h>
#include <stdbool.h>

char *iarr_to_str(char *buf, int *iarr, int ialen) {
    bool first = true;
    char ibuf[16];
    strcpy(buf, "[");
    for(int i = 0; i < ialen; i++) {
        if(first)
            first = false;
        else
            strcat(buf, ", ");
        sprintf(ibuf, "%d", iarr[i]);
        strcat(buf, ibuf);
    }
    strcat(buf, "]");
    return buf;
}
bool is_prime(int num) {
    if(num < 2) return false;
    if(num == 2) return true;
    if(num % 2 == 0) return false;
    for(int i = 3; i < num; i++) {
        if(num % i == 0) return false;
    }
    return true;
}
int get_next_prime(int prime) {
    if(prime == 2) return 3;
    prime += 2;
    while(!is_prime(prime)) prime += 2;
    return prime;
}
int *prime_factors(int *buffer, int *factors, int num) {
    *factors = 0;
    int prime = 2;
    while(prime < num) {
        while(num % prime == 0) {
            buffer[*factors] = prime;
            *factors += 1;
            num /= prime;
        }
        prime = get_next_prime(prime);
    }
    if(num == 1) return buffer;
    buffer[*factors] = num;
    *factors += 1;
    return buffer;
}

int main() {
    char printbuf[128];
    int factors[20];
    int num;
    for(int i = 1, p = 2; i < 41; i++) {
        printf("%3d ", p);
        if(i % 10 == 0) printf("\n");
        p = get_next_prime(p);
    }
    printf("\n");
    for(int i = 30; i < 50; i++) {
        prime_factors(factors, &num, i);
        printf("prime factors of %d: %s\n",
               i, iarr_to_str(printbuf, factors, num)
              );
    }
    return 0;
}
