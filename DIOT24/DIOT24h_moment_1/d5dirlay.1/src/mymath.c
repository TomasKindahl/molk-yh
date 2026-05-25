#include <stdio.h>

double sqr(double base) {
	return base*base;
}
double npow(double base, int n) {
	if (n == 0)
		return 1;
	if (n % 2 == 0)
		return npow(sqr(base), n/2);
	return base*npow(base, n-1);
}
double sqroot(double x) {
	double rt = 1, ort = 0;
	while(ort!=rt)
	{
		ort = rt;
		rt = ((x/rt) + rt) / 2;
	}
	return rt;
}