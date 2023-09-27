using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartaPracy1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zad 1

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a * a + Math.Pow(b, 2));

            // Zad 2
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine((a + b) + (a + b));

            // Zad 3
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow((a - b), 3));

            // Zad 4
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(a * b * c);

            // Zad 5
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(2 * (a + b) / 5);

            // Zad 6
            int brutto = int.Parse(Console.ReadLine());
            Console.WriteLine(brutto / 123);

            // Zad 7
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(a % b);


            Console.ReadKey();

        }



    }


}