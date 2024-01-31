#zad 1
a = int(input())
if a % 3 == 0:
  print("tak")
else:
  print('nie')
#zad 2
a = int(input())
if a % 17 == 0 and a >= 100 and a < 1000:
  print('tak')
else:
  print('nie')
#zad 3
wiek = int(input())
if wiek >= 18:
  print('tak')
else:
  print('nie')
#zad 4
limit = 20
waga = int(input())
if waga <= limit:
  print('tak')
else:
  print('nie')
#zad 5
a, b, c=map(int, input().split())
a = int(input())
b = int(input())
c = int(input())
if a < c < b or a > c > b:
  print("TAK")
else:
  print("NIE")
#zad 6
a = int(input("Podaj dowolna liczbe: "))
p = int(input("Podaj liczbe pierwsza: "))
if (a**p - a) % p == 0:
  print("tak")
else:
  print("nie")
#zad 7
p, k, s=map(int, input().split())
if (k-p) <= 3*s:
  print('tak')
else:
  print('nie')