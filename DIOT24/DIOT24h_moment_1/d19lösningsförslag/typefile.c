#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main(int argc, char **argv) {
    FILE *f;
    f = fopen("fil.txt", "rt");
    char line[1024];
    while(fgets(line, 1024, f)) {
        printf("%s", line);
    }
    fclose(f);
    return 0;
}