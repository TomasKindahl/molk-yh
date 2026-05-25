/* Code adapted by TomKi from StackOverflow:
 *   https://stackoverflow.com/questions/5791860/beginners-socket-programming-in-c
 */

#include<arpa/inet.h>
#include<sys/types.h>
#include<sys/socket.h>
#include<netinet/in.h>
#include<fcntl.h>
#include<stdlib.h>
#include<string.h>
#include<stdio.h>
#include<unistd.h>

#define SERVER_IP "192.168.1.50"
#define DESTPORT 80

int main() {

    struct sockaddr_in dest_addr;
    
    int sockfd = socket(AF_INET,SOCK_STREAM,0);

    dest_addr.sin_family = AF_INET;
    dest_addr.sin_port = htons(DESTPORT);
    dest_addr.sin_addr.s_addr = inet_addr(SERVER_IP);
    dest_addr.sin_zero[8]='\0';

    printf("Trying %s...\n", SERVER_IP);
    int res = connect(sockfd,(struct sockaddr*)&dest_addr, sizeof(struct sockaddr));
    if(res != 0) {
        printf("connection with the server failed...\n");
        exit(0);
    }

    char msg[100];
    printf("Connected to %s.\n", SERVER_IP);
    printf("Enter you message: ");
    fgets(msg, 100, stdin);
    msg[strlen(msg)-1] = '\0';
    strcat(msg, "\n\n\n");
    printf("Sending: %s\n", msg);
    
    int w = write(sockfd, msg, strlen(msg));
    
    close(sockfd);
    printf("Client closing.....\n"); 

    return 0;
}
