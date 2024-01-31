#Zad 1
a = int(input("Podaj pierwsza liczbe: "))
b = int(input("Podaj druga liczbe: "))
suma=a+b
if suma%2 == 0:
    print("Tak, Suma tych dwoch liczb jest liczba parzysta")
else:
    print("Nie, Suma tych dwoch liczb nie jest liczba parzysta")

print=(" ")

#Zad 2
from math import sqrt

a = int(input("Podaj pierwsza liczbe: "))
g = int(input("Podaj druga liczbe: "))
c=(a+g)/2
d=sqrt(a*g)
if c>d:
    print("Tak, srednia arytmetyczna jest wieksza od sredniej geometrycznej")
else:
    print("Nie, srednia arytmetyczna nie jest wieksza od sredniej geometrycznej")

print(" ")
#Zad 3
k = int(input("Podaj liczbe1: "))
l = int(input("Podaj liczbe2: "))
m = int(input("Podaj liczbe3: "))
if k == l and k == m and l == m:
    print("Wszystkie liczby sa sobie rowne")
    if k == l: print("liczba1 i liczba2 sa sobie rowne")
    elif k == m: print("liczba1 i liczba3 sa sobie rowne")
    elif l == m: print("liczba2 i liczba3 sa sobie rowne")
else: 
    print("Nie ma rownych sobie liczb")

print(" ")
#Zad 4
a = int(input("Liczba1: "))
b = int(input("Liczba2: "))
c = int(input("Liczba3: "))
d = int(input("Liczba4: "))
if a<b and a<c and a<d: print("Liczba1 jest najmniejsza")
elif b<a and b<c and b<d: print("Liczba2 jest liczba najmniejsza")
elif c<a and c<b and c<d: print("Liczba3 jest liczba najmniejsza")
elif d<a and d<b and d<c: print("Liczba4 jest liczba najmniejsza")
else:
    print("Sa przynajmniej 2 liczby najmniejsze rowne sobie")

print(" ")

#Zad 5
a = int(input("liczba1: "))
b = int(input("liczba2: "))
c = int(input("liczba3: "))
if a+b>c and b+c>a and a+c>b:
    print("TAK, Te 3 wprowadzone liczby spelniaja nierownosc trojkata")
else:
    print("NIE, Te 3 wprowadzone liczby spelniaja nierownosc trojkata")

print(" ")
#Zad 6
a = int(input("liczba1: "))
b = int(input("liczba2: "))
c = int(input("liczba3: "))
if a+b>c and b+c>a and a+c>b:
    print("Powstanie trojkat ")
    if a**2 + b**2 == c**2 or b**2 + c**2 == a**2 or c**2 + a**2 == b**2: print("prostokatny")
    elif a**2 + b**2 > c**2 or b**2 + c**2 > a**2 or c**2 + a**2 > b**2: print("ostrokatny")
    elif a**2 + b**2 < c**2 or b**2 + c**2 < a**2 or c**2 + a**2 < b**2: print("rozwartokatny")
else:
    print("Trojkat nie powstanie")









