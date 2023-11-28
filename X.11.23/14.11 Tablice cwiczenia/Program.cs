namespace _14._11_Tablice_cwiczenia;

class Program
{
    public static void Main(string[] args)
    {
        int[] array = CreateArray();
        DisplayArray(array);
        SetArray(array);
        DisplayArray(array);
    }

    // funkcja statyczna, która pozwala wprowadzić rozmiar tablicy i nazwę CreateArray()
    private static int[] CreateArray()
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int size = 0;
        try
        {
            size = Convert.ToInt32(Console.ReadLine());
            if (size < 1)
            {
                throw new ArgumentException("Rozmiar tablicy musi byc powyzej 0");
            }
        }
        catch (ArgumentException ex) 
        {
            Console.WriteLine($"Blad: {ex.Message}");
        }
        
        int[] array = new int[size];
        return array;
    }
    
    // funkcja statyczna, która ustawia elementy tablicy SetArray()
    private static void SetArray(int[] array)
    {
        int number;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Podaj cyfre do tablicy: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.Write("Podaj int: ");
            }
            array[i] = number;
        }
    }
    
    // funkcja statyczna, która wyświetla zawartość tablicy DisplayArray()
    private static void DisplayArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.WriteLine(item);
        }
    }
}

