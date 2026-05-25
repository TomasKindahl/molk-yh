#include <stdio.h>

#if defined(__cplusplus)

const int Sunday = 0;
const int Monday = 1;
const int Tuesday = 2;
const int Wednesday = 3;
const int Thursday = 4;
const int Friday = 5;
const int Saturday = 6;

char proglan[] = "C++";

#else

#define Sunday 0
#define Monday 1
#define Tuesday 2
#define Wednesday 3
#define Thursday 4
#define Friday 5
#define Saturday 6

char proglan[] = "C";

#endif

const char *weekday(int daynum) {
    switch(daynum) {
      case Sunday: return "söndag";
      case Monday: return "måndag";
      case Tuesday: return "tisdag";
      case Wednesday: return "onsdag";
      case Thursday: return "torsdag";
      case Friday: return "fredag";
      case Saturday: return "lördag";
      default: return "(unknown day)";
    }
}

int main() {
    printf("%s\n", proglan);
    for(int i = Sunday; i <= Saturday; i++)
        printf("dag %d är %s\n", i, weekday(i));
    printf("Tryck enter för att fortsätta ...");
    char ch = fgetc(stdin);
    return 0;
}