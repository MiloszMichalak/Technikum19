namespace Zadanie2;

class Program
{
    public static void Main(string[] args)
    {
        string? liczba = "0";
        int ile = 0;
        int[] array = new int[5];
        while (ile < 5)
        {
            try
            {
                Console.Write("Podaj liczbe: ");
                liczba = Console.ReadLine();
                array[ile] = Convert.ToInt32(liczba);
                ile++;

            }
            catch (FormatException)
            {
                Console.WriteLine("Powinienes podac liczbe");
            }
            catch (OverflowException)
            {
                Console.WriteLine(
                    $"Podales za duza liczbe, powinienes poddac liczbe z zakresu <{int.MinValue} ; {int.MaxValue}>");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Blad {ex.Message}");
            }
        }

        Console.WriteLine();

        while (true)
        {
            try
            {
                Console.Write("Podaj jaki chcesz wyswietlic index z tablicy: ");
                string miejsce = Console.ReadLine();
                if (miejsce.Equals("q"))
                {
                    return;
                }
                Console.WriteLine($"array[{miejsce}] = {array[Convert.ToInt32(miejsce)]}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Blad: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Powinienes podac liczbe");
            }
            catch (OverflowException)
            {
                Console.WriteLine(
                    $"Podales za duza liczbe, powinienes poddac liczbe z zakresu <{int.MinValue} ; {int.MaxValue}>");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Blad {ex.Message}");
            }
        }
    }
}