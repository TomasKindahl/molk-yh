CC = gcc
main: main.c mymath.h mymath.o
	$(CC) -o main main.c mymath.o
mymath.o: mymath.c
	$(CC) -c mymath.c
clean:
	rm -f *.o main
	rm -f main
