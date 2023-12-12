// idea rekurencji
// reku utożsamiaj z pętlą
// 3 elem pętli: start, stop, step

using System.Numerics;
using System.Threading.Channels;

int reku1(int n)
{
    if (n == 0) return 1;
    return reku1(n-1);
}
Console.WriteLine(reku1(5));

//reku1(5) ...... 
//reku1(4)   => 6 * 4
//reku1(3)   => 2 * 3
//reku1(2)   => 1*2
//reku1(1)   => 1*1
//reku1(0)   => 1

void reku2(int n)
{
    if (n == 0) return;
    Console.WriteLine(n);
    reku2(n - 1);
    Console.WriteLine(n);
}

reku2(5);

//reku2(5) .....
//reku2(4) .....
//reku2(3) .....
//reku2(2) .....
//reku2(1) .....
//reku2(0) .....

Console.WriteLine("\n");

// Zad 3. Napisz algorytm sumujący cyfry iter i reku
Console.WriteLine("Zadanie 3");
int suma = 0;
for (int i = 0; i < 10; i++)
{
    suma += i;
}
Console.WriteLine(suma);

int re1(int n)
{
    if (n == 0) return 0;
    return re1(n - 1) + n;
}
Console.WriteLine(re1(9));

//re1(9) ... re(8) + 9
//re1(8) ... re(7) + 8
//re1(7) ... -> 21 + 7 = 28
//re1(6) ... -> 15 + 6 = 21
//re1(5) ... 
//re1(4) ... 
//re1(3) ... -> 6 + 4 = 10
//re1(2) ... -> 1 + 2 = 3
//re1(1) ... -> 0 + 1 = 1
//re1(0) ... -> 0

Console.WriteLine("\n");

// 4. Napisz alg sumujący liczby dwucyfrowe parzyste iter i reku
Console.WriteLine("Zadanie 4");
suma = 0;
for (int i = 10; i < 100; i++)
{
    suma += i;
}
Console.WriteLine(suma);

int r2(int n)
{
    if (n == 10) return 10;
    return r2(n - 2) + n;
}
Console.WriteLine(r2(98));

Console.WriteLine("\n");

// 5. Oblicz sumę n pierwszych wyrazów ciągów:
// a) 3, 6, 9, 12, 15, 18, 21 ... <=> 3+6+9+12 = 3(1+2+3+4)
Console.WriteLine("Zadanie 5 a)");
suma = 0;
for (int i = 3; i < 15; i += 3)
{
    suma += i;
}
Console.WriteLine(suma);


int r5a1(int n)
{
    if (n == 1) return 3;
    return r5a1(n - 1) + 3 * n;
}

int r5a2(int n)
{
    if (n == 1) return 3;
    return r5a2(n - 1) + 3;
}
// Podajac 4 liczy sume dla 4 elementow
Console.WriteLine(r5a1(4));

Console.WriteLine("\n");

// b) 12, 23, 34, 45, 54 ...
Console.WriteLine("Zadanie 5 b)");

int r5b(int n)
{
    if (n == 1) return 12;
    return r5b(n - 1) + 11;
}
Console.WriteLine(r5b(3));

suma = 0;
for (int i = 1; i <= 3; i++)
{
    suma += r5b(i);
}
Console.WriteLine(suma);

Console.WriteLine("\n");

// c) 2, 6, 18, 54 ...
Console.WriteLine("Zadanie 5 c)");

// d) 1, 4, 9, 16, 25 ...
Console.WriteLine("Zadanie 5 d)");

int r5d(int n)
{
    if (n == 1) return 1;
    return r5d(n - 1) + 2 * (n - 1) + 1;
}
Console.WriteLine(r5b(5));

suma = 0;
for (int i = 1; i <= 5; i++)
{
    suma += r5d(i);
}
Console.WriteLine(suma);

Console.WriteLine("\n");

// 6. Wypisz n pierwszych wyrazów ciągu:
// a) 1,5  1  0,5  -0,5  -2  -4,5  -8,5  -15
Console.WriteLine("Zadanie 6 a)");

double r6a(int n)
{
    if (n == 1) return 1.5;
    if (n == 2) return 1;
    if (n == 3) return 0.5;
    return r6a(n - 1) * 2 - r6a(n - 3);
}

Console.WriteLine(r6a(5));

double sumaDouble = 0;
for (int i = 1; i <= 5; i++)
{
    sumaDouble += r6a(i);
}

Console.WriteLine(sumaDouble);

Console.WriteLine();

// 7. Inne ciągi kosmiczne - rakieta USA

// a. 1  3  4   8  15   27

// b. 4    5    -3    2   14   22    48   

// c. 1    1    1    3   5   9   

// d. 2   3    4     -1    -8    -11   -2  

// e. 1   4    3    16     5     64     7    256   9   1024    
Console.WriteLine("Zadanie 7a");

// trzeba pamietac ze argumenty w r7a to po prostu elementy ktore mozna dodawac lub cos innego
// a. 1  3  4    8  15   27
int r7a(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 3;
    if (n == 3) return 4;
    return r7a(n - 1) + r7a(n - 2) + r7a(n - 3);
}

Console.WriteLine(r7a(5));

Console.WriteLine();

Console.WriteLine("Zadanie 7d");
// d. 2   3    4      -1    -8    -11   -2  
int r7d(int n)
{
    if (n == 1) return 2;
    if (n == 2) return 3;
    if (n == 3) return 4;
    return r7a(n - 1) - r7a(n - 2) - r7a(n - 3);
}

Console.WriteLine(r7d(5));

Console.WriteLine();
// e. 1   4    3    16     5     64     7    256   9   1024    
int r7e(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 4;
    if (n % 2 == 0) return r7e(n - 2) * 4;
    return r7e(n - 2) + 2;
}

Console.WriteLine(r7e(5));

Console.WriteLine();

// 8. Wyznacz sume cyfr wpisanej przez usera liczby (iter + reku)
Console.WriteLine("Zadanie 8");
int input = Convert.ToInt32(Console.ReadLine());
// iteracyjnie
suma = 0;
// lepiej by bylo zrobic foreacha ktory idzie przez cala liczbe;
while (input > 0)
{
    suma += input % 10;
    input /= 10;
}

Console.WriteLine(suma);

// rekurenycjnie
int liczenieCyfr(int input)
{
    if (input == 0) return 0;
    return liczenieCyfr(input / 10) + input % 10;
}

Console.WriteLine(liczenieCyfr(input));

Console.WriteLine();

// 9. Zamiana dec na bin (iter + reku)
Console.WriteLine("Zadanie 9");

string DecToBinIter(int input)
{
    string output = "";
    while (input > 0)
    {
        output = input % 2 + output;
        input /= 2;
    }

    return output;
}

Console.WriteLine(DecToBinIter(10));

void DecToBinReku(int input)
{
    if (input == 0) return;
    DecToBinReku(input / 2);
    Console.Write(input % 2);
}

DecToBinReku(10);
