mosquitto_lib = "/cygdrive/c/Program Files/mosquitto/"
mosquitto_inc = "/cygdrive/c/Program Files/mosquitto/devel"

.PHONY: all
all: client publish
client: client.c
	gcc -o client client.c -lmosquitto -I$(mosquitto_inc) -L$(mosquitto_lib)
publish: publish.c
	gcc -o publish publish.c -lmosquitto -I$(mosquitto_inc) -L$(mosquitto_lib)
