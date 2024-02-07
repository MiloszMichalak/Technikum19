D = {}

# zamienia 2 pierwsze input oddzielone spacja na inta
n, m = map(int, input().split())
# n to wierzcholki, m to krawedzie

for i in range(n):
    D[i + 1] = []
    # D.update({ i + 1 : [] })

# jak jest podloga to po prostu nie ma zmiennej
# tutaj przy kazdym powtorzeniu podaje ktory wierzcholek z ktirym bedzie sie laczyc, czyli dodajemy krawedzie
for _ in range(m):
    p, q = map(int, input().split())
    D[p].append(q)
    D[q].append(p)

D = {1: [2, 3], 2: [1, 3, 4], 3: [1, 2, 4], 4: [2, 3, 5, 6], 5: [4], 6: [4]}

# sprawdzamy len od y bo y to sa listy
for x, y in D.items():
    if len(y) == 0:
        print("Wiewor sam!")
    else:
        print(f"Dla wierzcholka {x} przypadaja krawedzie {sorted(y)}")

# policz sumę stopni wierzechołków grafu
suma = 0
for x, y in D.items():
    suma += len(y)
print(suma)

# znajdź WIERZCHOLEK o najwyższym STOPNIU (czyli ilosc krawedzi)
maks = 0
kMaks = 0
for x, y in D.items():
    if len(y) > maks:
        maks = len(y)
        kMaks = x
print(kMaks)

# znajdź wierzchołki samodzielne - te ktore maja 0 krawedzi
for x, y in D.items():
    if len(y) == 0:
        print(f"Wierzcholek {x} jest samodzielny")


# Sprawdź czy uda się dojść z wierzchołka x do y
# Uzywamy algorytm DFS - sprawdza wszystkie polaczenia w grafie od danego wierzcholka
def DFS(neighbours: [], graph: {}, visited: ()):
    if neighbours not in visited:
        visited.add(neighbours)
    else:
        return
    for neighbour in graph[neighbours]:
        DFS(neighbour, graph, visited)
    return visited


# wersja zapisana w krotszy sposob
def DFS2(neighbours: [], graph: {}, visited: ()):
    visited.add(neighbours)
    for neighbour in graph[neighbours]:
        if neighbour not in visited:
            DFS(neighbour, graph, visited)
    return visited


W = DFS(1, D, set())
W2 = DFS(1, D, set())
print(W, W2)
