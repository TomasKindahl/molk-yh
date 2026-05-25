#include <stdlib.h>
#include <stdio.h>
#include <string.h>

struct date {
   int year; int month; int day;
};

void printdate(struct date D) {
    printf("%d-%d-%d\n", D.year, D.month, D.day);
}

void setdate(struct date *D, int year, int month, int day) {
    D->year = year;
    D->month = month;
    D->day = day;
}

int main(int argc, char **argv) {
    struct date D1 = {2024, 11, 5}, D2 = {2024, 12, 24};
    printdate(D1);
    printdate(D2);
    setdate(&D1, 2028, 11, 5);
    printdate(D1);
    return 0;
}