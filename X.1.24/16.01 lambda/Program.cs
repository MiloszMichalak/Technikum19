using System.Xml;

namespace X._1._24;

class Program
{

    // Napisz program, który wczytuje z klawiatury liczbę n, a następnie n imion i wieków osób.
    // Użyj tablicy, aby przechować wczytane imiona i wieki.
    // Użyj listy, aby przechować tylko te imiona, które zaczynają się na literę A.
    // Użyj słownika, aby przechować pary (imie, wiek) dla wszystkich osób, których wiek jest
    // większy niż 18 lat.
    // Wypisz na ekranie zawartość tablicy, listy i słownika.

    static void Main(string[] args)
    {
        int n = ReadInt("Podaj liczbe osob: ", 0, int.MaxValue);

        int[] ages = new int[n];
        string[] names = new string[n];

        for (int i = 0; i < n; i++)
        {
            ages[i] = ReadInt($"Podaj wiek osoby {i + 1}: ", 0, 150);
            names[i] = ReadString($"Podaj imie osoby {i + 1}: ");
        }

        // Ordinal Ingore Case sluzy do nie zwracania uwagi na wielkosc litery
        List<string> namesStartWithA =
            names.Where(item => item.StartsWith("A", StringComparison.OrdinalIgnoreCase)).ToList();

        Console.WriteLine("\n Wyswietlenie tablicy imion i wiekow osob: ");
        PrintArray(namesStartWithA);

        Dictionary<string, int> adults = new Dictionary<string, int>();

        for (int i = 0; i < names.Length; i++)
        {
            if (ages[i] >= 18)
            {
                adults.Add(names[i], ages[i]);
            }
        }


        Console.WriteLine("\nSlownik osob pelnoletnich");
        PrintDictionary(adults);
    }

    private static void PrintDictionary(Dictionary<string, int> adults)
    {
        foreach (var item in adults)
        {
            Console.WriteLine($"{item.Key} : {item.Value}");
        }
    }

    static void PrintArray(List<string> namesStartWithA)
    {
        foreach (var item in namesStartWithA)
        {
            Console.WriteLine(item);
        }
    }

    static int ReadInt(string prompt, int low, int high)
    {
        int result;
        bool valid;
        do
        {
            Console.Write(prompt);
            valid = int.TryParse(Console.ReadLine(), out result) && result >= low && result <= high;
            if (!valid)
            {
                Console.WriteLine($"Podaj liczbe z zakresu {low} : {high}");
            }

        } while (!valid);

        return result;
    }

    static string ReadString(string prompt)
    {
        string result;
        do
        {
            Console.Write(prompt);
            result = Console.ReadLine()!;
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Podaj niepusty ciąg znaków");
            }
        } while (string.IsNullOrEmpty(result));

        return result;
    }
}
