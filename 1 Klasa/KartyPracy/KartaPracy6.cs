int a, b, c, n, suma = 0, dzielnik = 0, ilosc = 0, rytm, iloczyn, licznik, mianownik, silnia, ciag1, ciag2, fib1, fib2, sumafib;

//Zadania 1
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

// C. arytmetyczny
if (b - a == c - b) Console.WriteLine("Jest arytmetyczny");
if (b / a == c / b) Console.WriteLine("Jest geometryczny");


//Zadania 2
for (int i = 100; i < 1000; i++)
{
    if (i % 8 == 0 && i % 16 != 0)
        suma += i;
}
Console.WriteLine(suma);


//Zadania 3
for (int i = 99; i > 10; i--)
{
    if (i % 7 == 0)
    {
        dzielnik = i;
        break;
    }
}

for (int j = 1000; j < 10000; j++)
{
    if (j % dzielnik == 0)
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);

//Zadania 4
ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if ((int)i / 10 > (i % 10) * 2)
        ilosc++;
}
Console.WriteLine(ilosc);

//Zadania 5
suma = 0;
ilosc = 0;
for (int i = 100; i < 1000; i++)
{
    if ((int)i / 100 > (i % 100) / 10 + i % 10)
    {
        ilosc++;
        suma += i;
    }
}
Console.WriteLine(suma);

//Zadania 6
n = Convert.ToInt32(Console.ReadLine());
suma = 0;
ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if (i % 19 == 0)
    {
        ilosc++;
        suma += i;
    }
    if (ilosc == n)
    {
        Console.WriteLine(suma);
        break;
    }
    if (ilosc == 99)
    {
        Console.WriteLine("Out of range");
    }
}

//Zadania 7
n = Convert.ToInt32((Console.ReadLine()));
suma = 0;
ilosc = 0;
for (int i = 999; i < 100; i--)
{
    if (i % 37 == 0)
    {
        ilosc++;
        suma += i;
    }
    if (ilosc == n)
    {
        Console.WriteLine(suma);
        break;
    }
    if (ilosc == 100)
    {
        Console.WriteLine("Out of range");
    }
}

//Zadanie 8 

n = Convert.ToInt32(Console.ReadLine());
rytm = 2;
suma = 0;

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        suma += rytm;
    }
    else
    {
        rytm *= -1;
        suma += rytm;
        rytm *= -1;
    }
    rytm += 3;
}
Console.WriteLine(suma);

// Zadanie 9

n = Convert.ToInt32(Console.ReadLine());

iloczyn = 1;
rytm = 1;

for (int i = 0; i < n; i++)
{
    if (i % 2 == 0)
    {
        iloczyn *= rytm;
    }
    else
    {
        rytm *= -1;
        iloczyn *= rytm;
        rytm *= -1;
    }
    rytm *= 2;

}
Console.WriteLine(iloczyn);


//Zadania 10

n = Convert.ToInt32(Console.ReadLine());
suma = 0;
silnia = 1;

for (int i = 2; i < n+2; i++)
{
    suma += silnia;
    silnia *= i;
}
Console.WriteLine(suma);


//Zadania 11


n = Convert.ToInt32(Console.ReadLine());
suma = 0;
licznik = 1;
mianownik = 1;

for (int i = 0; i < n; i++)
{
    suma += licznik / mianownik;
    Console.WriteLine($"{licznik}/{mianownik}");
    licznik += 2;
    mianownik += licznik;
}
Console.WriteLine(suma);


//Zadanie 12

n = Convert.ToInt32(Console.ReadLine());
licznik = 0;
mianownik = 0;
ciag1 = 1;
ciag2 = 1;
for (int i = 0; i < n; i++)
{
    licznik += ciag1;
    mianownik += ciag2;
    ciag1 += 2;
    ciag2 += ciag1;
}
Console.WriteLine((float)licznik/mianownik);


//Zadania 13 i 14 == to samo

n = Convert.ToInt32(Console.ReadLine());
float FloatSuma = 0;
licznik = 2;
mianownik = 3;

for (int i = 2; i < n+2; i++)
{
    FloatSuma += licznik / mianownik;
    licznik += 2;
    mianownik = (int)Math.Pow(i, 3) + 2;
}
Console.WriteLine(suma);


//Zadanie 15
n = Convert.ToInt32(Console.ReadLine());
licznik = 1;
licznik = 1;
ciag1 = 3;
ciag2 = 1;
for (int i = 0; i < n; i++)
{
    licznik *= ciag1;
    mianownik *= ciag2;
    ciag1++;
    ciag2 = (ciag2 * 2) + 1;
}
Console.WriteLine((float)licznik/mianownik);

//Zadanie 16

n = Convert.ToInt32(Console.ReadLine());
float Floatlicznik = 1;
float Floatmianowik = 1;
ciag1 = 1;
ciag2 = 1;
fib1 = 1;
fib2 = 1;

for (int i = 0; i < n; i++)
{
    Floatlicznik *= ciag1;
    Floatmianowik *= ciag2;
    sumafib = fib1 + fib2;
    fib1 = fib2;
    fib2 = sumafib;
    ciag1 = sumafib;
    ciag2 *= 2;
}
Console.WriteLine(Floatlicznik/Floatmianowik);