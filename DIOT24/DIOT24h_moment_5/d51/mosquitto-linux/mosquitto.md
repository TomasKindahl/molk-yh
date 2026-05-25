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