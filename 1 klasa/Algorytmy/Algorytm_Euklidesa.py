                                                                                                                                                                                                                                                                                                               #Odejmowanie

a = int(input())
b = int(input())

while a != b:
  if a>b:
    a-=b
  else:
    b-=a
print(f"NWD tych liczb to {a} i {b}")


#Modulo
while b != 0:
  temp = b
  b = a % b
  a = temp
  
print(f"NWD tych liczb to {a}")
