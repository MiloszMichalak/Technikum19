
using System;
// // 1. User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.
// Console.WriteLine("Zadanie 1");
// int nwd(int a, int b)
// {
//     while (a != b)
//     {
//         if (a > b)
//         {
//             a -= b;
//         }
//         else
//         {
//             b -= a;
//         }
//     }
//     return a;
// }

// int nww(int a, int b)
// {
//     return a * b / nwd(a, b);
// }

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i < 100; i++)
// {
//     for (int j = 1; j < 100; j++)
//     {
//         if (nwd(i, j) == a && nww(i ,j) == b){
//             System.Console.WriteLine(i + " " + j);
//         }
//     }
// }

// System.Console.WriteLine();

// // 2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.
// // Zadanie zrobione w przyapdku kiedy licznik i mianownik sa podawane oddzielnie
// Console.WriteLine("Zadanie 2");
// int gora1 = Convert.ToInt32(Console.ReadLine());
// int dol1 = Convert.ToInt32(Console.ReadLine());
// int gora2 = Convert.ToInt32(Console.ReadLine());
// int dol2 = Convert.ToInt32(Console.ReadLine());

// int wspolnyDzielnik = nww(dol1, dol2);

// int gotowaGora1 = (wspolnyDzielnik / dol1) * gora1;
// int gotowaGora2 = (wspolnyDzielnik / dol2) * gora2;

// int dodanaGora = gotowaGora1 + gotowaGora2;

// if (dodanaGora / wspolnyDzielnik > 0){
//     System.Console.WriteLine("Tak");
// } else {
//     System.Console.WriteLine("Nie");
// }

// System.Console.WriteLine();

// // Zadanie zrobione w wersji kiedy uzytkownik musi podac ulamek w wersji np.: 2/7
// // Wczytywanie ulamkow
// string pierwszy = Console.ReadLine();
// string drugi = Console.ReadLine();

// // Rozdzielanie ułamków
// string[] Ulamek1 = pierwszy.Split("/");
// string[] Ulamek2 = pierwszy.Split("/");

// // wczytywanie rozdzielonych ulamkow do poszczegolnych zmiennych
// gora1 = Convert.ToInt32(Ulamek1[0]);
// gora2 = Convert.ToInt32(Ulamek1[1]);

// dol1 = Convert.ToInt32(Ulamek2[0]);
// dol2 = Convert.ToInt32(Ulamek2[1]);

// wspolnyDzielnik = nww(dol1, dol2);

// gotowaGora1 = (wspolnyDzielnik / dol1) * gora1;
// gotowaGora2 = (wspolnyDzielnik / dol2) * gora2;

// dodanaGora = gotowaGora1 + gotowaGora2;

// if (dodanaGora / wspolnyDzielnik > 0){
//     System.Console.WriteLine("Tak");
// } else {
//     System.Console.WriteLine("Nie");
// }

// // 3. Sprawdź czy wieksza jest suma dwóch wpisanych przez usera ułamków czy suma ich odwrotności.
// // Wykonanie zadania tylko dla wpisywanych ulamkow w postaci 2/7
// System.Console.WriteLine("Zadanie 3");

// pierwszy = Console.ReadLine();
// drugi = Console.ReadLine();

// // Rozdzielanie ułamków
// Ulamek1 = pierwszy.Split("/");
// Ulamek2 = pierwszy.Split("/");

// // wczytywanie rozdzielonych ulamkow do poszczegolnych zmiennych
// gora1 = Convert.ToInt32(Ulamek1[0]);
// gora2 = Convert.ToInt32(Ulamek1[1]);

// dol1 = Convert.ToInt32(Ulamek2[0]);
// dol2 = Convert.ToInt32(Ulamek2[1]);

// wspolnyDzielnik = nww(dol1, dol2);

// gotowaGora1 = (wspolnyDzielnik / dol1) * gora1;
// gotowaGora2 = (wspolnyDzielnik / dol2) * gora2;

// dodanaGora = gotowaGora1 + gotowaGora2;

// int temp1 = gora1;
// int temp2 = dol1;
// gora1 = gora2;
// dol1 = dol2;
// gora2 =temp1;
// dol2 = temp2;

// wspolnyDzielnik = nww(dol1, dol2);

// gotowaGora1 = (wspolnyDzielnik / dol1) * gora1;
// gotowaGora2 = (wspolnyDzielnik / dol2) * gora2;

// int dodanaGora2 = gotowaGora1 + gotowaGora2;

// if (dodanaGora > dodanaGora2){
//     System.Console.WriteLine("Wieksze jest suma oryginalnych ulamkow");
// } else {
//     System.Console.WriteLine("Wieksza jest suma odwroconych ulamkow");
// }

// 4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek. (cos tak nie bardzo)
// System.Console.WriteLine("Zadanie 4");
// char[] samogloski = {'a', 'e', 'i', 'o', 'u', 'y'};
// string napis = Console.ReadLine();
// int iloscSpoglosek = 0;
// int iloscSamoglosek = 0;
// for (int i = 0; i < 6; i++){
//     if (napis.Contains(samogloski[i])){
//         iloscSamoglosek++;
//     } else {
//         iloscSamoglosek++;
//     }
// }

// if (iloscSamoglosek > iloscSpoglosek){
//     System.Console.WriteLine("Wiecej jest samoglosek");
// } else if (iloscSpoglosek > iloscSamoglosek) {
//     System.Console.WriteLine("Wiecej jest spolglosek");
// } else {
//     System.Console.WriteLine("Samoglosek i spolglosek jest tyle samo");
// }

// System.Console.WriteLine();

// 5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.
System.Console.WriteLine("Zadanie 5");

// W tym 10 zadaniu ni9e wiem co sie dzieje
//* 10. Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował - 
//* przechadzających się ludzi.
//* W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
//* obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
//* znaleźć sobie miejsce na ławce.
//* Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
//* Jaka jest minimalna, a jaka maksymalna wartość k?

System.Console.WriteLine("Zadanie 10");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int m = Convert.ToInt32(Console.ReadLine());

int max1 = 0;
if (a > b && a > c) max1 = a;
if (b > a && b > c) max1 = b;
if (c > a && c > b) max1 = c;

int k = max1 + m;
System.Console.WriteLine("Maks wartosc k = {0}", k);

int suma = a + b + c + k;
System.Console.WriteLine(suma / 3);
