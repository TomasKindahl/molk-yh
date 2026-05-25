CC = gcc
bin = ../bin
include = ../include
lib = ../lib

$(bin)/main: main.c $(include)/mymath.h $(lib)/mymath.o
	$(CC) -o $(bin)/main main.c $(lib)/mymath.o -I$(include)
$(lib)/mymath.o: mymath.c $(include)/mymath.h
	$(CC) -o $(lib)/mymath.o -c mymath.c -I$(include)
clean:
	rm -f $(lib)/*.o
	rm -f $(bin)/main
