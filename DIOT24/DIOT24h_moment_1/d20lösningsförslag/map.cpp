#include <iostream>
#include <map>
using namespace std;
int main() {
    // Example with map:
    map<string, int> ageMap; 
    ageMap["Alice"] = 25;
    ageMap["Bob"] = 30;
    ageMap["Charlie"] = 22;
    for (const auto& pair : ageMap) {
        cout << pair.first << " is ";
        cout << pair.second;
        cout << " years old." << endl;
    } 
    return 0;
}
