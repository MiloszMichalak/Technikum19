double kapKon = 0;
//ZADANIE 1
Console.WriteLine("Zadanie 1");
for (int i = 1; i < 31; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();


//ZADANIE 2
Console.WriteLine("Zadanie 2");
for (int i = 1; i < 100; i++)
{
    if (i % 2 == 1)
    {
        Console.WriteLine($"{i}^2 = { Math.Pow(i, 2)}");
    }
}
Console.WriteLine();


//ZADANIE 3
Console.WriteLine("Zadanie 3");
for (int i = 1000; i < 10000; i++)
{
    if (i % 379 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();


//ZADANIE 4
Console.WriteLine("Zadanie 4");
for (int i = 100; i < 1000; i++)
{
    if (i % 5 == 0 || i % 6 == 0 || i % 11 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();


//ZADANIE 5
Console.WriteLine("Zadanie 5");
Console.WriteLine("Ile liczb wypisac: ");
int n = int.Parse(Console.ReadLine());
int suma = 0;
for (int i = 1; i < n+1; i++)
{
    int c = int.Parse(Console.ReadLine());
    suma = suma + i;
}
Console.WriteLine(suma);
Console.WriteLine();


//ZADANIE 6
int k = int.Parse(Console.ReadLine());
suma = 0;
for (int i = 2; i < (k * 2) + 2; i += 2)
{
    suma =+ i;
}
Console.WriteLine(suma);


//ZADANIE 7
int m = int.Parse(Console.ReadLine());
suma = 0;
for (int i = 11; i < (m * 2) + 2; i += 11)
{
    suma =+ i;
}
Console.WriteLine(suma);
Console.WriteLine();


//ZADANIE 8
Console.WriteLine("ZADANIE 8");
Console.Write("Podaj początkowy kapitał: ");
int kapPocz = int.Parse(System.Console.ReadLine());
Console.Write("Podaj lata inwestycji: ");
int lataInw = int.Parse(System.Console.ReadLine());
suma = kapPocz;
for (int i = 0; i < lataInw * 12; i++)
{
    kapKon = suma * 0.06 * 1 / 12f;
    suma = (int)+ kapKon;
}
Console.WriteLine($"Końcowy kapitał wynosi: {(suma, 2)} zl");
Console.WriteLine();



//ZADANIE 9
Console.WriteLine("Zadanie 9");
Console.Write("Podaj ilość liczb: ");
int a = int.Parse(Console.ReadLine());
int b = 21;
suma = 0;
for (int i = 0; i <= a; i++)
{
    for (int c = 0; c < i; c += b)
    {
        Console.WriteLine(b);
        suma += b;
        b += 100;
    }
}
Console.WriteLine(suma);
Console.WriteLine();


//ZADANIE 10
for (int i = 1; i < 1000; i++)
{
    if (i % 10 == Math.Sqrt(i)) 
    {
        Console.WriteLine(i);
    }
    if (i % 100 == Math.Sqrt(i)) 
    {
        Console.WriteLine(i);
    }
}