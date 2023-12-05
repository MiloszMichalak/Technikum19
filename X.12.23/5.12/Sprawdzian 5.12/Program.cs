namespace _5._12_Sprawdzian;

class Program
{
    static void Main(string[] args)
    {
        // Sprawdzian grupa 2 - do kazdej zmiennej dopisuje 2
        // Napisz program, który:
        //
        // Definiuje funkcję UtworzTabliceLiczb(int n), która przyjmuje jako parametr liczbę całkowitą n i zwraca tablicę jednowymiarową o długości n,
        // wypełnioną liczbami z zakresu od 1 do 10, które podaje użytkownik z klawiatury
        
        // Definiuje funkcję ObliczPole(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość pola kwadratu o boku a. Wzór na pole
        // kwadratu to:
        // P=a2
        //
        // Definiuje funkcję ObliczObwod(int a), która przyjmuje jako parametr liczbę całkowitą a i zwraca wartość obwodu kwadratu o boku a. Wzór na obwód
        // kwadratu to:
        // O=4a
        //
        // W funkcji Main:
        // Deklaruje zmienną n i przypisuje jej wartość 5.
        // Wywołuje funkcję UtworzTabliceLiczb(n) i przypisuje jej wynik do zmiennej tablica.
        // Wyświetla na ekranie zawartość tablicy tablica.
        //
        // Dla każdego elementu tablicy tablica:
        // Wywołuje funkcję ObliczPole i przypisuje jej wynik do zmiennej pole.
        // Wywołuje funkcję ObliczObwod i przypisuje jej wynik do zmiennej obwod.
        // Wyświetla na ekranie informację o polu i obwodzie kwadratu o boku równym danemu elementowi tablicy.
        
        // Napisz funkcję, która umożliwia podanie w parametrze indeksu tablicy a następnie zwróci ona wynik pola i obwodu kwadratu

        int n2 = 5;
        int[] tablica2 = UtworzTabliceLiczb2(n2);

        Console.WriteLine("Zawartosc tablicy tablica");
        for (int i2 = 0; i2 < tablica2.Length; i2++)
        {
            GetInfo2(tablica2[i2], i2);
        }
        
        GetInfoFromSpecifiedIndex2(tablica2);
    }

    private static void GetInfoFromSpecifiedIndex2(int[] tablica2)
    {
        while (true)
        {
            try
            {
                Console.Write("Podaj index: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                GetInfo2(tablica2[n2], n2);
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Podaj inta z zakresu: <{int.MinValue};{int.MaxValue}>");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Podaj inta");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Podaj index pomiedzy: <0;{tablica2.Length - 1}>");
            }
            catch (Exception ex2)
            {
                Console.WriteLine($"Blad: {ex2.Message}");
            }

            Console.WriteLine();
        }
    }

    private static void GetInfo2(int item2, int index2)
    {
        Console.WriteLine($"Dla elementu tablica2[{index2}] = {item2}");
        Console.WriteLine($"Obwod wynosi: {ObliczObwod2(item2)}");
        Console.WriteLine($"Pole wynosi: {ObliczPole2(item2)}");
        Console.WriteLine();
    }
    
    private static int[] UtworzTabliceLiczb2(int n2)
    {
        int[] tab2 = new int[n2];
        int ile2 = 0;
        int number2;
        while (ile2 < tab2.Length)
        {
            Console.Write($"Podaj wartosc dla tab2[{ile2}]: ");
            while (!int.TryParse(Console.ReadLine(), out number2) && number2 < 1 || number2 > 10)
            {
                Console.Write("Podaj inta z zakresu <1;10>: ");
            }
            tab2[ile2] = number2;
            ile2++;
        }
        return tab2;
    }

    private static int ObliczPole2(int a2)
    {
        return a2 * 2;
    }

    private static int ObliczObwod2(int a2)
    {
        return a2 * 4;
    }
    
}
