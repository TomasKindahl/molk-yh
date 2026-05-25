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
    struct date helger2025[13];
    setdate(&helger2025[0],2025,1,1);
    setdate(&helger2025[1],2025,1,6);
    setdate(&helger2025[2],2025,4,18);
    setdate(&helger2025[3],2025,4,20);
    setdate(&helger2025[4],2025,4,21);
    setdate(&helger2025[5],2025,5,1);
    setdate(&helger2025[6],2025,5,29);
    setdate(&helger2025[7],2025,6,6);
    setdate(&helger2025[8],2025,6,8);
    setdate(&helger2025[9],2025,6,21);
    setdate(&helger2025[10],2025,11,01);
    setdate(&helger2025[11],2025,12,25);
    setdate(&helger2025[12],2025,12,26);
    for(int i = 0; i < 13; i++)
        printdate(helger2025[i]);

    return 0;
}