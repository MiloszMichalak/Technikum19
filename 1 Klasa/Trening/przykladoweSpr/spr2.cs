using System;
using System.Collections;

// 1. Stwórz losową tablicę / listę 30 trzycyfrowych liczb. Wypisz sumę i ilość tych z nich w których występuje gdziekolwiek przynajmniej dwie takie same cyfry
Random rand = new Random();
ArrayList lista = new ArrayList();
for (var i = 0; i < 50; i++)
{
    lista.Add(rand.Next(100, 999));
}

int suma = 0;
int ilosc = 0;

foreach (int item in lista){
    int jednosci = item % 10;
    int dziesiatki = item / 10;
    int setki = item / 100;
    if (jednosci == dziesiatki || jednosci == setki || dziesiatki == setki){
        suma += item;
        ilosc++;
    }
}

System.Console.WriteLine($"Suma: {suma}, ilosc: {ilosc}");

// 2. Dodaj to tablicy / listy 20 losowych dwucyfrowych liczb złożonych
ArrayList list = new ArrayList();
while (list.Count < 20){
    int losowa = rand.Next(10, 99);
    bool flaga = true;
    for (var i = 2; i < losowa; i++)
    {
        if (losowa % i == 0){
            flaga = false;
        }
    }

    if (!flaga){
        list.Add(losowa);
    }
}

foreach (var item in list)
{
    System.Console.WriteLine(item);
}

// 3. Stwórz macierz N x N zawierająca losowe cyfry. Oblicz sumę i ilość elementów tzw "ramki bez rogów" w tej macierzy. Innymi słowy są to skrajne wiersze i kolumny bez 4 narozników
int n = 5; 

int[,] M = new int[n, n];
Random random = new Random();

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        M[i, j] = rand.Next(10, 100);
    }
}

suma = 0;
ilosc = 0;

for (int i = 1; i < n - 1; i++)
{
    suma += M[0, i];
    suma += M[n - 1, i]; 
    suma += M[i, 0];
    suma += M[i, n - 1];

    ilosc += 4;
}

Console.WriteLine("Macierz N x N:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(M[i, j] + " ");
    }
    Console.WriteLine();
}

System.Console.WriteLine($"Suma: {suma}, ilosc: {ilosc}");
