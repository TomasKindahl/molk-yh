# HTTP direkt från Python

Referens: [ChatGPT](https://chatgpt.com/share/67615374-caa0-8012-9252-f443b51e8318)

I Ardupino IDE utgå ifrån File > Examples > WifiS3 > SimpleWebServerWifi, eller [denna rättade](swsl.ino) sketch.

Lägg in följande kod i en fil
[`setlamp.py`](setlamp.py):

```
import requests

UNO = '192.168.1.50'

def setlamp(val, IP):
    response = requests.get(f'http://{IP}/{val}')
    if response.status_code == 200:
        print(response.text)
    else:
        print(f"Request failed with status code {response.status_code}")
```

På Windows kanske du behöver göra:

```
C:\Users\nisse> pip install requests
```

Kör `setlamp.py` med optionen `-i`:

```
C:\Users\nisse> python -i setlamp.py 
>>> setlamp('L',UNO)
<p style="font-size:2vw;">Click <a href="/H">here</a> turn the LED on<br></p><p style="font-size:2vw;">Click <a href="/L">here</a> turn the LED off<br></p>

>>> setlamp('H',UNO)
<p style="font-size:2vw;">Click <a href="/H">here</a> turn the LED on<br></p><p style="font-size:2vw;">Click <a href="/L">here</a> turn the LED off<br></p>

>>>

```
