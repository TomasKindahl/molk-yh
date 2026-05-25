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
     void append(T newVal) {
         if(next == NULL) 
             next = new SLL(newVal);
         else
             next->append(newVal);
     }
     T getLast() {
         if(next == NULL)
             return value;
         else
             return next->getLast();
     }
};

bool isPrime(long N) {
    if(N < 2) return false;
    if(N == 2) return true;
    if(N % 2 == 0) return false;
    for(long i = 3; i < N; i++)
        if(N % i == 0) return false;
    return true;
}

int nextPrime(long N) {
    N++;
    while(!isPrime(N))
        N++;
    return N;
}

void appendNextPrime(SLL<int> *primes) {
    int N = primes->getLast();
    N = nextPrime(N);
    primes->append(N);
}

int main(int argc, char **argv) {
    SLL<int> *primes = new SLL(2, new SLL(3, new SLL(5)));
    for(int i = 0; i < 5; i++)
        appendNextPrime(primes);
    primes->print();
    return 0;
}