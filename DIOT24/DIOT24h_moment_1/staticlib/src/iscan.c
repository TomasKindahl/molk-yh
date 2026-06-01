#include <stdio.h>
#include <string.h>
#include <stdbool.h>

#include "iarrop.h"

int isum(int *iarr, int ialen) {
    int sum = 0;
    for(int i = 0; i < ialen; i++) 
        sum += iarr[i];
    return sum;
}
int ialtdiff(int *iarr, int ialen) {
    int diff = 0;
    int sign = 1;
    for(int i = 0; i < ialen; i++) {
        diff +=  sign*iarr[i];
        sign = - sign;
    }
    return diff;
}
int iprod(int *iarr, int ialen) {
    int prod = 1;
    for(int i = 0; i < ialen; i++) 
        prod *= iarr[i];
    return prod;
}
