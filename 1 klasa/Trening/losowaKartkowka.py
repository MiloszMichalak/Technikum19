# GRUPA 1
print("GRUPA 1")
print()

# 1. Wypisac wszystkie litery miedzy powtorkami
print("Zadanie 1")
n = input()
for i in range(len(n)):
    for j in range(i + 1, len(n)):
        if n[i] == n[j]:
            print(n[i + 1:j])
            
print()

# 2. Wypisac slowo odwrotnie
print("Zadanie 2")
n = input()
# Dziwny sposob na reverse bo musi byc tablica i join
print("".join(list(reversed(n))))

# Najprosciejszy sposob
print(n[::-1])

print()

# 3. Sprawdz czy liczba jest nie malejaca alfabetycznie czyli kazda nastepna liczba jest nie mniejsza niz poprzednia
print("Zadanie 3")
n = input()
flaga = True
for i in range(len(n) - 1):
    if ord(n[i]) <= ord(n[i + 1]):
        pass
    else:
        flaga = False
        break
        
if flaga:
    print("Tak")
else:
    print("Nie")            

print()
# GRUPA 2
print("GRUPA 2")
# 1. Sprawdz czy slowo 1 jest w slowie 2
print("Zadanie 1")
a = input()
b = input()
if a in b:
    print("Tak")
else:
    print("Nie")    

print()

# 2. Sprawdz czy z podzbioru liter wspisanego przez usera slowa da sie utworzyć słowo "baza"
print("Zadanie 2")
n = list(input())
slowo = ["b", "a", "z", "a"]
flaga = True
for item in slowo:
    if item in n:
        n.remove(item)
    else:
        flaga = False
        break

if flaga:
    print("Tak")
else:
    print("Nie")            

print()

# 3. TODO (i tak nie zrobie) Tworz nowe slowa z podstawowych slow po usunieciu duplikatow
