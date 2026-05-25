/* Code adapted by TomKi from StackOverflow:
 *   https://stackoverflow.com/questions/5791860/beginners-socket-programming-in-c
 */

#include<arpa/inet.h>
#include<sys/types.h>
#include<sys/socket.h>
#include<netinet/in.h>
#include<fcntl.h>
#include<stdio.h>
#include<string.h>
#include<unistd.h>

#define ANY_IP "0.0.0.0"
#define PORT 8080

int main() {
    int sockfd;
    int clientfd;
    int bytes_read;
    char buf[100];
    int struct_size;
    struct sockaddr_in my_addr;
    struct sockaddr_in con_addr;
    
    sockfd = socket(AF_INET, SOCK_STREAM, 0);
    
    my_addr.sin_family = AF_INET;
    my_addr.sin_port = htons(PORT);
    my_addr.sin_addr.s_addr = inet_addr(ANY_IP);
    my_addr.sin_zero[8]='\0';

    bind(sockfd, (struct sockaddr*)&my_addr, sizeof(struct sockaddr));

    listen(sockfd,5);
    
    struct_size = sizeof(con_addr);
    clientfd = accept(sockfd, (struct sockaddr*)&con_addr, &struct_size);

    bytes_read = read(clientfd, buf, 100);
    buf[bytes_read] = '\0';
    printf("Message from client:%d is %s \n",clientfd, buf);

    close(sockfd);
    close(clientfd);

    return 0; /* TomKi was here! */
}