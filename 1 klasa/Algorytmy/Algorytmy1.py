H#algorytm sprawdzajacy czy liczba jest pierwsza
# wersja 1
n = int(input())
for i in range(2,n):
  if n%i==0:
    print("Liczba nie jest pierwsza")
    exit(0)
print("Liczba jest pierwsza")

#wersja 2
flaga = True
for i in range(2,n):
  if i%n==0:
    flaga=False
if flaga == True:
  print("Licbza jest pierwsza")
else:
  print("Liczba nie jest pierwsza")

#Wersja 3-the best
from math import sqrt
n = int(input())
for i in range(2, int(sqrt(n))+1):
  if n%i==0:
    print("Liczba nie jest pierwsza")
  else:
    print("Liczba jest pierwsza")
  
#2. generator liczb pierwszych- liczby pierwsze w przewdziale[p, q]
p = int(input())
q = int(input())
for i in range(p, q+1):
  flaga = True
  for j in range(2,int(i**0,5)+1):
    if i%j == 0:
      flaga = False
    if flaga:
      print(i, end=" ")

#3. generator liczb pierwszych - poczatkowe k liczb pierwszych
k = int(input())
while True:
  k-=1
  if k == 0:
    break

#3-2 sposob
n = int(input())
x=2
while 1:
  flaga = True
  for i in range(2, int(x**0.5)+1):
    if x%i == 0:
      flaga=False
    if flaga:
      print(x, end=" ")
