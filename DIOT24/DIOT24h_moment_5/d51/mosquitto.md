# Kodstubbar för anrop av MQTT från C

Källa: [Diskussion med ChatGPT 40 mini 2024-12-16](https://chatgpt.com/share/67600159-7b2c-8012-b87f-2849ba75e8e5)

Plus egna modifieringar.

- [Linux-versionen](mosquitto-linux/mosquitto.md)
- [Cygwin-versionen](mosquitto-cygwin/mosquitto.md)

Hur man kan gå vidare:

1. kolla länken [Arguments to main in C [duplicate]](https://stackoverflow.com/questions/4176326/arguments-to-main-in-c)
2. skriv om publish så att du kan ge host som
   argument 1 och on eller off på argument 2
3. skriv om client sammalunda

Se även: [arg.c](arg.c). Kompilera med
```
gcc -o arg arg.c
```
Testa med:
```
$ ./arg abra kadabra hokus pokus filiokus
Number of arguments = 6
  0: ./arg
  1: abra
  2: kadabra
  3: hokus
  4: pokus
  5: filiokus
```
