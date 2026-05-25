import subprocess

UNO = '192.168.1.50'
on = '1'
off = '0'

def coapcli(arg, IP):
    path_to_libcoap = '/home/rursus/Programming/libcoap/examples' # KONTROLLERA
    cmd = [f'{path_to_libcoap}/coap-client', '-e', arg, '-m', 'put', f'coap://{IP}/light']
    subprocess.call(cmd)
