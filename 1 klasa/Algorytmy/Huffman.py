# Huffma sprawdza ile jest liter pod rzad i wypisuje dwieA czteryB czyli 2A4B

W = "AACCCDDDDDEFGGGHHIJJ"
E = "AB3C5DEF3G2HI2J"
Huffman = ""
ilosc = 1
for i in range(len(W) - 1):
    if W[i] == W[i + 1]:
        ilosc += 1
    else:
        if ilosc > 1:
            Huffman += str(ilosc)
        Huffman += W[i]
        ilosc = 1

# dodatkowe jedno wywolanie zeby sprawdzic ostatnio liczbe
if ilosc > 1:
    Huffman += str(ilosc)
Huffman += W[len(W) - 1]

print(W)
print(Huffman)
