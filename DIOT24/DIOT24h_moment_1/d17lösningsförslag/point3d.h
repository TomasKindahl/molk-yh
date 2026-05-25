#ifndef _POINT3D_H
#define _POINT3D_H

typedef struct _point3D_S {
   double x, y, z;
} point3D;

point3D *new_point3D(double x, double y, double z);
void point3D_print(point3D *point);

#endif 