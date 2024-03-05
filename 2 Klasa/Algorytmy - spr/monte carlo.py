import random

random.seed()
n = int(input('n = '))
k = 0
for i in range(n):
    x = random.random()
    y = random.random()
    if (x**2 + y**2) <= 1:
        k += 1

p = 4 * k / n
print("pi =", p)
