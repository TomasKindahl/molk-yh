#include <iostream>

using namespace std;

template <class T> void myswap(T &v1, T &v2) {
    T temp = v1; v1 = v2; v2 = temp;
}

int main(int argc, char **argv) {
    double x = 12.3, y = 3.12;
    cout << x << "/" << y << endl;
    myswap(x, y);
    cout << x << "/" << y << endl;
    string a = "abra"s, b = "kadabra"s;
    cout << a << "/" << b << endl;
    myswap(a, b);
    cout << a << "/" << b << endl;
   
    return 0;
}