using Internal;
using System.Collections.Concurrent;
using System;
using System.IO;
using System.Collections;

namespace Program{
    class Kartkowka{
        public static void Main(string[] args){
            // Zadanie 1
            int liczba = Convert.ToInt32(System.Console.ReadLine());
            System.Console.WriteLine(szukaniCyfryHiszpanskiej(liczba));

            System.Console.WriteLine();

            // Zadanie 2
            System.Console.WriteLine("Zadanie 2");
            
            int cos = 8;
            while (cos > 0){
                System.Console.WriteLine(rerekumkum(cos));
                cos--;
            }

            System.Console.WriteLine();

            // Zadanie 3
            System.Console.WriteLine("Zadanie 3");
            StreamWriter sw = new StreamWriter("boki.txt");
            Random random = new Random();
            for (var i = 0; i < 15; i++)
            {
                    sw.Write(random.Next(1, 10) + " ");
                    sw.WriteLine(random.Next(1, 10));
            }

            sw.Close();

            StreamReader sr = new StreamReader("boki.txt");
            int suma = 0;
            for (var i = 0; i < 15; i++)
            {
                string[] lista = sr.ReadLine().Split(' ');
                suma += (int.Parse(lista[0]) * int.Parse(lista[1])) / 2;
                Array.Clear(lista);
            }
            System.Console.WriteLine(suma);
            sr.Close();
        }

        public static int szukaniCyfryHiszpanskiej(int liczba){
            int mini = 0;
            int liczbaBazowa = liczba;

            // Szuka najwiekszej
            while (liczba > 0){
                int sprawdzarka = liczba % 10;
                if (sprawdzarka > mini){
                    mini = sprawdzarka; 
                }
                liczba /= 10;
            }

            while (liczbaBazowa > 0){
                int sprawdzarka = liczbaBazowa % 10;
                if (sprawdzarka < mini){
                    mini = sprawdzarka; 
                }
                liczbaBazowa /= 10;
            }
            return mini;
        }

        public static int rerekumkum(int n){
            if (n == 1) return 1;
            if (n == 2) return 3;
            if (n == 3) return 5;
            return rerekumkum(n - 1) * 2 + rerekumkum(n - 2) + rerekumkum(n - 3);
        }

    }
}