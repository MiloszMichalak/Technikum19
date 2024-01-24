using System;
using System.Collections.Generic;

namespace Grafy_i_klasy;

class Program
{
    // 
    static void Main(string[] args)
    {
        Graf graf = new Graf(6);
        graf.DodajKrawedz(0, new []{1, 2});
        graf.DodajKrawedz(1, new []{0, 3});
        graf.DodajKrawedz(2, new []{0, 3, 5});
        graf.DodajKrawedz(4, new []{3, 1, 2, 5});
        graf.DodajKrawedz(5, new []{5, 2, 3});

        for (int i = 0; i < 6; i++)
        {
            graf.WypiszKrawedzie(i);
        }

        for (int i = 0; i < 6; i++)
        {
            graf.WypiszKrawedzie(i);
            Console.WriteLine();
        }

    }
}
