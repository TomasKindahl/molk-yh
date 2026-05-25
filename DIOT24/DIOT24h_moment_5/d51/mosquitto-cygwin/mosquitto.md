# Mosquitto i CygWin

Om du redan installerat CygWin och Mosquitto så gäller det bara att länka
upp rätt DLL:er och peka ut rätt utvecklingskatalog. Det görs i Makefile
genom raderna 

```
mosquitto_lib = "/cygdrive/c/Program Files/mosquitto/"
mosquitto_inc = "/cygdrive/c/Program Files/mosquitto/devel"
```

Du behöver bara skriva

```
make
```

för att kompilera och länka programmen.