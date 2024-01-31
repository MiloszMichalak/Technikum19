# Zadanie 1
print("Zadanie 1")
x = input()
for i in range(len(x) + 1):
    print(x[0:i])

# Zadanie 2
print("\nZadanie 2")
y = input()
ile = 0
for i in range(len(y) - 1):
    if y[i] == y[i + 1]:
        ile += 1

print(f"Taki przypadek wystepuje {ile} razy")
