#include <iostream>
#include <fstream>
#include <vector>

using namespace std;

vector<string> split(string s, string delimiter) {
    size_t pos_start = 0, pos_end, delim_len = delimiter.length();
    string token;
    vector<string> res;

    while ((pos_end = s.find(delimiter, pos_start)) != string::npos) {
        token = s.substr (pos_start, pos_end - pos_start);
        pos_start = pos_end + delim_len;
        res.push_back (token);
    }

    res.push_back (s.substr (pos_start));
    return res;
}

class address {
  private:
    string persname, surname, phone;
    int age;
  public:
    address(vector<string> S) {
        persname = S[0]; surname = S[1]; age = stoi(S[2]); phone = S[3];
    }
    void print() {
        cout << "Name: " << persname << " " << surname << endl;
        cout << "  age: " << age << endl;
        cout << "  phone: " << phone << endl;
    }
};

int main() {
    vector<address> addr;
    string line;
    ifstream inf("adresser.txt");
    while(getline(inf, line)) {
        vector<string> S = split(line, "|");
        addr.push_back(S);
    }
    inf.close();
    for(address a : addr)
        a.print();
    return 0;
}