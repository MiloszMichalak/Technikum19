#Szyfr cezara przesuwa w prawo o 3 litery dana liter

#a b c d e f g h i j  k l m n o p q r s t w x y z
#Funckja ord() - zwraca kod ASCII dla danego znaku
print(ord("A"))
print(ord("B"))
print(ord("Z"))

#Funkcja chr() - zwraca znak dla danego kodu ascii
print(chr(65))
print(chr(75))
print(chr(89))

#Laczenie
print(chr(ord("C"))) #Da C
print(chr(ord("C")+1)) #Da D

print()
#Napisz alfabet za pomoca petli for

for i in range(65, 91):
  print(chr(i), end=" ")

print()
# Jak wydobyc literki z napisu
#napis = napis.replace(" ", "") = Replace zamienia cos na cos

napis = "POLSKA"
print(len(napis))
print(napis[0])
print(napis[4])

print()
#Napisz petle wyciagajaca z napisu literki
napis = input()
for i in range(len(napis)):
  print(napis[i])

print()
#Napisz petle wyciagaja kody ascii napisu
for i in range(len(napis)):
  print(ord(napis[i]))

#Zaszyfruj napis cezarem w kluczu = 3
napis = input()
szyfr = ""
for i in range(len(napis)):
  szyfr += chr( 65 + (ord(napis[i])- 65 + 3) % 26)
print(f"Napis: {napis} Szyfr: {szyfr}")