using System.Collections;

namespace Zadania2;

class Program
{
    static void Main(string[] args)
    {
        // 1. Wpisz do tablicy T 5 losowych liczb dwucyfrowych. 
        //     Stwórz tablicę W liczb parzystych znajdujących się między 
        // minimalną i maksymalną wartością z tablicy T.
        Console.WriteLine("Zadanie 1");

        Random random = new Random();
        int[] T = new int[5];
        for (int i = 0; i < 5; i++)
        {
            T[i] = random.Next(10, 100);
        }

        int min = T.Min();
        int max = T.Max();
        
        // za pomoca math tez moze byc
        // foreach (var item in T)
        // {
        //     min = Math.Min(min, item);
        //     max = Math.Max(max, item);
        // }

        int czy = min % 2 != 0 && max % 2 != 0 ? 0 : 1;
        int[] W = new int[(max - min) / 2  + czy];
        int k = 0;
        for (int i = min; i <= max; i++)
        {
            if (i % 2 == 0)
            {
                W[k] = i;
                k++;
            }
        }

        Console.WriteLine($"Liczby parzyste miedzy {min} i {max} w tablicy T: ");
        Console.WriteLine(String.Join(", ", W));

        Console.WriteLine();

        // 2. Utwórz ArrayListę A zawierającą 10 losowych słów 3-literowych. 
        //     Wypisz słowo o najwiekszej sumie kodów ASCII jego liter
        Console.WriteLine("Zadanie 2");
        
        const string alfabet = "abcdefghijklmnoprstuwyz";
        ArrayList slowa = new ArrayList();
        
        for (int j = 0; j < 10; j++)
        {
            string slowo = new string("");
            for (int i = 0; i < 3; i++)
            {
                slowo += alfabet[random.Next(alfabet.Length)];
            }

            slowa.Add(slowo);
        }

        List<int> sumy = new();
        foreach (string item in slowa)
        {
            int suma = 0;
            foreach (char litera in item)
            {
                suma += litera;
            }

            sumy.Add(suma);
        }

        Console.WriteLine(slowa[sumy.IndexOf(sumy.Max())]);

        Console.WriteLine();

        // 3. Stwórz listę L składającą się z 10 list 10 losowych cyfr. Oblicz sumę największych cyfr w listach listy L oraz 
        //     sprawdź czy istnieje taka lista gdzie wylosowano 3 identyczne cyfry.
        Console.WriteLine("Zadanie 3");
        List<List<int>> lista = new();

        for (int i = 0; i < 10; i++)
        {
            List<int> temp = new();
            for (int j = 0; j < 10; j++)
            {
                temp.Add(random.Next(10, 100));
            }
            lista.Add(temp);
        }

        int suma2 = 0;
        foreach (var item in lista)
        {
            suma2 += item.Max();
        }

        Console.WriteLine(suma2);
        
        // TODO wyszukiwanie czy 3 elementy sa te same

        Console.WriteLine();
        
        // 4. Stwórz słownik D z kluczami i = 1, 2, 3 ... n (user podaje n) oraz wartościami w postaci listy
        //    maksymalnie (i-1)-cyfrowych dzielników liczby 10 do potęgi i dla każdego z kluczy.
        Console.WriteLine("Zadanie 4");
        
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<int, List<int>> dictionary = new();
        
        for (int i = 1; i <= n; i++)
        {
            dictionary.Add(i, dzielniki((int)Math.Pow(10, i), (int)Math.Pow(10, i - 1)));
        }

        foreach (var item in dictionary)
        {
            Console.WriteLine($"{item.Key} - {String.Join(", ", item.Value)}" +
                              $". Dzielniki {Math.Pow(10, item.Key)} ograniczone do {Math.Pow(10, item.Key - 1)}");
        }
    }

    public static List<int> dzielniki(int n, int k)
    {
        List<int> zwrot = new();
        for (int i = 1; i < k; i++)
        {
            if (n % i == 0)
            {
                zwrot.Add(i);
            }
        }

        return zwrot;
    }
}
