#include <stdlib.h>
#include <stdio.h>
       
#include "poly2.h"
       
poly2 *new_poly2(double a, double b, double c, double d) {
    poly2 *result = malloc(sizeof(poly2));
    result->a = a;
    result->b = b;
    result->c = c;
    result->d = d;
}
void poly2_print(poly2 *P) {
    printf("%g·x^3 + %g·x^2 + %g·x + %g\n", P->a, P->b, P->c, P->d);
}
double poly2_eval_at(poly2 *P, double X) {
    return P->a*X*X*X + P->b*X*X + P->c*X + P->d;
}
