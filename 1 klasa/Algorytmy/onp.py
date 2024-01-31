z# ONP - odwrotna notacja polska
# 3 + 7 = 10 infix
# 3 7 + = 10 postfix
# + 3 7 = 10 prefix
# in (3 + 7) * 5 = 50
# onp 3 7 + 5 * = 50
# FIFO - first in, first out - dziala jak kolejka
# LIFO - last in, first out - ostatni ktory wszedl to pierwszy wyjdzie
# 5 7 2 1 + 2 - 3 * + +
# liczba - na stos
# znak - wynik dwoch osatnich znakow i na stos
# * Czelendż ONP
# 1) Algorytm obliczajacy wyrazenie onp
wejscie = input("Podaj wyrazenie: ")
stos = []

for i in wejscie:
    if i.isdigit():
        stos.append(i)
    else:
        
        if i == "+":
            wynik = int(stos[len(stos) - 2]) + int(stos[len(stos) - 1])
            stos.pop()
            stos.pop()
            stos.append(wynik)
        elif i == "-":
            wynik = int(stos[len(stos) - 2]) - int(stos[len(stos) - 1])
            stos.pop()
            stos.pop()
            stos.append(wynik)
        elif i == "*":
            wynik = int(stos[len(stos) - 2]) * int(stos[len(stos) - 1])
            stos.pop()
            stos.pop()
            stos.append(wynik)
        elif i == "/":
            wynik = int(stos[len(stos) - 2]) // int(stos[len(stos) - 1])
            stos.pop()
            stos.pop()
            stos.append(wynik)
print(f"Twoj wynik w onp to {str(stos)}")
