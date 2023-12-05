namespace Zadanie_2;

class Program
{
    static void Main(string[] args)
    {
        int choice;
        
        Random random = new Random();
        List<int> ints = new List<int>();
        for (int i = 0; i < 10; i++)
        {
            ints.Add(random.Next(1, 101));
        }
        
        // tworzenie petli do wysweitlenia menu i obslugi wyboru
        do
        {
            Console.WriteLine("1. Wyswietli liczbe podzielnych przez 3 lub 5");
            Console.WriteLine("2. Wyswietl liste liczb nieparzystych");
            Console.WriteLine("3. Wyswietl liste liczb posortowanych rosnaco");
            Console.WriteLine("4. Wyswietl liste liczb posortowanych malejaco");
            Console.WriteLine("5. wyjscie z programu");

            Console.Write("Podaj swoj wybor: ");
            choice = Convert.ToInt16(Console.ReadLine());
            
            // wykonywanie zaleznie od wyboru uzytkownika
            switch (choice)
            {
                case 1:
                    List<int> podzielne = SprawdzaniePodzielnosci(ints);
                    foreach (var item in podzielne)
                    {
                        Console.Write(item + " ");
                    }
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("Wyszedles z programu");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Podaj opcje 1-5");
                    break;
            }

            Console.WriteLine();
        } while (choice != 5);
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
