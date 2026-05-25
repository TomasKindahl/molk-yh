#include <stdio.h>

#include "mymath.h"

int main(int argc, char **argv) {
	printf("   x    x^2       √x      x^5\n");
	printf("-----------------------------\n");
	for(double x = 1; x < 5; x += 0.25)
		printf("%4.2f  %5.2f  %5.5f  %7.2f\n",
			   x, sqr(x), sqroot(x), npow(x, 5));
	printf("-----------------------------\n\n");
	printf("n    0.5^n\n");
	printf("-----------\n");
	for(int x = 0; x < 7; x++)
		printf("%d %4.6f\n",
			   x, npow(0.5, x));
		printf("-----------\n");
	return 0;
}
