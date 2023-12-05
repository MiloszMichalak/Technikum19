namespace Zadanie_1;

class Program
{
    static void Main(string[] args)
    {
        // Zadanie
        // •	Utwórz listę liczb całkowitych i wypełnij ją losowymi wartościami z zakresu od 1 do 100.
        // •	Napisz metodę, która przyjmuje jako parametr listę liczb i zwraca listę liczb, które są podzielne przez 3 lub 5.
        // •	Wyświetl na konsoli listę liczb losowych i listę liczb podzielnych przez 3 lub 5.
        Console.WriteLine("=== Zadanie ===");

        Random random = new Random();
        List<int> ints = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            ints.Add(random.Next(1, 101));
        }

        Console.WriteLine("Lista z randomami");
        foreach (var item in ints)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n\nLista z sprawdzonymi randomami");
        foreach (var item in SprawdzaniePodzielnosci(ints))
        {
            Console.Write(item + " ");
        }
    }

    private static List<int> SprawdzaniePodzielnosci(List<int> list)
    {
        List<int> podzielne = new List<int>();
        foreach (var element in list)
        {
            if (element % 3 == 0 || element % 5 == 0)
            {
                podzielne.Add(element);
            }
        }

        return podzielne;
    }
}
