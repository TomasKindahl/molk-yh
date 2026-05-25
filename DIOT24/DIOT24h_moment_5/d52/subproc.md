# Python, subprocess

## CoAP

I fallet med CoAP ([lab d43](http://moodle.molk.se/mod/page/view.php?id=6972)) är det svårt att hitta ett
Python-bibliotek för CoAP (om du är djärv kan du testa
[CoAPthon](https://github.com/Tanganelli/CoAPthon)),
en enklare lösning är att anropa ett program från
kommandoraden med hjälp av paketet `subprocess`:

```
import subprocess

UNO = '192.168.1.50' # Sätt rätt adress
on = '1'
off = '0'

def coapcli(arg, IP):
    path_to_libcoap = r'C:\cygwin64\home\testaccount\coap\libcoap\examples'
    cmd = [f'{path_to_libcoap}/coap-client', '-e', arg, '-m', 'put', f'coap://{IP}/light']
    subprocess.call(cmd, shell = True)
```

Kontrollera att `coap-client` ligger på
`path_to_libcoap`!

eller i Linux, enklare:

```
import subprocess

UNO = '192.168.1.50' # Sätt rätt adress
on = '1'
off = '0'

def coapcli(arg, IP):
    # KONTROLLERA path:
    path_to_libcoap = '/home/rursus/Programming/libcoap/examples'
    cmd = [f'{path_to_libcoap}/coap-client', '-e', arg, '-m', 'put', f'coap://{IP}/light']
    subprocess.call(cmd)
```
Gör en fil `coappy.py`
([Linux](coappy-linux.py),
 [Windows](coappy-windows.py)) med ovanstående kod!
Starta den med följande anrop:

```
$ python -i coappy.py
>>> coapcli(on,UNO)
1
>>> coapcli(off,UNO)
0
>>> exit()
```
