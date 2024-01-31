# Szyfr RSA .Algorytm asymetryczny
# sha md5
from hashlib import sha256
# 256 bitowe
print(sha256(b"grucha").hexdigest())

from hashlib import md5

# to jest 128 bitowe i tego bedziemy uzywac
print(md5(b"grucha").hexdigest())
print(md5(b"N1eLub1ePythona").hexdigest())

# Wypisywanie tego pod zmienna
input1 = input()
print(md5(input1.encode("utf-8")).hexdigest())