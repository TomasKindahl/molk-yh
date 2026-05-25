#ifndef _LIBRARY_H
#define _LIBRARY_H

double pi = 3.141592653589793;
int fact(int n) {
    if(n < 0) return -1;
    if(n == 0) return 1;
    return n*fact(n-1);
}
double sqr(double x) {
    return x*x;
}

#endif