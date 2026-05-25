#include <iostream>

using namespace std;

template <class T> class SLL {
   private:
     T value; SLL *next;
   public:
     SLL(T Value, SLL *Next = NULL) { value = Value; next = Next; }
     void print() {
         cout << value << " ";
         if(next == NULL) cout << endl;
         else next->print();
     }
};

int main(int argc, char **argv) {
    SLL<int> *primes = new SLL(2, new SLL(3, new SLL(5)));
    primes->print();
    return 0;
}