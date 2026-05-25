#include <stdlib.h>
#include <stdio.h>
#include <string.h>

#include "point3d.h"

int main() {
    point3D *P1 = new_point3D(2, 3.2, 5);
    point3D_print(P1);
    point3D *P2 = new_point3D(-7, 4.4, 1.25);
    point3D_print(P2);
    return 0;
}