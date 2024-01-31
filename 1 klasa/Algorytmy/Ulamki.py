# Program dodajacy 2 ulamki

a = int(input("Podaj licznik:"))
b = int(input("Podaj mianownik:"))

c = int(input("Podaj licznik:"))
d = int(input("Podaj mianownik: "))

#nww / b = licznik gotowy

ilocz = b*d
x = b
y = d

while x!=y:
  if y>x: 
    y-=x
  else:
    x-=y

wsp_mian = ilocz//x

#nww / b = licznik gotowy
#To bylo nie wiadome
e = (wsp_mian//b) * a
f = (wsp_mian//d) * c

licznik = e+f

print(f"{licznik} \ {wsp_mian}")