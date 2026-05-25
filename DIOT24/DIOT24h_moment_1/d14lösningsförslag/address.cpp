#include <stdlib.h>

#include <string>
#include <iostream>

using namespace std;

class address {
   public:
     string name;
     string phone;
     address() { }
     address(string Name, string Phone) {
         name = Name;
         phone = Phone;
     }
     void print() {
         cout << name << endl;
         cout << phone << endl;
     }
};

int main(int argc, char **argv) {
    address Arne("Arne Svensson", "013-131313");
    address Berith("Berith Qvist", "0616-616 616");
    Arne.print();
    Berith.print();
    return 0;
}