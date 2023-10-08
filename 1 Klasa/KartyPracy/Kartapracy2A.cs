int a, b, c, d;
//Zad 1
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if ((a + b) % 2 == 0)
{
    Console.WriteLine("Tak, suma tych liczb jest parzysta");
}
else
{
    Console.WriteLine("Nie, suma tych liczb nie jest parzysta");
}

//Zad 2
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
if ((a + b) / 2 > Math.Sqrt(a * b))
{
    Console.WriteLine("Tak, srednia arytmetyczna jest wieksza od sredniej geometrycznej");
}
else
{
    Console.WriteLine("Nie, srednia arytmetyczna nie jest wieksza od sredniej geometrycznej");
}

//Zad 3
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if (a == b || a == c || b == c)
{
    Console.WriteLine("Tak, sa przynajmniej dwie liczby rowne sobie");
    if (a == b && a == c && b == c)
    {
        Console.WriteLine("Wszystkie liczbe sa sobie rowne");
    }
    else if (a == b)
    {
        Console.WriteLine("Sa to liczba1 i liczba2");
    }
    else if (a == c)
    {
        Console.WriteLine("Sa to liczba1 i liczba3");
    }
    else if (b == c)
    {
        Console.WriteLine("Sa to liczba2 i liczba3");
    }
}
else
{
    Console.WriteLine("Nie ma liczb rownych sobie");
}

//Zad 4
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
d = int.Parse(Console.ReadLine());
if (a < b && a < c && a < d)
{
    Console.WriteLine("Najmniejsza z nich to liczba1");
}
else if (b < a && b < c && b < d)
{
    Console.WriteLine("Najmniejsza z nich jest liczba2");
}
else if (c < a && c < b && c < d)
{
    Console.WriteLine("Najmniejsza z nich jest liczba3");
}
else if (d < a && d < b && d < c)
{
    Console.WriteLine("Najmniejsza z nich jest liczba4");
}

//Zad 5
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
{
    Console.WriteLine("Tak, Trojkat spelnia zasade nierownosci trojkata");
}
else
{
    Console.WriteLine("Nie, Trojkat nie spelnia zasady nierownosci trojkata");
}

//zad 6
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
c = int.Parse(Console.ReadLine());
if (a + b > c && b + c > a && a + c > b)
{
    Console.WriteLine("Powstanie trojkat");
    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2))
    {
        Console.WriteLine("Prostokatny");
    }
    else if (Math.Pow(a, 2) + Math.Pow(b, 2) > Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) > Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) > Math.Pow(b, 2))
    {
        Console.WriteLine("Ostrokatny");
    }
    else if (Math.Pow(a, 2) + Math.Pow(b, 2) < Math.Pow(c, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) < Math.Pow(a, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) < Math.Pow(b, 2))
    {
        Console.WriteLine("Rozwartokatny");
    }
}
else
{
    Console.WriteLine("Trojkat nie powstanie");
}