# Zadanie 1
print("Zadanie 1")
wejscie = input()
print(wejscie[0], wejscie[-1])

print()

print("Zadanie 2")
print(wejscie[1:-1])

print()

print("Zadanie 3")
print(wejscie[-1:-5:-1])

print()

print("Zadanie 4")
suma = 0
for i in wejscie:
    suma += ord(i)
print(suma)

print()

print("Zadanie 5")
ile = 0
for i in wejscie:
    if (i.lower() == "a"):
        ile += 1
print(ile)

print()

print("Zadanie 6")
pozycje = [0] * 150
for i in range(len(wejscie)):
    pozycje[ord(wejscie[i])] += 1
maksik = max(pozycje)
gdzie = pozycje.index(maksik)
if maksik > 1:
    print(f"Jest to: {chr(gdzie)} i wystapilo {maksik} razy")
else:
    print("Nie ma liter ktora wystepuje najczesciej")

print()

print("Zadanie 7") #Wyskakuje blad ze out odf range i nie wiem o co biego tutaj

def czyJestMniejszyNiezerowy(L):
    for x in L:
        if 0 < L.count(x) < max(L):
            return True
    return False

K = [0] * 150
for x in wejscie:
    K[ord(x)] = K[ord(x)] + 1

if sum(K) == max(K):
    print("Dominanta:", chr(K.index(max(K))))
elif not czyJestMniejszyNiezerowy(K):
    print("Brak dominanty")
else:
    D = []
    for x in range(len(K)):
        if K[x] == max(K):
            D.append(chr(x))   
    print("Dominanty:", ", ".join(D))


print()

print("Zadanie 8")
ile = 0
for i in range(len(wejscie)):
    if wejscie[i] == "L" and wejscie[i + 1] == "A":
        ile += 1

if ile == 3:
    print("Tak")
else:
    print("Nie")
        
print()

print("Zadanie 9")
suma = 0
for i in wejscie:
    suma += ord(i)
srednia = suma // len(wejscie)
print(f"Srednia literka to: {chr(srednia)}")

print()

print("Zadanie 10")
askii = []
for i in range(65, 91):
    askii.append(i)

for i in askii:
    if chr(i) not in wejscie:
        print(chr(i), end=" ")

print("\n")

print("Zadanie 11")
def palik(napis):
    lista = list(napis)
    lista.reverse()
    wlasciwyNapis = "".join(lista)
    if (wlasciwyNapis == napis):
        return True
    else: 
        return False
    
ile = 0
for i in range(len(wejscie)):
    napis = wejscie[i:i+3]
    if palik(napis):
        ile += 1
print(ile)
