CC = gcc
LIB = ../lib
INC = ../include
BIN = ../bin

$(BIN)/iarr: main.c $(LIB)/libiarrop.a
	$(CC) -o $@ $< -I$(INC) $(LIB)/libiarrop.a
$(LIB)/libiarrop.a: iacc.o iarr_to_str.o iscan.o
	ar rcs $@ iacc.o iarr_to_str.o iscan.o
iacc.o: iacc.c
	$(CC) -o $@ -c $< -I$(INC) 
iarr_to_str.o: iarr_to_str.c
	$(CC) -o $@ -c $< -I$(INC) 
iscan.o: iscan.c
	$(CC) -o $@ -c $< -I$(INC) 
.PHONY: clean
clean:
	rm -f $(BIN)/iarr *.o $(LIB)/*.a
.PHONY: run
run: $(BIN)/iarr
	./$(BIN)/iarr
