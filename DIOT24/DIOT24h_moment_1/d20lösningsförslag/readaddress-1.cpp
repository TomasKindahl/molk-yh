#include <iostream>
#include <fstream>

using namespace std;

int main() {
    string line;
    ifstream inf("adresser.txt");
    while(getline(inf, line))
        cout << line << endl;
    inf.close();
    return 0;
}