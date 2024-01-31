def NWD(a, b):
    while a != b:
        if a > b:
            a -= b
        else:
            b -= a
        return b


def Czy_Pierwsza(x):
    for i in range(2, x):
        if x % i == 0:
            return False
    return True


# Zadania 1 - do zrozumienia
x = int(input("Podaj liczbe: "))
suma = 0
while x > 0:
    suma += x % 10
    x //= 10
print(suma)

# Zadania 2
x = int(input("Podaj liczbe: "))
temp = 0
for i in range(1, x):
    if x % i == 0:
        temp += 1
if temp < 3:
    print("tak")
else:
    print("nie")

# Zadania 3 - liczby doskonale- dzielniki dodane do siebie daja ta liczbe nie liczac jej samej
n = int(input("Podaj liczbe: "))
suma = 0
for i in range(1, n):
    if i % n == 0:
        suma += i
if suma == n:
    print("Jest doskonala")
else:
    print("Nie jest doskonala")

# Zadania 4 - wzglednie pierwsze- ich nwd = 1
x = int(input("Podaj liczbe1: "))
y = int(input("Podaj liczbe2: "))
nwd = NWD(x, y)
if nwd == 1:
    print("Liczby sa wzglednie pierwsze")
else:
    print("Liczby nie sa wzglednie pierwsze")

# Zadania 5
m = int(input("Podaj liczbe: "))
for i in range(10, 20):
    x = m
    y = i
    nwd = NWD(x, y)
    if nwd == 1:
        print(f"Wzglednie pierwsze: {m}, {i}")

# Zadania 6
a = int(input("Licznik: "))
b = int(input("Mianownik: "))
a, b = x, y
nwd = NWD(x, y)
a //= nwd
b //= nwd
print(f"Skrocony ulamek {x}/{y} == {a}/{b}")

# Zadania 7
a = int(input("Licznik: "))
b = int(input("Mianownik: "))
if a % b == 0:
    calosci = a//b
    print(f"Wyciagniete calosci z tego ulamka: {calosci}")
if a < b:
    print("Ulamek jest wlasciwy")
else:
    calosci = a // b
    reszta = a % b
    dzielnik = NWD(reszta, b)
    skroconaReszta = reszta/dzielnik
    skroconyLicznik = b/dzielnik
    print(f"Wyciagniete calosci z tego ulamka: {calosci} i {skroconaReszta}/{skroconyLicznik}")

# Zadania 8
T = []
for i in range(2, 10000):

    spr1 = 0
    for j in range(1, i):
        if i % j == 0:
            spr1 += j
    T.append(spr1)
    spr2 = 0
    for k in range(1, spr1):
        if spr1 % k == 0:
            spr2 += k

    if i == spr2 and spr1 != spr2 and spr2 not in T:
        print(f"({spr1},{spr2})")

# Zadania 9
for i in range(1, 100):
    for j in range(2, i):
        if i % j == 0:
            if Czy_Pierwsza(j) and Czy_Pierwsza(i // j):
                print(i)
                break

# Zadania 10
n = int(input())
ile1 = 0
ile2 = 0
for i in range(n - 2):
    if n % i == 0:
        ile1 += 1

for j in range(n + 2):
    if n % j == 0:
        ile2 += 1

if ile1 < 3 and ile2 < 3:
    print(f"Liczby blizniacze liczby {n} to {n - 2} i {n + 2}")
elif ile1 < 3 and ile2 > 2:
    print(f"Liczby blizniacze liczby {n} to tylko liczba {n - 2}")
elif ile1 > 2 and ile2 < 3:
    print(f"Liczby blizniacze liczby {n} to tylko liczba {n + 2}")
else:
    print("Liczba nie ma blizniakow")
