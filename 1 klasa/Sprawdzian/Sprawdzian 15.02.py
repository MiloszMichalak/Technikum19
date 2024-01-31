# NIE WIEM CO TU SIE DZIEJE ALE BEDE PISAL
# GRUPA 1 
# Czesc 2 pierwsza kartka
from math import ceil

licznik = int(input())
mianownik = int(input())


def nww(a, b):
    mnoz = a*b
    while b > 0:
        a, b = b , a%b
    return mnoz // b

def nwd(a, b):
    while b > 0:
        a, b = b , a%b
        return b

idk = ceil(mianownik/licznik)
print(idk)

for i in range(mianownik, 0, -1):
    if i > idk:
        liczba = i
    if i < idk:
        break

for i in range(1):
    nww(mianownik, liczba)
    nowyLicznik *= ()
    #idk
