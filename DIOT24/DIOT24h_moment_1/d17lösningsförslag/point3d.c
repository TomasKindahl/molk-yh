#include <stdlib.h>
#include <stdio.h>

#include "point3d.h"

point3D *new_point3D(double x, double y, double z) {
    point3D *res = malloc(sizeof(point3D));
    res->x = x;
    res->y = y;
    res->z = z;
    return res;
}

void point3D_print(point3D *P) {
    printf("<%g,%g,%g>\n", P->x, P->y, P->z);
}