import requests

UNO = '192.168.1.50'

def setlamp(val, IP):
    response = requests.get(f'http://{IP}/{val}')
    if response.status_code == 200:
        print(response.text)
    else:
        print(f"Request failed with status code {response.status_code}")

