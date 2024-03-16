using System;
using System.Collections;
// 1.Napisz program, który pomnoży dwie macierze losowych liczb. 
// Niech user podający wymiary macierzy zadba o odpowiednie wymiary,
// tak aby mnożenie było możliwe. Macierze wypełnij losowymi liczbami.
System.Console.WriteLine("Zadanie 1");
System.Console.WriteLine("Podaj wymiary macierzy: (x, y)");

System.Console.Write("Macierz1: ");
string macierz1 = Console.ReadLine();

System.Console.Write("Macierz2: ");
string macierz2 = Console.ReadLine();

string[] wymiaryMacierzy1 = macierz1.Split(",");
int wymiar1 = Convert.ToInt32(wymiaryMacierzy1[0]);
int wymiar2 = Convert.ToInt32(wymiaryMacierzy1[1]);

string[] wymiaryMacierzy2 = macierz2.Split(",");
int wymiar3 = Convert.ToInt32(wymiaryMacierzy2[0]);
int wymiar4 = Convert.ToInt32(wymiaryMacierzy2[1]);

Random random = new Random();
int[,] M1 = new int[wymiar1, wymiar2];
int[,] M2 = new int[wymiar3, wymiar4];

for (int i = 0; i < wymiar1; i++)
{
    for (int j = 0; j < wymiar2; j++)
    {
        M1[i, j] = random.Next(10, 100);
    }
}

for (int i = 0; i < wymiar3; i++)
{
    for (int j = 0; j < wymiar4; j++)
    {
        M2[i, j] = random.Next(10, 100);
    }
}

int suma = 0;
for (int i = 0; i < wymiar1; i++)
{
    for (int j = 0; j < wymiar2; j++)
    {
        suma += M1[i, j] * M2[i, j];
    }
}

System.Console.WriteLine("Suma iloczyn tych macierzy jest rowna: {0}", suma);

System.Console.WriteLine();

// 2. Napisz algorytm, który sprawdzi czy gdzieś w macierzy 10x10 losowych liczb dwucyfrowych
// doszło do sytuacji, że obok siebie są dwie liczby pierwsze.
System.Console.WriteLine("Zadanie 1");
bool czyPierwsza(int a)
{
    for (int i = 2; i < Math.Sqrt(a) + 1; i++)
    {
        if (a % i == 0)
        {
            return false;
        }
    }
    return true;
}

int[,] Maciorka = new int[10, 10];
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Maciorka[i, j] = random.Next(3, 6);
    }
}

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        System.Console.Write(Maciorka[i, j] + "  ");
    }
    System.Console.WriteLine();
}

bool flaga = false;
for (int i = 0; i < 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        if (czyPierwsza(Maciorka[i, j - 1]) && czyPierwsza(Maciorka[i, j]))
        {
            flaga = true;
        }
    }
}
if (flaga)
{
    System.Console.WriteLine("W tej macierzy wystepuje taka sytuacja");
}
else
{
    System.Console.WriteLine("W tej macierzy nie wystepuje taka sytuacja");
}

System.Console.WriteLine();

// 3. Napisz program, który sprawdzi, czy dwa słowa wpisane przez usera są anagramami
System.Console.WriteLine("Zadanie 3");
string slowo1 = Console.ReadLine();
string slowo2 = Console.ReadLine();

char[] tablicaZnakow1 = slowo1.ToCharArray();
Array.Sort(tablicaZnakow1);

char[] tablicaZnakow2 = slowo2.ToCharArray();
Array.Sort(tablicaZnakow2);

int maks = 0;
for (int i = 0; i < tablicaZnakow2.Length; i++)
{
    if (tablicaZnakow1[i].Equals(tablicaZnakow2[i]))
    {
        flaga = true;
    }
    else
    {
        flaga = false;
    }
}

if (flaga)
{
    System.Console.WriteLine("Podane słowa są anagramami");
}
else
{
    System.Console.WriteLine("Podane słowa nie są anagramami");
}

System.Console.WriteLine();

// 4. Napisz program, który znajdzie w podanej n-elementowej tablicy najdłuższy spójny podciąg niemalejący
// oraz obliczy jego długość i sumę jego elementów
// cos nie do konca dziala wiec jest do doszlifowania
System.Console.WriteLine("Zadanie 4");
System.Console.Write("Podaj dlugosc tablicy: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] T = new int[n];
for (int i = 0; i < n; i++)
{
    T[i] = random.Next(10, 100);
}

suma = 0;
int ile = 0;
ArrayList dlugoscCiagu = new ArrayList();
ArrayList sumaCiagu = new ArrayList();

for (int i = 0; i < n - 1; i++)
{
    if (T[i] <= T[i + 1])
    {
        suma += T[i];
        ile++;
    }
    else
    {
        if (ile > 1)
        {
            suma += T[i];
            dlugoscCiagu.Add(ile);
            sumaCiagu.Add(suma);
            suma = 0;
            ile = 0;
        }
    }

}                           

foreach (int item in T)
{
    System.Console.Write(item + " ");
}

maks = 0;
foreach (int item in dlugoscCiagu)
{
    if (item > maks)
    {
        maks = item;
    }
}

int index = dlugoscCiagu.IndexOf(maks);
System.Console.WriteLine("Najdluzszy ciag liczy {0} dlugosci i suma liczb w tym ciagu wynosi: {1}", dlugoscCiagu[index], sumaCiagu[index]);

System.Console.WriteLine();

// 5. Wygeneruj macierz n x n z losowymi cyframi. Znajdź sumę tych elementów tej macierzy,
// które należą do którejkolwiek osi symetrii.
System.Console.WriteLine("Zadanie 5");
n = Convert.ToInt32(Console.ReadLine());
int[,] maciora = new int[n,n];

for (int i = 0; i < n; i++){
    for (int j = 0; j < n; j++){
        maciork[i, j] = random.Next(10, 100);
    }
}
