namespace Zadania;

class Program
{
    public static void Main(string[] args)
    {
        string? liczba;
        do
        {
            try
            {
                Console.WriteLine("Podaj liczbe: ");
                liczba = Console.ReadLine();
                if (liczba.Equals("q"))
                {
                    Console.WriteLine("Dziekujemy za skorzystaniew programu");
                    return;
                }
                if (Convert.ToInt32(liczba) < 1)
                {
                    throw new ArgumentOutOfRangeException("Podaj liczbe naturalna");
                }

                Console.WriteLine("Pierwiastek kwadratowy z wpisanej liczby wynosi {0}",
                    Math.Sqrt(Convert.ToInt32(liczba)));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                // Dzieki temu ze dokladnie wypisujemy nazwa bledu nie wypisuje calej dlugosci bledu
                Console.WriteLine("Blad: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Wprowadz liczbe");
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Przekoczono zakres. Zakres liczby: <{int.MinValue} ; {int.MaxValue}>");
            }
        } while (true);
    }
}
