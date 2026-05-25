#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#include "library.h"
#include "definitions.h"

int main(int argc, char **argv) {
    for(double x = 0; x < 1.0; x+=0.1)
        printf("invsqr(%g) = %g\n", x, invsqr(x));
    return 0;
}