def f(x):
    return 2 * x + 1

def f2(x):
    return 3 + 2*x - x**2 # 3 + 2x - x^2

# tutaj sie dzieli na 2 czyli bierze od srodka prostokata
def prostokaty1(a, b, n):
    dx = (b - a) / n
    s = 0
    for i in range(n):
        s += f2(a + dx / 2 + i * dx) * dx
    return s

# tutaj nie dodaje nic czyli bierze od poczatku prostokata
def prostokaty2(a, b, n):
    dx = (b - a) / n
    suma = 0
    for i in range(n):
        suma += f(a + i * dx) * dx
    return suma

# tutaj dodaje cale dx czyli bierze od konca prostokata
def prostokaty3(a, b, n):
    dx = (b - a) / n
    s = 0
    for i in range(n):
        s += f(a + dx + i * dx) * dx
    return s
