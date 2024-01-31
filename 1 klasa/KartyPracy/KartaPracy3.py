#Zad 1
print("Zadanie 1")
n = int(input())
for i in range(n):
    print(i**3+3, end=" ")
print(" ")

#Zad 2
print("Zadanie 2")
for i in range(105,1000):
    if i%15 == 0:
        print(i, end=" ")
print(" ")

#Zad 3
print("Zadanie 3")
n = int(input())
for i in range(1, n+1):
    if n%i == 0:
        print(i, end=" ")
print(" ")

#Zad 4
print("Zadanie 4")
suma = 0
for i in range(10,100):
    suma = suma + i
print(suma)
print(" ")

print("Zadanie 5") #IDK JAK TO ZROBIC XDDDDDDDD
n = int(input())
suma = n*(n+1)//2
for i in range(n-1):
     x = int(input())
     suma = suma - x
print("Nie poda³eœ:",suma)
print(" ")

#Zad 6
print("Zadanie 6")
n = int(input())
a = 0
b = 1
print(a, end=" ")
print(b, end=" ")
for i in range(n-2):
    a, b = b, a+b
    print(b, end=" ")