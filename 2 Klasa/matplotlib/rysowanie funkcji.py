import matplotlib.pyplot as plt
import numpy as np

x = np.linspace(0 ,16)

def f(x):
    return np.sqrt(x) + 2

def calka(a,b,n):
    h = (b - a) / n
    suma = 0
    for i in range(n):
        suma += f(a + i * h / 2)
    return suma * h


plt.plot(x, f(x), color="blue")

plt.show()