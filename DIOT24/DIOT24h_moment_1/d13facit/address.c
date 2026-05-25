#include <stdlib.h>
#include <stdio.h>
#include <string.h>

struct code { int n; char *abbr; };

struct address {
    char name[40];
    char phone[40];
};

int main(int argc, char **argv) {
    struct code cvar = {3, "tre"};

    struct address Arne;
    struct address Berith;
    strcpy(Arne.name, "Arne Svensson");
    strcpy(Arne.phone, "013-131313");
    printf("%s ", Arne.name);
    printf("%s\n", Arne.phone);
    strcpy(Berith.name, "Berith Qvist");
    strcpy(Berith.phone, "0616-616 616");
    printf("%s ", Berith.name);
    printf("%s\n", Berith.phone);
    return 0;
}