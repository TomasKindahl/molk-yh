# Diot24H_Moment_5, dag 51, Mosquitto i Linux

[UP](../D24-M5-d51.md) [Here](.)

## Filer

- [Makefile](Makefile)
- [client.c](client.c)
- [mosquitto.md](mosquitto.md)
- [publish.c](publish.c)

# Mosquitto i Linux

För att installera rätt paket på Linux krävs

```
sudo apt install mosquitto mosquitto-clients mosquitto-dev -y
```

vilket du  högst sannolikt gjort reda, men det krävs också:

```
sudo apt install libmosquitto-dev -y
```

Därefter behöver du bara skriva

```
make
```

för att kompilera och länka programmen.