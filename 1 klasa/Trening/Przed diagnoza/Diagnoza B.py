# WSTEP
print("WSTEP")
# 1. Oblicz sumę liczb 3-cyfrowych
print("Zadanie 1")
suma = 0
for i in range(100, 1000):
    suma += i
print(suma)
print()

# 2. Oblicz sumę i ilość dwucyfrowych wielokrotności liczby 6
print("Zadanie 2")
suma = 0
ile = 0
for i in range(10,100):
    if (i % 6):
        suma += i
        ile += 1
print(f"Suma: {suma}, Ilosc: {ile}")
print()
        
# 3. Znajdź największą liczbę wśród 5 wylosowanych przez program liczb 4-cyfrowych
print("Zadanie 3")
from random import randint
liczby = []
for i in range(5):
    liczby.append(randint(1000,9999))
print(f"Ta liczba to: {max(liczby)}")
print()

# 4. Podaj sumę cyfr w dowolnej liczbie
print("Zadanie 4")
liczba = input()
suma = 0
for i in liczba:
    suma += int(i)
print(suma)

# 5. Znajdź najmniejszą cyfrę we wpisanej przez usera liczbie 3-cyfrowej
print("Zadanie 5")
liczba = input()
mini = liczba[0]
for i in liczba:
    if i < mini:
        mini = i
print(f"Najmniejsza cyfra w liczbie: {mini}")
        
# ALGORYTMY
print("ALGORYTMY")
# 1. Sprawdź czy wpisana przez usera liczba jest pierwsza
print("Zadanie 1")
liczba = int(input())
flaga = True
for i in range(2, liczba):
    if liczba % i:
        flaga = False
if flaga:
    print("Tak")
else:
    print("Nie")        
print()        

# 2. Sprawdź czy wpisana przez usera liczba jest złożona - liczba nie pierwsa
print("Zadanie 2")
liczba = int(input())
flaga = False
for i in range(2, liczba):
    if liczba % i:
        flaga = True
if flaga:
    print("Tak")
else:
    print("Nie")        
print()   

# 3. Sprawdź czy wpisana przez usera liczba jest względnie pierwsza z 24 - ich nwd to 1
print("Zadanie 3")
def nwd(a, b):
    while a != b:
        if a > b:
            a -= b
        else:
            b -= a
    return a
    
liczba = int(input())
if nwd(liczba, 24) == 1:
    print("Tak")
else:
    print("Nie")


# 4. Zakoduj szyfrem CEZARA i kluczem k słowo s. - do nauczenia
print("Zadanie 4")
k = int(input("Klucz: "))
napis = input("Napis: ")
szyfr = ""
for i in range(len(napis)):
  szyfr += chr( 65 + (ord(napis[i]) - 65 + k) % 26)
print(f"Napis: {napis} Szyfr: {szyfr}")
print()

# 5. Dodaj dwa ułamki a/b + c/d. Zapisz sumę jako ułamek nieskracalny i liczbę mieszaną.
print("Zadanie 5")
a = int(input("Gora1: "))
b = int(input("Dol 1: "))
c = int(input("Gora 2: "))
d = int(input("Dol 2: "))
sumaGora = a + c
sumaDol = b + d
NWD = nwd(sumaGora, sumaDol)
gotowaGora = sumaGora // NWD
gotowyDol = sumaDol // NWD
reszta = gotowaGora % gotowyDol

print(f"Gotowy ulamek niewlasciwy: {gotowaGora} / {gotowyDol}")
print(f"Liczba mieszana {gotowaGora//gotowyDol} {reszta} / {gotowyDol}")
print()

# 6. Znajdź NWW dwóch wpisanych przez usera liczb
def nww(a, b):
    return a * b / nwd(a, b)
a = input()
b = input()
print(f"NWW: {nww(a, b)}")
print()

print("NAPISY")
# 1. Znajdź ilość liter C we wpisanym napisie
napis = input()
ile = 0
for i in napis:
    if i == "C":
        ile += 1
print(f"Ilosc C w wpisanym napisie: {ile}")

# 2. Sprawdź czy literki w napisie są w porządku nierosnącym: np ZOO, WOK, WODA itp
# 3. Podaj najdłuższy z 3 wpisanych przez usera wyrazów.


