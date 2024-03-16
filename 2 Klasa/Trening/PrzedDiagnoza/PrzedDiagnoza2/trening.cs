using System;
using System.Collections.Generic;

int nwd(int a, int b){
    while (a != b){
        if (a > b){
            a -= b;
        } else {
            b -= a;
        }
    }
    return a;
}

int nww(int a, int b){
    return (a * b) / nwd(a ,b);
}
//1.User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.


//2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.
System.Console.WriteLine("Zadanie 2");
string ulamek1 = Console.ReadLine();
string ulamek2 = Console.ReadLine();

string[] ul1 = ulamek1.Split("/");
string[] ul2 = ulamek2.Split("/");

int gora1 = Convert.ToInt32(ul1[0]);
int dol1 = Convert.ToInt32(ul1[1]);
int gora2 = Convert.ToInt32(ul2[0]);
int dol2 = Convert.ToInt32(ul2[1]);

int wspolnyMianownik = nww(dol1, dol2);
int gotowaGora1 = (wspolnyMianownik * gora1) / dol1;
int gotowaGora2 = (wspolnyMianownik * gora2) / dol2;

int dodanaGora = gotowaGora1 + gotowaGora2;

if (dodanaGora / wspolnyMianownik >= 1)
{
    System.Console.WriteLine("Tak");
}
else
{
    System.Console.WriteLine("Nie");
}

System.Console.WriteLine();

//3. Sprawdź czy wieksza jest suma dwóch wpisanych przez usera ułamków czy suma ich odwrotności.
System.Console.WriteLine("Zadanie 3");
// Wczytywanie zmiennych
ulamek1 = Console.ReadLine();
ulamek2 = Console.ReadLine();

string[] u1 = ulamek1.Split("/");
string[] u2 = ulamek2.Split("/");

gora1 = Convert.ToInt32(u1[0]);
dol1 = Convert.ToInt32(u1[1]);
gora2 = Convert.ToInt32(u2[0]);
dol2 = Convert.ToInt32(u2[1]);

// Obliczanie ulanmka
int wspolnyMianownik1 = nww(dol1, dol2);

int pomnozonaGora1 = (wspolnyMianownik1 * gora1) / dol1;
int pomnozonaGora2 = (wspolnyMianownik1 * gora2) / dol2;
gotowaGora1 = pomnozonaGora1 + pomnozonaGora2;

// Odwracanie ulamka
int temp1 = gora1;
int temp2 = dol1;
gora1 = gora2;
dol1 = dol2;
gora2 = temp1;
dol2 = temp2;

// Obliczanie odwroconego ulamka
int wspolnyMianownik2 = nww(dol1, dol2);
pomnozonaGora1 = (wspolnyMianownik2 * gora1) / dol1;
pomnozonaGora2 = (wspolnyMianownik2 * gora2) / dol2;
gotowaGora2 = pomnozonaGora1 + pomnozonaGora2;

// Porownywanie do siebie policzonych ulamkow
if ((double)gotowaGora1 / wspolnyMianownik1 > (double)gotowaGora2 / wspolnyMianownik2)
{
    System.Console.WriteLine("Wiekszy jest bazowy ulamek");
}
else
{
    System.Console.WriteLine("Wiekszy jest odwrocony ulamek");
}

System.Console.WriteLine();

//4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.
System.Console.WriteLine("Zadanie 4");
char[] samogloski = { 'a', 'e', 'i', 'o', 'u', 'y' };
string napis = Console.ReadLine();
int ile = 0;
foreach (char znak in napis)
{
    for (int i = 0; i < samogloski.Length; i++)
    {
        if (znak == samogloski[i])
        {
            ile++;
        }
    }
}
if (ile > napis.Length / 2){
    System.Console.WriteLine("Wiecej jest samoglosek");
} else if (ile < napis.Length / 2) {
    System.Console.WriteLine("Wiecej jest spolglosek");
} else {
    System.Console.WriteLine("Spolglosek i samoglosek jest po rowno");
}

System.Console.WriteLine();

//5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.
System.Console.WriteLine("Zadanie 5");
napis = Console.ReadLine();
int[] M = new int[200];
foreach (char znak in napis)
{
    int pozycja = (int)znak;
    M[pozycja]++;
}

int maks = 0;
for (int i = 0; i < M.Length; i++)
{
    if (M[i] > maks)
    {
        maks = M[i];
    }
}
int litera = Array.IndexOf(M, maks);

System.Console.WriteLine("Najwiecej literki w tym wyrazie jest: {0}", (char)litera);

System.Console.WriteLine();

//7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
//Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
//i lecąc z jednakową prędkością przybywają w tym samym czasie. 
//Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?

//8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
//a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb,
//które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
//Napisz program, który pomaga w takich obliczeniach.
System.Console.WriteLine("Zadanie 8");
int sumaCyfr(int a)
{
    int suma = 0;
    while (a != 0)
    {
        suma += a % 10;
        a /= 10;
    }
    return suma;
}
System.Console.WriteLine("Podaj przedział: (a, b) ");
string przedzial = Console.ReadLine();
string[] prze = przedzial.Split(",");

int liczba1 = Convert.ToInt32(prze[0]);
int liczba2 = Convert.ToInt32(prze[1]);

int ilePrzez = 0;
int ileSumaPrzez = 0;

for (int i = liczba1; i <= liczba2; i++)
{
    if (i % 7 == 0){
        ilePrzez++;
    }
    if (sumaCyfr(i) % 7 == 0){
        ileSumaPrzez++;
    }
}

System.Console.WriteLine("W tym przedziale sa {0} liczby ktore sa podzielne przez siedem i w tym przedziale sa {1} liczby których suma jest podzielna przez siedem", ilePrzez, ileSumaPrzez);

System.Console.WriteLine();

//9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody,
//zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład,
//jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami – 
//będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4.Masz dane wszystkie liczby, które Halinka wypowiedziała 
//podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.

//10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował
//przechadzających się ludzi.
//W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
//obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
//znaleźć sobie miejsce na ławce.
//Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
//Jaka jest minimalna, a jaka maksymalna wartość k?
