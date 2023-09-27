//zad 1
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    Console.WriteLine(Math.Pow(i, 3) + 3 + " ");
}

//zad 2
for (int i = 105; i < 1000; i+=15)
{
    Console.WriteLine(i);
}

//zad 3
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <= a; i++)
{
    if (a % i == 0)
    {
        Console.Write(i + ' ');
    }
}
//zad 4
int suma = 0;
for (int i = 10; i < 100; i++)
{
    suma += i;
}
Console.WriteLine(suma);

//zad 5
int x;
n = int.Parse(Console.ReadLine());
suma = n * (n + 1) / 2;

for (int i = 0; i < n - 1; i++)
{
    x = int.Parse(Console.ReadLine());
    suma = suma - x;
}
Console.WriteLine(suma);

//zad 6
n = int.Parse(Console.ReadLine());
a = 0;
int b = 1;
int temp;
Console.Write($"{a} {b} ");
for (int i = 0; i < n - 1; i++)
{
    temp = a;
    a = b;
    b = temp + b;
    Console.Write(b + " ");
}


Console.ReadKey();