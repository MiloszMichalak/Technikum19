//petla while

//przypomnienie fora i zamiana petli na while

//wypisanie cyfr od 1 do 9
/*
for (int i = 1; i < 10; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine();

int j = 1;
while (j<10)
{
    Console.Write(j+" ");
    j++;
}
Console.WriteLine();

int x = 1;
do
{
    Console.Write(x + " ");
    x++;
} while (x < 10);
Console.WriteLine();

//petla nieskonczona
int n = 0;
for (; ; )
{
    n++;
    Console.Write("PoPr" +  " ");
    if (n==100)
    {
        break;
    }
}
Console.WriteLine();

int m = 0;
while (true)
{
    m++;
    Console.Write(m+" ");
    if (m==100)
    {
        break;
    }
}


//Napisz petle while, wypisujaca 2yfrowe niepodzielene przez 3
int o = 99;
while (o>=10)
{
    if (o%3!=0)
    {
        Console.WriteLine(o);
    }
    o--;
}
Console.WriteLine();
*/

//Karta pracy 3 w while
//Zad 1
Console.WriteLine("ZADANIE 1");
int b = 0;
while (b<100)
{
    Console.WriteLine(Math.Pow(b,3)+3);
    b++;
}
Console.WriteLine();
Console.WriteLine();

//Zad 2
Console.WriteLine("ZADANIE 2");
b = 100;
while (b < 1000)
{
    if (b%15==0)
    {
        Console.Write(b+ " ");
    }
    b++;
}
Console.WriteLine();
Console.WriteLine();

//Zad 3
Console.WriteLine("ZDADNAIE 3");
int n = int.Parse(Console.ReadLine());
b = 1;
while (b<=n)
{
    if (n%b==0)
    {
        Console.WriteLine(b);
    }
    b++;
}
Console.WriteLine();
Console.WriteLine();

//Zad 4
Console.WriteLine("ZADANIE 4");
b = 10;
int suma = 0;
while(b<100)
{
    suma += b;
    b++;
}
Console.WriteLine(suma);
Console.WriteLine();
Console.WriteLine();

//Zad 5
Console.WriteLine("ZADANIE 5");
n = int.Parse(Console.ReadLine());
suma = 0;
b = 0;
while (b<n+1)
{
    suma += b;
    b++;
}
while(n>1)
{
    int x = int.Parse(Console.ReadLine());
    suma = suma-x;
    n--;
}
Console.WriteLine($"Nie podales {suma}");
Console.WriteLine();
Console.WriteLine();

//Zad 6
Console.WriteLine("ZADANIE 6");
int y = 1;
int a = 1;
b = 1;
while (y < 100)
{
    Console.WriteLine(a);
    a += b;
    Console.WriteLine(b);
    b += a;
    y++;
}
