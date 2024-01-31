#ZADANIE 1
print("Zadanie 1")
for i in range(1,31):
    print(i, end=" ")
print(' ')


#ZADANIE 2
print("Zadanie 2")
for i in range(1,100):
    if i%2==1:
        print(f"{i}^2 = {i**2}")
print(' ')


#ZADANIE 3
print("Zadanie 3")
for i in range(1000,10000):
    if i%379:
        print(i, end=" ")
print(' ')


#ZADANIE 4
print("Zadanie 4")
for i in range(100,1000):
    if i%5 == 0 or i%6 == 0 or i%11 == 0:
        print(i, end=" ")
print(' ')


#ZADANIE 5
print("Zadanie 5")
suma = 0
n = int(input("Ile liczb chcesz wypisac: "))
for i in range(1, n+1):
    n_liczb = int(input("Podaj liczbe: "))
    suma = suma + n_liczb
print(suma)
print(' ')


#ZADANIE 6
print("Zadanie 6")
k = int(input("Podaj liczbe: "))
for i in range(2, (k*2)+2,2):
    suma = suma + i
print(suma)
print(' ')


#ZADANIE 7
print("Zadanie 7")
m = int(input("Podaj liczbe: "))
for i in range(11, (m*2)+2, 11):
    suma = suma + i
print(suma)
print(' ')


#ZADANIE 8
print("Zadanie 8")
W0 = int(input("Podaj kapital poczatkowy: "))
L = int(input("Podaj ile lat ma trwac inwestycja: "))
WK = 0
suma = W0
for i in range(1 , L*12):
    WX=suma*0.06*(1/12)
    suma = suma+WX
print(f" Kapital po tym czasie bedzie wynosil: {round(suma)}")
print(' ')

#ZADANIE 9
print("Zadanie 9")
a = int(input("Podaj ilosc liczb: "))
suma = 0
for i in range(21, 21+(a*100)+1, 100):
    suma+=i
print(f"Suma to: {suma}")
print(' ')

#ZADANIE 10
from math import sqrt
for i in range(1,1000):
    if i%10 == sqrt(i):
        print(i)
    if i%100 == sqrt(i):
        print(i)


