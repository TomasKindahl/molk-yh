#include <iostream>

using namespace std;

enum Month {
   January, February, March, April, May, June,
   July, August, September, October, November, December
};

Month NextMonth(Month m) {
    return (Month)(m + 1);
}

string MonthToString(Month m) {
   switch(m) {
      case January:   return "January"s;
      case February:  return "February"s;
      case March:     return "March"s;
      case April:     return "April"s;
      case May:       return "May"s;
      case June:      return "June"s;
      case July:      return "July"s;
      case August:    return "August"s;
      case September: return "September"s;
      case October:   return "October"s;
      case November:  return "November"s;
      case December:  return "December"s;
   }
   return "(något ointressant)"s; /* bara för att kompilatorn ska bli nöjd! */
}

int main(int argc, char **argv) {
    for(Month w = January; w <= December; w = NextMonth(w)) {
        cout << MonthToString(w) << endl;
    }
    return 0;
}