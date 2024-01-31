
def szukanieReszty(x):
    T = [500, 200, 100, 50, 20, 10, 5, 2, 1]
    
    while x > 0:
        for nominal in T: # T[::-1] jedzie przez tablice od tylu w  
            ile = x // nominal
            x -= nominal * ile
            if ile > 0:
                print(f"Nominal {nominal} miesci sie {ile} razy")



def szukanieResztyZTablica(x):
    T = [500, 200, 100, 50, 20, 10, 5, 2, 1]
    ilosc = []

    while x > 0:
        for nominal in T:
            ile = x // nominal
            x -= nominal * ile
            if ile > 0:
                for j in range(ile): # To jest po to zeby dodalo nominal iles razy a nie raz
                    ilosc.append(nominal)

    for element in ilosc:
        print(element, end=" ")


def main():
    x = int(input())
    szukanieReszty(x)
    print()
    szukanieResztyZTablica(x)
    print()


if __name__ == '__main__':
    main()