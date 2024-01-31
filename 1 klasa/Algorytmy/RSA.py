# Klucz publiczny - Szyforwanie wiadomosci - klucz dostepny dla kazdegp (jawny) - nie trzeba go ukrywac
# Klucz prywatny - 

########## R  S  A - Szyfrowanie asymetryczne##########

#1. Wybor 2 dużych liczb pierwszych - przynajmniej 32 bity (najlepiej)
p = 409 
q = 283
print(p, q)

#2. Stworzenie funkcji Eulera F = (p-1) * (q-1) i znalezienie n = rownego p*q
F = (p-1) * (q-1)
n = p * q
print(n)
print(F)

#3. znalezienie klucza publicznego e: NWD(F, e) = 1
from math import gcd # Zimprtowana biblioteka do NWD
e = 0
for i in range(3, F, 2):
    if gcd(i, F) == 1:
        e = i
        break

print(e, n) # Klucz publiczny

#4. Wygenerowanie klucza prywatnego d: d*e % F = 1 (odwrotnosc modulo)
d = 0
for i in range(2, n):
    if (i * e) % F == 1:
        d = i
        break

print(d, n) # Klucz prywatny

# Przyklad dzialania:
# c = (x ** e) % n (szyfrogram)
# t = (c ** d) % n (na tekst jawny)
msg = input()
szyfrogram = ""

for i in msg:
    szyfrogram += chr((ord(i) ** e) % n)
print(szyfrogram)

jawny = ""
for j in szyfrogram:
    jawny += chr((ord(j) ** d) % n)
print(jawny)
