using System;

namespace Program;
class SprawdzanieBokowTrojkata
{

   // funkcja ktora sprawdza czy z podanych bokow mozna stworzyc trojkat
   private static bool SprawdzanieNierownosciTrojkata(double a, double b, double c)
   {
      if (a + b > c && b + c > a && c + a > b)
      {
         return true;
      }
      else
      {
         return false;
      }
   }

   // Funkcja obliczajaca wzor herona czyli pole trojkata
   private static double WzorHerona(double a, double b, double c)
   {
      double p = (a + b + c) / 2;
      return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
   }

   public static void Main(string[] args)
   {
      double a, b, c;
      bool isCorrect = false;
      do
      {
         System.Console.Write("Podaj a: ");
         // dopoki user nie poda prawidlowego inputa(liczba lub wieksza od 0) bedzie mu kazac wpisac liczbe
         while (!double.TryParse(Console.ReadLine(), out a) || a <= 0){
            System.Console.Write("Wpisz prawidlowe dane: ");
         }

         System.Console.Write("Podaj b: ");
         while (!double.TryParse(Console.ReadLine(), out b) || b <= 0){
            System.Console.Write("Wpisz prawidlowe dane: ");
         }

         System.Console.Write("Podaj c: ");
         while (!double.TryParse(Console.ReadLine(), out c) || c <= 0){
            System.Console.Write("Wpisz prawidlowe dane: ");
         }

         // Sprawdzanie czy z podanych bokow mozna stworzyc trojkat
         // Przy indexie zmiennej suffix :F4 ogranicza zmienna z przecinkiem do 4 miejsc po przecinku
         // na windowsie powinien tutaj console encoding byc zmieniony
         if (SprawdzanieNierownosciTrojkata(a, b, c)){
            System.Console.WriteLine("Z bokow {0}, {1}, {2} da sie stworzyc trojkat, a jego pole wynosi: {3:F4} cm\u00B2", a, b, c, WzorHerona(a, b, c));
            isCorrect = true;
         } else{
            System.Console.WriteLine("Z bokow {0}, {1}, {2} nie da sie stworzyc trojkata", a, b, c);
            // Thread dziala jak sleep w pythonie czyli po 2000ms czyli 2s wyczysci sie konsola
            Thread.Sleep(2000);
            Console.Clear();
         }

      } while (!isCorrect);
   }
}
