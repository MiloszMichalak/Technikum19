//Cwiczenia na tabele
using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
/*
Wygeneruj tablicę n losowych liczb:
Random r = new Random()
r.Next(pocz, kon)
1. Znajdź największą liczbę w tablicy
2. Znajdź najmniejszą liczbę w tablicy
3. Podaj ile razy występuje najwieksza liczba w tablicy
4. Podaj ile razy występuje najmniejsza liczba w tablicy
5. Podaj rozpiętość tablicy (różnica max - min)
6. Podaj sumę liczb w tablicy
7. Podaj średnią wartość liczb w tablicy
8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
9. Ile w tablicy jest liczb pierwszych?
10. Podaj v-ce max i v-ce min liczb tablicy
*/

int n = 10;
int pocz = 1;
int kon = 20;

//Generowanie tablicy
int[] T = new int[n];
Random r = new Random();
Console.WriteLine("Dlugosc tabeli");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(T[i] = r.Next(pocz, kon)); 
}

//1. Znajdź największą liczbę w tablicy
int max = T[0];
for (int i = 0; i < n; i++)
{
    if (T[i] > max)
    {
        max = T[i];
    }      
}
Console.WriteLine($"Najwieksza wartosc w tej tabeli to: {max}");

//2. Znajdź najmniejszą liczbę w tablicy
int min = T[0];
for (int i = 0; i < n; i++)
{
    if (T[i] < min)
    {
        min = T[i];
    }
}
Console.WriteLine($"Najmniejsza wartosz tej tabeli to {min}");

//3. Podaj ile razy występuje najwieksza liczba w tablicy
int temp = 0;
max = T[0];
for (int i = 0; i < n; i++)
{
    if (T[i]>max)
    {
        max = T[i];
    }
}

for (int i = 0; i < n; i++)
{
    if (T[i] == max)
    {
        temp++;
    }
}
Console.WriteLine($"Najwieksza wartosc w tablicy wystepuje: {temp} razy");

//4. Podaj ile razy występuje najmniejsza liczba w tablicy
temp = 0;
min = 0;
for (int i = 0; i < n; i++)
{
    if (T[i]<min)
    {
        min = T[i];
    }
}

for (int i = 0; i < n; i++)
{
    if (T[i] == min)
    {
        temp++;
    }
}
Console.WriteLine($"Najmniejsza ilosc w tablicy wystepuje: {temp} razy");

//5. Podaj rozpiętość tablicy (różnica max - min)
max = 0;
min = 0;

for (int i = 0; i < n; i++)
{
    if (T[i]>max)
    {
        max = T[i];
    }
}

for (int i = 0; i < n; i++)
{
    if (T[i]<min)
    {
        min = T[i];
    }
}
Console.WriteLine($"Roznica tablicy wynosi: {max-min}");

//6. Podaj sumę liczb w tablicy
int suma = 0;
for (int i = 0; i < n; i++)
{
    suma += T[i];
}

//7. Podaj średnią wartość liczb w tablicy
suma = 0;
for (int i = 0; i < n; i++)
{
    suma += T[i];
}
Console.WriteLine($"Srednia w liczb w tabeli wynosi: {(float)suma/n}");

//8. Których liczb jest więcej w tablicy: parzystych czy nieparzystych?
int parz = 0;
int nparz = 0;
for (int i = 0; i < n; i++)
{
    if (T[i]%2 == 0)
    {
        parz++;
    }
    else
    {
        nparz++;
    }
}
if (parz>nparz)
{
    Console.WriteLine("Wiecej jest liczb parzystych");
}
else if (nparz>parz)
{
    Console.WriteLine("Wiecej jest liczb nie parzystych");
}
else
{
    Console.WriteLine("Liczb parzystych i nie parzystych jest tyle samo");
}

//9. Ile w tablicy jest liczb pierwszych
int pierwsze = 0;
for (int i = 0; i < n; i++)
{
    temp = 0;
    for (int j = 1; j < n; j++)
    {
        if (T[i] % j == 0)
        {
            temp++;
        }
    }
    if (temp==2)
    {
        pierwsze++;
    }
}
Console.WriteLine($"W tej tablicy jest {pierwsze} liczb pierwszych");

//10. Podaj v-ce max i v-ce min liczb tablicy
max = T[0];
min = T[0];
int v_max = 0;
int v_min = 0;

for (int i = 0; i < n; i++)
{
    if (T[i]>max)
    {
        max = T[i];
    }
}

for (int i = 0; i < n; i++)
{
    if (T[i]<min)
    {
        min = T[i];
    }
}

for (int i = 0; i < n; i++)
{
    if (T[i] > v_max && T[i] < max)
    {
        v_max = T[i];
    }
    if T[i]
}