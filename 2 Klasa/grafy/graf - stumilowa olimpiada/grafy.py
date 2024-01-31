D = {}

# zamienia 2 pierwsze input oddzielone spacja na inta
n, m = map(int, input().split())
# n to wierzcholki, m to krawedzie

for i in range(n):
    D[i + 1] = []

# jak jest podloga to po prostu nie ma zmiennej
# tutaj przy kazdym powtorzeniu podaje ktory wierzcholek z ktirym bedzie sie laczyc, czyli dodajemy krawedzie
for _ in range(m):
    p, q = map(int, input().split())
    D[p].append(q)

# sprawdzamy len od y bo y to sa listy
for x, y in D.items():
    if len(y) == 0:
        print("Wiewor sam!")
    else:
        print(f"Da wierzcholka {x} przypadaja krawedzie {sorted(y)}")