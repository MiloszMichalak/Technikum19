namespace Praca_na_lekcji___wyjatki
{
    class Program
    {
        public static void Main(String[] args)
        {
            // Grupa 1
            // Napisz program ktory oblicza pole prostokata
            bool flaga = true;
            while (flaga)
            {
                try
                {
                    Console.WriteLine("Podaj 2 boki:\n");
                    Console.Write("Podaj bok 1: ");
                    double bok1 = double.Parse(Console.ReadLine()!);
                    Console.Write("Podaj bok 2: ");
                    double bok2 = double.Parse(Console.ReadLine()!);
                    if (!(bok1 > 0) || !(bok2 > 0))
                    {
                        throw new Exception("Podane boki powinny byc dodatnie");
                    }
                    Console.WriteLine();
                    flaga = false;
                    double wynik = bok1 * bok2;
                    Console.WriteLine("Pole prostokata wynosi: {0}", wynik);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Podaj liczbe zmiennoprzecinkowa lub calkowita");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Podana liczba jest za duza dla danego typu, podaj liczbe z zakresu <{double.MinValue} ; {double.MaxValue}>");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Blad: {ex.Message}");
                }
            }
        }
    }
}