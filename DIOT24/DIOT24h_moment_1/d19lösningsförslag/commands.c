#include <stdio.h>
#include <string.h>

int main(int argc, char **argv) {
    char command[100];
    printf("Welcome to the interactive XYZZY!\n");
    printf("Please write 'help' for help.\n");
    while(1) {
       printf("Command: ");
   	   fgets(command, 100, stdin);
       int len = strlen(command);
       command[len-1] = 0;
       if(0 == strcmp(command, "help")) {
           printf("Commands:\n");
           printf("  help - write this help\n");
           printf("  quit - quit this program\n");
       }
       else if(0 == strcmp(command, "quit")) {
           break;
       }
    }
    printf("Bye!\n");
    return 0;
}