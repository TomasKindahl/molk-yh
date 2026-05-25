#include <stdio.h>
#include <string.h>
#include <stdbool.h>

#include "iarrop.h"

int *iaccumsum(int *idest, int *iarr, int ialen) {
    int sum = 0;
    for(int i = 0; i < ialen; i++) {
        sum += iarr[i];
        idest[i] = sum;
    }
    return idest;
}
int *iaccumprod(int *idest, int *iarr, int ialen) {
    int prod = 1;
    for(int i = 0; i < ialen; i++) {
        prod *= iarr[i];
        idest[i] = prod;
    }
    return idest;
}
