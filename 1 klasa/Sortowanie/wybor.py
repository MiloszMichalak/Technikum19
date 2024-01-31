# * Dobra teraz algorytm sortujacy - przez wybor
from random import randint
n = 10
wejscie = [randint(1,100) for i in range(n)]
print(f"Przed: {wejscie}")

for i in range(n):
    mini = i
    for j in range(i, n):
        if wejscie[j] < wejscie[mini]:
            mini = j
    wejscie[i], wejscie[mini] = wejscie[mini], wejscie[i]

print(F"Po: {wejscie}")
