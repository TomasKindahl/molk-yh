import subprocess

UNO = '192.168.1.50'
on = '1'
off = '0'

def coapcli(arg, IP):
    path_to_libcoap = r'C:\cygwin64\home\testaccount\coap\libcoap\examples'
    cmd = [f'{path_to_libcoap}/coap-client', '-e', arg, '-m', 'put', f'coap://{IP}/light']
    subprocess.call(cmd, shell = True)
