# Zadanie 1 
print("Zadanie 1")
a = input()
for i in range(len(a) - 1):
    indexi = i
    for j in range(len(a) - 1 ,i, -1):
        if a[i] == a[j]:
            indexj = j
            print(a[indexi + 1:indexj])
            break

print("\n")

# Zadanie 2 
print("Zadanie 2")
z = input()
polowa = len(z) // 2

wlasciwyNapis1 = list(reversed(z[0:polowa]))

wlasciwyNapis2 = list(reversed(z[polowa:len(z)] ))

napis1 = "".join(wlasciwyNapis1)
napis2 = "".join(wlasciwyNapis2)
print(napis2 + "" + napis1)

print("\n")

# Zadanie 3 
print("Zadanie 3")
x = input()

flaga = True
for i in range(len(x)-1):
    if ord(x[i]) <= ord(x[i + 1]):
        pass
    else:
        flaga = False
        break

if flaga:
    print("Tak")
else:
    print("Nie")
