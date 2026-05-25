#include <iostream>
#include <fstream>

using namespace std;

int main() {
    string line;
    ifstream inf("file.txt");
    ofstream otf("copy.txt");
    while(getline(inf, line))
        otf << line << endl;
    inf.close();
    otf.close();
    return 0;
}