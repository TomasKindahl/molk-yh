#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main(int argc, char **argv) {
    char command[128], entry[128];
    double X, Y;
    printf("Hej och välkommen till beräkningsprogrammet.\n");
    printf("Skriv 'hjälp' för hjälp! Skriv 'sluta' för att avsluta!\n");
    printf("Kommando: ");
    while(fgets(command, 127, stdin)) {
        command[strlen(command)-1] = '\0';
        if(0 == strcmp(command, "plus")) {
             printf("tal 1: ");
             fgets(entry, 127, stdin);
             X = atof(entry);
             printf("tal 2: ");
             fgets(entry, 127, stdin);
             Y = atof(entry);
             printf("%g + %g = %g\n", X, Y, X+Y);
        }
        else if(0 == strcmp(command, "gånger")) {
             printf("tal 1: ");
             fgets(entry, 127, stdin);
             X = atof(entry);
             printf("tal 2: ");
             fgets(entry, 127, stdin);
             Y = atof(entry);
             printf("%g * %g = %g\n", X, Y, X*Y);
        }
        else if(0 == strcmp(command, "kvadrat")) {
             printf("tal: ");
             fgets(entry, 127, stdin);
             X = atof(entry);
             printf("%g ^ 2 = %g\n", X, X*X);
        }
        else if(0 == strcmp(command, "hjälp")) {
             printf("Tyvärr ej implementerat!\n");
        }
        else if(0 == strcmp(command, "sluta")) {
             break;
        }
        else {
             printf("Okänt kommando\n");
        }
        printf("Kommando: ");
    }
    printf("Hej då!\n");

    return 0;
}