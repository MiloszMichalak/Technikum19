# Pre

# LISTY -> przypisanie, for, foreach

# Zwraca tablica 5 elementow od 4 (0, 1, 2, 3, 4)
# print(list(range(5)))

# print()

# # Przypisanie listy
# L = [3, 5, 8, 13]
# for x in L:
#     print(x)

# print()

# # Zastepca foreacha - Wyjscie takie samo jak u gory
# for i in range(len(L)):
#     print(L[i])

# print()

# # Zwraca długość listy
# print(len(L))

# Funkcje w listach
K = [4, 7, 5, 7, 3, 3, 2, 8, 7]

print(K.append(3)) # Dodalo na koncu 3
print(K.count(7)) # Policzylo ile jest 7 w liscie
print(K.index(7)) # Zwrocilo index PIERWSZEJ siodemki
K.insert(5, 4) # na pozycje 4 dodalo 5 (pierw INDEX pozniej CO) 
K.pop(3) # Usuwa element z pozycji 3 czyli drugie 7
K.pop() # Pusty pop usuwa ostatnia liczbe
K.remove(5) # Usuwa pierwsza piatke ktora znajdzie

# K.reverse() # Odwraca liste
# print(K)

# K.sort() # Sortuje liste rosnacoprint(K)

# K.sort(reverse=True) # Sortuje liste malejaco
# print(K)

# Cwiczenia
T = [4, 7, 5, 7, 3, 3, 2, 8, 7]
# Usunac wszystkie 7
for i in range(T.count(7)):
    T.remove(7)
print(T)

print()

for i in range(T.count(7)):
    T.pop(T.index(7))
print(T)

print()

# Szukanie Maxa
print(max(T)) # Po prostu szuka maxa

print()

# ten program szuka maxa ale bardziej manualna metoda
maks = T[i]
for x in T:
    if x>maks:
        maks = x
print(f"Max tej listy to {maks}")

# To ponizej zadziala tak samo
for i in range(2 ,10 ,3):
    print(T[i])

print()
# od 2 do 10 co 3
print(T[2:10:3])

# pierwsze 3 elementy
print(T[:3])

# 7 element i 2 ostatnie
print(T[7:])

# od 5 elementu co 2
print(T[5::2])

# od 5 do 3 elementu malejaco
T[5:3:-1]