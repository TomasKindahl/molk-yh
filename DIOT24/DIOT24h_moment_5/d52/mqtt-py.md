# MQTT-klient i Python

Om man vill lägga till MQTT-stöd i Python, exvis
vid sidan av en Flask-server, så finns möjligheten
att använda 
[paho-mqtt](https://pypi.org/project/paho-mqtt/).
Instruktionerna som finns där fungerar, *observera*
dock: du kan välja mellan att installera med
eller utan `venv`. Välj att installera **med**
`venv` **endast** om du har tidigare erfarenhet.
Om du kör utan så installerar du med
```
pip install paho-mqtt
```
Om du dock kör `venv`  på Windows, så byter du
raden:
```
source paho-mqtt/bin/activate
```
mot
```
source paho-mqtt/Source/activate
```
och fortsätter följa instruktionerna fram till
programmet under **Getting Started**. I vår
miljö kör man i stället [mqtt-py.py](mqtt-py.py).

Dokumentation:
[Eclipse paho-mqtt, client module](https://eclipse.dev/paho/files/paho.mqtt.python/html/client.html)

