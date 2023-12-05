namespace _5._12_Listy;

class Program
{
    public static void Main(string[] args)
    {
        // tworzenie listy liczb calkowitych
        List<int> list = new List<int>();

        // tworzenie list cakowitych z poczatkowymi elementami, uzywajac inicjalizatora kolekcji
        List<int> list2 = new List<int>() { 1, 2, 3, 10, -2, 5, -2 };

        // dodawanie elementow do listy za pomoca metody Add
        list2.Add(4); // 1 2 3 10 -2 5 -2 4

        // usuwanie konkretnego elementu z listy za pomoca metody Remove
        // jesli sa duplikaty to usuwa pierwszy element od lewej danego typu
        list2.Remove(-2); // 1 2 3 10 5 -2 4 

        // wyswietlanie dlugosci tablicy za pomoca wlasciwosci Count
        Console.WriteLine($"Dlugosc tablicy: {list2.Count}");

        // Wyswietlanie listy za pomoca foreacha
        foreach (var element in list2)
        {
            Console.Write(element + " ");
        }

    }

}
