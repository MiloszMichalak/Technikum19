namespace wyjatki
{
    class Program{

        static void ErrorColorChange(string comment)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Błąd: {comment}");
            Console.ResetColor();
        }
        
        static void Main(string[] args)
        {
            bool flagunia = true;
            while (flagunia)
            {
                try
                {
                    System.Console.WriteLine("Podaj 2 liczby\n");
                    System.Console.Write("Podaj a: ");
                    int a = Convert.ToInt32(Console.ReadLine());
                    System.Console.Write("Podaj b:  ");
                    int b = Convert.ToInt32(Console.ReadLine());
                    // if (b == 0){
                    //     throw new Exception("Nie mozna dzielić przez 0");
                    // }
                    int result = a / b;
                    // Tekst ponizej zostanie wypisany na zielono
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine("Wynik dzielenia: " + result);
                    flagunia = false;
                    Console.ResetColor();
                }
                catch (DivideByZeroException)
                {
                    ErrorColorChange("Nie mozna dzielic przez 0");
                }
                catch (FormatException)
                {
                    // wyrzuci wtedy kiedy uzytkownik nie poda inta
                    ErrorColorChange("Blad formatu danych, podaj liczbe zmiennoprzecinkowa lub calkowita");
                }
                catch (OverflowException)
                {
                    ErrorColorChange(
                        $"Bledny zakres liczby, podaj liczbe z zakresu: <{double.MinValue} ; {double.MaxValue}>");
                }
                catch (Exception ex)
                {
                    ErrorColorChange(ex.Message);
                }
            }
        }
    }
}
