# # Zadanie 3
# print("Zadanie 3")
# suma = 0
# for i in range(10, 100):
#     if i % 2 == 1:
#         suma += i
# print(suma)

# # Zadanie 4
# print("Zadanie 4")    
# ile = 0
# for i in range(100, 1000):
#     if i % 2 == 1 and i % 17 == 0:
#         ile += 1
# print(ile)

# # Zadanie 5
# print("Zadanie 5")
# n = int(input())
# ile = 0
# for i in range(1, n):
#     if n % i == 0:
#         ile += 1
# print(ile)

# # Zadanie 6
# print("Zadanie 6")
# sumaDzielnikow = 0
# n = int(input())
# for i in range(1, n):
#     if n % i == 0:
#         sumaDzielnikow += i
# if sumaDzielnikow == n:
#     print("Tak")
# else:
#     print("Nie")
    
# Zadanie 7
from math import gcd, lcm
print("Zadanie 7")
licznik1 = int(input())
mianownik1 = int(input())
licznik2 = int(input())
mianownik2 = int(input())

iloczyn = mianownik1 * mianownik2
wspolnyMianownik = iloczyn // gcd(mianownik1, mianownik2)

gotowyLicznik1 = (mianownik1 // gcd(mianownik1, mianownik2)) * licznik1
gotowyLicznik2 = (mianownik2 // gcd(mianownik1, mianownik2)) * licznik2

licznik = gotowyLicznik1 - gotowyLicznik2

dzielnik = gcd(licznik, wspolnyMianownik)

print(f"Odjety ulamek w postaci nieskracalnej: {licznik} / {wspolnyMianownik}")

# Zadanie 8
print("Zadanie 8")
s = input()
ile = 0
for i in s:
    if ord(i) % 2 == 1:      
        ile += 1
print(ile)

# Zadanie 9
print("Zadanie 9")
ileA = 0
for i in range(3):
    slowo = input()
    for j in slowo:
        if j == "A":
            ileA += 1
if ileA >= 4:
    print("Tak")
else:
    print("Nie")
    