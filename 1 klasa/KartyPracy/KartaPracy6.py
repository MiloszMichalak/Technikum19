# Zadanie 1
print("Zadanie 1")
a = int(input("Liczba1: "))
b = int(input("Liczba2: "))
c = int(input("Liczba3: "))
print("Ciag jest: ", end=" ")
if b - a == c - b:
    print("arytmetyczny", end=" ")
if b // a == c // b:
    print("geometryczny", end=" ")
if a < b < c:
    print("rosnący")
if a > b > c:
    print("malejący")

print()

# Zadanie 2
print("Zadanie 2")
suma = 0
for i in range(100, 1000):
    if i % 8 == 0 and i % 16 != 0:
        suma += i
print(f"Suma liczb trzycyfrowych podzielnych przez 8 i niepodzielnych przez 16 wynosi: {suma}")

print()

# Zadanie 3
print("Zadanie 3")
dzielnik = 0
ilosc = 0
for i in range(99, 10, -1):
    if i % 7 == 0:
        dzielnik = i
        break

for i in range(1000, 10000):
    if i % dzielnik == 0:
        ilosc += 1

print(f"Ilosc liczb czterocyrowych podzielnych przez najwieksza liczbe dwucyfrowa podzielna przez 7 wynosi: {ilosc}")

print()

# Zadanie 4
print("Zadanie 4")
ilosc = 0
for i in range(10, 100):

    dz = int(i // 10)
    jed = int(i % 10)

    if dz > jed * 2:
        ilosc += 1

print(f"Ilosc liczb dwucyfrowych ktorych liczba dziesiatek jest 2 razy wieksza od liczby jednosci wynosi: {ilosc}")

print()

# Zadanie 5
print("Zadanie 5")
suma = 0
ilosc = 0
for i in range(100, 1000):
    set = i//100
    dz = (i % 100)//10
    jed = i % 10
    if set > dz+jed:
        suma += i
        ilosc += 1

print(f"Suma liczb trzycyfrowych w ktorych liczba setek jest wieksza od sumy liczby dziesiatek i jednosci wynosi: {suma}, a ilosc takich liczb wynosi: {ilosc}")

print()

# Zadanie 6
print("Zadanie 6")
n = int(input("Ile liczb chcesz znaleść: "))
suma = 0
ilosc = 0
for i in range(10, 100):
    if i % 19 == 0:
        suma += i
        ilosc += 1
    if n == ilosc:
        print(f"Suma n elementow najmniejszych liczb dwucyfrowych podzielnych przez 19 wynosi: {suma}")
        break
    if i == 99:
        print("Out of range")

print()

# Zadanie 7
print("Zadanie 7")
n = int(input("Ile liczb chcesz znaleść: "))
suma = 0
ilosc = 0
for i in range(999, 100, -1):
    if i % 37 == 0:
        suma += i
        ilosc += 1
    if n == ilosc:
        print(f"Suma n elementow najwiekszych liczb trzycyfrowych podzielnych przez 37 wynosi: {suma}")
        break
    if i == 101:
        print("Out of range")

print()

# Zadanie 8
print("Zadanie 8")
n = int(input("Podaj ile powtorzen ma miec ciag: "))
suma = 0
rytm = 2
for i in range(n):
    if i % 2 != 0:
        rytm *= -1
        suma += rytm
        rytm *= -1
    else:
        suma += rytm
    rytm += 3

print(f"Suma n elementow ciagu skaczącego wynosi: {suma}")

print()

# Zadanie 9
print("Zadanie 9")
n = int(input("Podaj ile powtorzeń ma mieć ciąg: "))
iloczyn = 1
for i in range(2, n+2):
    rytm *= 2
    if i % 2 == 0:
        rytm *= -1
        iloczyn *= rytm
        rytm *= -1
    else:
        iloczyn *= rytm
print(f"Iloczyn n elementow ciagu zakreconego wynosi: {iloczyn}")

print()

# Zadanie 10
print("Zadanie 10")
n = int(input("Jak dlugi ma byc ciąg:"))
suma = 0
silnia = 1
rytm = 1
for i in range(n):
    iloczyn += silnia
    silnia *= rytm
    rytm += 1

print(f"Iloczyn n elementow ciagu siłaczy wynos: {suma}")

print()

# Zadanie 11
print("Zadanie 11")
n = int(input("Jak dlugi ma być ciąg: "))
suma = 0
licznik = 1
mianownik = 1
for i in range(n):
    suma += licznik / mianownik
    licznik += 2
    mianownik += licznik

print(f"Suma n elementow ciagu niebanalanego1 wynosi: {suma}")

print()

# Zadanie 12
print("Zadanie 12")
n = int(input("Jak dlugi ma być ciąg: "))
licznik = 0
mianownik = 0
ciag1 = 1
ciag2 = 1
for i in range(n):
    licznik += ciag1
    mianownik += ciag2
    ciag1 += 2
    ciag2 += ciag1

print(f"Suma n elementow ciagu niebanalnego2 wynosi: {licznik/mianownik}")

print()

# Zadanie 13 i 14
print("Zadanie 13 i 14")
n = int(input("Jak dlugi ma byc ciąg: "))
suma = 0
licznik = 2
mianownik = 3
for i in range(2, n+2):
    suma += licznik / mianownik
    licznik += 2
    mianownik = (i**3)+2

print(f"Suma n elementow ciagu wymagającego wynosi: {suma}")

print()

# Zadanie 15
print("Zadanie 15")
licznik = 1
mianownik = 1
ciag1 = 3
ciag2 = 1
for i in range(n):
    licznik *= ciag1
    mianownik *= ciag2
    ciag1 += 1
    ciag2 = (ciag2*2)+1

print(f"Iloczyn n elementow ciagu totalnego wynosi: {licznik / mianownik}")

print()

# Zadanie 16
print("Zadanie 16")
n = int(input("Jak dlugi ma byc ciag: "))
licznik = 1
mianownik = 1
ciag1 = 1
ciag2 = 1
fib1 = 1
fib2 = 1
sumafib = 0
for i in range(n):
    licznik *= ciag1
    mianownik *= ciag2
    sumafib = fib1 + fib2
    fib1 = fib2
    fib2 = sumafib
    ciag1 = sumafib
    ciag2 *= 2

print(f"Iloczyn n elementow ciągu ekstremalnego wynosi: {licznik / mianownik}")
