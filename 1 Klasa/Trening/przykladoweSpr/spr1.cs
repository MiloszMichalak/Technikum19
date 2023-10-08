
using System;
using System.Collections;

// Stworz losową tablice / listę 25 dwucyfrowych liczb. Wypisz suma i ilość tych z nich, w których suma cyfr jest liczbą pierwszą
Random random = new Random();
ArrayList lista = new ArrayList();
for (var i = 0; i < 25; i++)
{
    lista.Add(random.Next(10, 99));
}

int suma = 0;
int ilosc = 0;

foreach (int item in lista)
{
    int dziesiatki = item / 10;
    int jednosci = item % 10;

    bool flaga = true;
    for (int i = 1; i < dziesiatki + jednosci; i++)
    {
        if ((dziesiatki + jednosci) % i == 0)
        {
            flaga = false;
            break;
        }
    }
    
    if (flaga){
        suma += item;
        ilosc++;
    }
}

System.Console.WriteLine($"Suma: {suma}, ilosc: {ilosc}");

// Dodaj do tablicy / listy 15 losowych trzycyrtowych wielokrotoności liczby 13
ArrayList list = new ArrayList();
while (list.Count < 15)
{
    int losowa = random.Next(100, 999);
    if (losowa % 13 == 0)
    {
        list.Add(losowa);
    }
}

foreach (var item in list)
{
    System.Console.WriteLine(item);
}

// Stworz macierz N x N zawierająca losowe cyfry. N ma być liczbą nieparzystą. Oblicz sumę i ilość tych elementów tej macierzy, które należą do jej jakiejkolwiek osi symterii.
// Os symetri to dwie diagonale, pionowa krecha, pozioma krecha
Console.WriteLine("Zadanie 3");
Random r = new Random();
int n = 5;
int[,] M = new int[n,n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        M[i,j] = r.Next(10,100);
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(M[i,j] + " ");
    }
    System.Console.WriteLine();
}
suma = 0;
int BigSuma = 0;
ilosc = 0;
for (int i = 0; i < n; i++)
{
    suma += M[i, 0];
    ilosc++;

    suma += M[0, i];
    ilosc++;

    suma += M[i, n - 1];
    ilosc++;

    suma += M[n - 1, i];
    ilosc++;

}
System.Console.WriteLine($"Suma to: {suma} Ilosc to: {ilosc}");



