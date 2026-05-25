#include <iostream>
#include <cmath>

using namespace std;

class cartesian {
   private:
     double x, y, z;
   public:
     cartesian(double X, double Y, double Z) {
        x = X; y = Y; z = Z;
     }
     double distance(cartesian other) {
        double dx = x - other.x; 
        double dy = y - other.y; 
        double dz = z - other.z; 
        return sqrt(dx*dx + dy*dy + dz*dz);
     }
};

int main(int argc, char **argv) {
    cartesian c1(12.33, 14.2, -3.4);
    cartesian c2(-2, 16.4, 6.5);
    cout << c1.distance(c2) << endl;
    return 0;
}