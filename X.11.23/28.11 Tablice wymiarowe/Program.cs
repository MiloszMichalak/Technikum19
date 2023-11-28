namespace _28._11_Tablice_wymiarowe;

class Program
{
    static void Main(string[] args)
    {
        
        // tablice 2 wymiarowe
        
        int[,] ints = new int[4, 3];
        
        // Funckja rank wypisuje ilu wymiarowa jest tablica
        Console.WriteLine(ints.Rank); //2
        Console.WriteLine(ints.GetLength(0)); // 4
        Console.WriteLine(ints.GetLength(1)); // 3

        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                Console.Write($"ints[{i}, {j}] {ints[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\n");
        
        // Tablice 3 wymiarowe

        int[,,] cubs = new int[4,3,2];
        
        for (int i = 0; i < cubs.GetLength(0); i++)
        {
            Console.WriteLine($"cubs[{i}]");
            for (int j = 0; j < cubs.GetLength(1); j++)
            {
                Console.WriteLine($"\tcubs[{i}, {j}]");
                for (int k = 0; k < cubs.GetLength(2); k++)
                {
                    Console.WriteLine($"\t\tcubs[{i}, {j}, {k}] {cubs[i, j, k]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
