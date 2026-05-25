.PHONY: all
all: client publish
client: client.c
	gcc -o client client.c -lmosquitto
publish: publish.c
	gcc -o publish publish.c -lmosquitto
