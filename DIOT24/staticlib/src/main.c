#include <stdio.h>
#include <string.h>
#include <stdbool.h>

#include "iarrop.h"

int main() {
    char buf[128];
    int primes[] = {2, 3, 5, 7, 11, 13, 15};
    int odd[] = {1, 3, 5, 7, 9, 11, 13};
    int accum[7];
    printf("array: %s\n", iarr_to_str(buf, primes, 7));
    printf("  sum: %d\n", isum(primes, 7));
    printf("  accum sum: %s\n", iarr_to_str(buf, iaccumsum(accum, primes, 7), 7));
    printf("  prod: %d\n", iprod(primes, 7));
    printf("  accum prod: %s\n", iarr_to_str(buf, iaccumprod(accum, primes, 7), 7));
    printf("array: %s\n", iarr_to_str(buf, odd, 7));
    printf("  sum: %d\n", isum(odd, 7));
    printf("  accum sum: %s\n", iarr_to_str(buf, iaccumsum(accum, odd, 7), 7));
    printf("  prod: %d\n", iprod(odd, 7));
    printf("  accum prod: %s\n", iarr_to_str(buf, iaccumprod(accum, odd, 7), 7));
    return 0;
}