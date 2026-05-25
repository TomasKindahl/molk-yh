#include <iostream>

using namespace std;

template <class T> class nValue {
   private:
     string name; T value;
   public:
     nValue(string Name, T Value) {
         name = Name; value = Value;
     }
     void print() {
         cout << name << ": " << value << endl;
     }
};

int main(int argc, char **argv) {
    nValue<int> x("tre", 3);
    x.print();
    nValue<double> pi("pi", 3.141592654);
    pi.print();
    nValue<string> NH("nisse", "hult");
    NH.print();
    return 0;
}