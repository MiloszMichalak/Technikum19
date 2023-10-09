using System;
// zapis systemow liczbowych
// binarny
System.Console.WriteLine("Zamiana systemow liczbowych");
Console.WriteLine(0b1011); //11

// oktalny
Console.WriteLine(011); // 11
int io = Convert.ToInt32("11", 8);
Console.WriteLine(io); // 10 => 2x8^0 + 1x8^1 = 2 + 8 = 10(10)

// Heksadecymalny
Console.WriteLine(0xA1); // 161(10) => Ax16^1 + Ax16^0 = 10x16 + 1x1 = 160 + 1 = 161(10)

System.Console.WriteLine();

// Zakres typów danych
System.Console.WriteLine("Wypisywanie zakresow typow zmiennych");
Console.WriteLine(byte.MinValue); // 0
Console.WriteLine(byte.MaxValue); // 255

Console.WriteLine(sbyte.MinValue); // -128
Console.WriteLine(sbyte.MaxValue); // 127

// Pokazane ze te 3 rodzaje to jest to samo 
Console.WriteLine(int.MaxValue);
Console.WriteLine(Int32.MaxValue);
Console.WriteLine(System.Int32.MaxValue);

System.Console.WriteLine(long.MinValue);
System.Console.WriteLine(long.MaxValue);

System.Console.WriteLine(decimal.MinValue);
System.Console.WriteLine(decimal.MaxValue);

// w dotnet 8 Int128 nie istnieje
System.Console.WriteLine(Int128.MaxValue);

System.Console.WriteLine();

System.Console.WriteLine("Wypisywanie ilosci bajtow");
System.Console.WriteLine(sizeof(byte));
System.Console.WriteLine(sizeof(bool));
System.Console.WriteLine(sizeof(float));

System.Console.WriteLine();

// UNICODE (strona do ascii - asciitable.com)
System.Console.WriteLine("Unicode");
// Kodowanie powinno dzialac - windows, na linuxie ma lekki problem
Console.OutputEncoding = System.Text.Encoding.Unicode;
System.Console.WriteLine("♥");
Console.OutputEncoding = System.Text.Encoding.Default;

// Wyswietla serce poprzez kod unicode
System.Console.WriteLine("\u2665");

// zapisywanie litery jako znak (char) ascii
char letter = 'a';
System.Console.WriteLine(letter);

// zeby jako char przerobic cyfre na litere trzeba rzutowac cyfre na chara
char letter2 = (char)97;
System.Console.WriteLine(letter2);

