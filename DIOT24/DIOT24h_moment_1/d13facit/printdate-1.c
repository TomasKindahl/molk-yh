#include <stdlib.h>
#include <stdio.h>
#include <string.h>

struct date {
   int year; int month; int day;
};

void printdate(struct date D) {
    printf("%d-%d-%d\n", D.year, D.month, D.day);
}

int main(int argc, char **argv) {
    struct date D1 = {2024, 11, 5}, D2 = {2024, 12, 24};
    printdate(D1);
    printdate(D2);
    return 0;
}