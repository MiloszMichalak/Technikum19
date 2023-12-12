namespace _12._12;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> slownik = new Dictionary<int, string>();
        slownik.Add(1, "Czarek");
        slownik.Add(2, "Jakub");
        slownik.Add(3, "Franek");
        
        foreach (var element in slownik)
        {
            Console.WriteLine($"{element.Key} ; {element.Value}");
        }
        
        Console.WriteLine();
        
        // slownik ktory jako klucze ma lanuchy a liczby jako wartosc
        
        Dictionary<string, int> slownik1 = new Dictionary<string, int>();
        slownik1.Add("Burger", 4);
        slownik1.Add("Zapiekanka", 2);
        slownik1.Add("Hot Dog", 5);
        
        // KeyValuePair<string, int>  jest domyslnie jesli pisac caly typ zmiennej
        foreach (KeyValuePair<string, int> element in slownik1)
        {
            Console.WriteLine("Item: {0}, Amount: {1}", element.Key, element.Value);
        }
        
        Console.WriteLine();
        
        // Slownik, ktory moze przechowywac lanuchy jako klucze i wartosci
        // Dodanie kilka wartosci na raz za pomoca inicjalizatora kolekcji
        Dictionary<string, string> capitals = new Dictionary<string, string>
        {
            {"Poland", "Warsaw"},
            {"Russia", "Moscow"},
            {"Germany", "Berlin"}
        };
        
        foreach (var capital in capitals)
        {
            Console.WriteLine($"Country: {capital.Key} ; Capital: {capital.Value}");
        }
        
        Console.WriteLine();
        
        Dictionary<string, string> phones = new Dictionary<string, string>();
        phones.Add("+48 507 761 218", "Ja?");
        phones.Add("+48 123 456 789", "Mirek koparka");
        phones.Add("+48 653 447 223", "Zbychu budowa");
        
        foreach (var number in phones)
        {
            Console.WriteLine("Numer telefonu: {0} do {1}", number.Key, number.Value);
        }
        
        Console.WriteLine();
        
        // Dictionary<string, string> data = new Dictionary<string, string>();
        // Console.Write("Podaj ile wartosci chcesz dodac: ");
        // int n = Convert.ToInt32(Console.ReadLine());
        //
        // for (int i = 0; i < n; i++)
        // {
        //     Console.Write("Podaj klucz: ");
        //     string key = Console.ReadLine()!;
        //     Console.Write("Podaj wartosc: ");
        //     string value = Console.ReadLine()!;
        //     data.Add(key, value);
        // }
        
        Console.WriteLine();
        
        // Napisz program, który wczytuje od użytkownika ciąg znaków, próbuje przekonwertować go na liczbę całkowitą za pomocą metody TryParse, a następnie
        // wyświetla wynik na konsoli.
        // Jeśli konwersja się powiedzie, program powinien wyświetlić liczbę i informację, że jest to poprawna liczba całkowita.
        // Jeśli konwersja się nie powiedzie, program powinien wyświetlić informację, że podany ciąg znaków nie jest poprawną liczbą całkowitą.
        // Przykład: dla ciągu znaków “123” program powinien wyświetlić “123 jest poprawną liczbą całkowitą”.
        // Dla ciągu znaków “abc” program powinien wyświetlić “abc nie jest poprawną liczbą całkowitą”.
        
        string ciagZnakow;
        int liczba;
        
        Console.Write("Podaj ciiag znakow: ");
        ciagZnakow = Console.ReadLine()!;
        if (!int.TryParse(ciagZnakow, out liczba))
        {
            Console.WriteLine("Ciag znakow: {0}, nie jest prawidlowa liczba calkowita", ciagZnakow);
        }
        else
        {
            Console.WriteLine("Udalo sie przekonwertowac na liczbe calkowita, liczba wynosi: {0}", liczba);
        }
        
        Console.WriteLine();
        
        // Napisz funkcję, która przyjmuje jako argument listę liczb całkowitych i zwraca słownik, w którym kluczem jest liczba, a wartością jest jej częstotliwość
        // występowania na liście.
        // Jeśli lista jest pusta lub null, funkcja powinna zwrócić pusty słownik.
        //  Przykład: dla listy [1, 2, 3, 2, 4, 1, 5, 2] funkcja powinna zwrócić słownik {1: 2, 2: 3, 3: 1, 4: 1, 5: 1}.
        List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 1, 5, 2 };
        numbers.Add(numbers.Max() + 1);
        Dictionary<int, int> dic = Funkcja(numbers);
        
        foreach (var element in dic)
        {
            Console.WriteLine($"Cyfra {element.Key}, Ile razy: {element.Value}");
        }
    }

    private static Dictionary<int, int> Funkcja(List<int> array)
    {
        Dictionary<int, int> numbers = new Dictionary<int, int>();
        if (array.Count == 0)
        {
            return numbers;
        }

        array.Sort();
        
        int ile = 1;
        for (int i = 0; i < array.Count - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                ile++;
            }
            else
            {
                numbers.Add(array[i], ile);
                ile = 1;
            }
        }

        return numbers;
    }
}
