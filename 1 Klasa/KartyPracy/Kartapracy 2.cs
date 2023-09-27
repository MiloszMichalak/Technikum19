using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy2
{
    internal class cs
    {
        static void Main(string[] args)
        {
            {//zad 1
                int a;
                a = int.Parse(Console.ReadLine());
                if (a % 3 == 0)
                {
                    Console.WriteLine("Tak");
                }
                else
                {
                    Console.WriteLine("Nie");
                }
                //zad 2
                a = int.Parse(Console.ReadLine());
                if (a >= 100 && a < 1000 && a % 17 == 0)
                {
                    Console.WriteLine("Tak");
                }
                else
                {
                    Console.WriteLine("Nie");
                }
                //zad 3
                a = int.Parse(Console.ReadLine());
                if (a >= 18)
                {
                    Console.WriteLine("Tak");
                }
                else
                {
                    Console.WriteLine("Nie");
                }
                //zad 4
                const int waga = 20;
                a = int.Parse(Console.ReadLine());
                if (a >= waga)
                {
                    Console.WriteLine("Nie");
                }
                else
                {
                    Console.WriteLine("Tak");
                }
                //zad 5
                a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int c = int.Parse(Console.ReadLine());
                if (a < c && c < b || a > c && c > b)
                {
                    Console.WriteLine("Tak");
                }
                else
                {
                    Console.WriteLine("Nie");
                }

                //zad 6
                a = int.Parse(Console.ReadLine());
                int p = int.Parse(Console.ReadLine());
                if ((Math.Pow(a, p) - a) % p == 0) //=if (a**p - a) % p == 0:
                {
                    Console.WriteLine("Tak");
                }
                else
                {
                    Console.WriteLine("Nie");
                }
                //zad 7
                p = int.Parse(Console.ReadLine());
                int k = int.Parse(Console.ReadLine());
                int s = int.Parse(Console.ReadLine());
                if (s * 3 >= k - p) //=if (k-p) <= 3*s:
                {
                    Console.WriteLine("Tak");
                }
                else
                {
                    Console.WriteLine("Nie");
                }
                //&&=and
                //||=or

                Console.ReadKey();
            }
        }

    }

}   



