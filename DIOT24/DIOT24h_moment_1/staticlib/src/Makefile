CC = gcc
LIB = ../lib
INC = ../include
BIN = ../bin

$(BIN)/iarr: main.c $(LIB)/iacc.o $(LIB)/iarr_to_str.o $(LIB)/iscan.o
	$(CC) -o $@ $< -I$(INC) $(LIB)/iacc.o $(LIB)/iarr_to_str.o $(LIB)/iscan.o
$(LIB)/iacc.o: iacc.c
	$(CC) -o $@ -c $< -I$(INC) 
$(LIB)/iarr_to_str.o: iarr_to_str.c
	$(CC) -o $@ -c $< -I$(INC) 
$(LIB)/iscan.o: iscan.c
	$(CC) -o $@ -c $< -I$(INC) 
.PHONY: clean
clean:
	rm -f $(BIN)/iarr $(LIB)/*.o
.PHONY: run
run: $(BIN)/iarr
	./$(BIN)/iarr
