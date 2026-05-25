#include <stdlib.h>
#include <stdio.h>
#include <string.h>

struct code { int n; char *abbr; };

struct address {
    char name[40];
    char phone[40];
};

void printaddress(struct address addr) {
    printf("%s ", addr.name);
    printf("%s\n", addr.phone);
}

void setaddress(struct address *addr, char name[], char phone[]) {
    strcpy(addr->name, name);
    strcpy(addr->phone, phone);
}

int main(int argc, char **argv) {
    struct code cvar = {3, "tre"};

    struct address Arne;
    struct address Berith;
    setaddress(&Arne, "Arne Svensson", "013-131313");
    printaddress(Arne);
    setaddress(&Berith, "Berith Qvist", "0616-616 616");
    printaddress(Berith);
    return 0;
}