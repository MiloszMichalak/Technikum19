using System.Collections;
using System.IO;
using System;

namespace Program
{

    class main
    {
        public static void Main(string[] args)
        {
            // StreamWriter streamWriter = new StreamWriter("liczby.txt");

            // // Zadanie 1 - zapisuje 20 losowych liczb do pliku nastepnie odczytuje je i zamienia na binarne i zlicze sume cyfr liczby w wersji binarnej
            // Console.WriteLine("Zadanie 1");
            Random random = new Random();
            // for (var i = 0; i < 20; i++){
            //     streamWriter.WriteLine(random.NextInt64(1, 10));
            // }
            // streamWriter.Close();

            // string[] tablica = System.IO.File.ReadAllLines("liczby.txt");

            // StreamWriter zapisacz = new StreamWriter("binarka.txt");
            // foreach (var item in tablica){
            //     int suma = 0;
            //     string binarna = naBinarke(int.Parse(item));
            //     int objekt = int.Parse(binarna);
            //     while (objekt != 0){
            //         suma += objekt % 10;
            //         objekt /= 10;
            //     }
            //     zapisacz.WriteLine($"{binarna} = {suma}");
            // }
            // zapisacz.Close();

            // System.Console.WriteLine();

            // // Zadanie 2 od Kacpra - stwórz plik o nazwie output.txt i wpisz do niego wszystkie liczby 2-cyfrowe podzielne przez 3
            // System.Console.WriteLine("Zadanie 2");
            // StreamWriter sw = new StreamWriter("Output.txt");
            // for (var i = 10; i < 100; i++)
            // {
            //     if (i % 3 == 0){
            //         sw.WriteLine(i);
            //     }
            // }

            // System.Console.WriteLine();
            // // Zadanie 3 od Kacpra Odczytaj plik o nazwie liczby.txt i wypisz w konsoli wszystkie te które są parzyste
            // System.Console.WriteLine("Zadanie 3");
            // StreamReader sr = new StreamReader("Liczby.txt");
            // while (!sr.EndOfStream){
            //     int liczba = int.Parse(sr.ReadLine());
            //     if (liczba % 2 == 0){
            //         System.Console.WriteLine(liczba);
            //     }
            // }
            // sr.Close();

            // for (var i = 0; i < 4; i++)
            // {
            //     System.Console.WriteLine(rerekumkum(i));
            // }
            System.Console.WriteLine();

            // Zadanie 1 spr - daj funkcje ktora daje dlugosc liczby w binarce
            System.Console.WriteLine("SPRAWDZIAN GR.1 ");
            // System.Console.WriteLine("Zadanie 1");

            // System.Console.WriteLine(binarka(8));
            // System.Console.WriteLine();

            // // Zapisz do pliku liczbySzwedzkie 30 wyrazow po 3 losowe licbzy od 1 do 20 - Otworz ten plik i policz w ile wierszach srednia wpisanych liczb jest powyzej 12.5
            // System.Console.WriteLine("Zadanie 3");
            // StreamWriter szwedzkie = new StreamWriter("szwedzkie.txt");
            // for (var i = 0; i < 30; i++)
            // {
            //     for (var j = 0; j < 3; j++)
            //     {
            //         if (j < 2)
            //         {
            //             szwedzkie.Write(random.NextInt64(1, 20) + " ");
            //         }

            //         if (j == 2)
            //         {
            //             szwedzkie.Write(random.NextInt64(1, 20));
            //         }
            //     }
            //     szwedzkie.WriteLine();
            // }

            // szwedzkie.Close();

            // StreamReader odczytywacz = new StreamReader("szwedzkie.txt");
            // int ile = 0;
            // for (var i = 0; i < 30; i++)
            // {
            //     double suma = 0;
            //     string[] liczby = (odczytywacz.ReadLine()).Split(" ");
            //     foreach (var item in liczby)
            //     {
            //         suma += int.Parse(item);
            //     }
            //     Array.Clear(liczby);
            //     if (suma / 3 > 12.5)
            //     {
            //         ile++;
            //     }
            // }
            // System.Console.WriteLine(ile);
            // odczytywacz.Close();

            // Szukanie liczb palindromowych

            System.Console.WriteLine("Zadanie 4");
            int liczba = 323;
            string liczebka = Convert.ToString(liczba);
            char[] tablica = liczebka.ToCharArray();
            Array.Reverse(tablica);
            string odwrot = new string(tablica);

            if (liczebka.Equals(odwrot)){
                System.Console.WriteLine("Tak");
            } else {
                System.Console.WriteLine("Nie");
            }

        }

        // Zadanie 1 spr - daj funkcje ktora daje dlugosc liczby w binarce
        public static int binarka(int liczba)
        {
            return (int)(Convert.ToString(liczba, 2)).Length;
        }


        public static string naBinarke(int decimalNumber)
        {
            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            return result;
        }
    }
}
