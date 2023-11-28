namespace _28._11_Tablice_wymiarowe;

using System;
using System.Threading;

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

        int[,] M2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        for (int i = 0; i < M2.GetLength(0); i++)
        {
            for (int j = 0; j < M2.GetLength(1); j++)
            {
                Console.Write($"{i}{j}");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("M3: ");
        Console.WriteLine();

        double[,,] M3 = new double[,,] { { { 1.0, 2.0, 3.0 }, { 4.0, 5.0, 6.0 } }, { { 7.0, 8.0, 9.0 }, { 10.0, 11.0, 12.0 } } };

        for (int i = 0; i < M3.GetLength(0);i++)
        {
            for(int j = 0; j < M3.GetLength(1); j++)
            {
                for (int k = 0; k < M3.GetLength(2); k++)
                {
                    Console.Write($"{i} {j} {k}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        
        
        // Zadanie 
        /*Napisz program w języku C#, który realizuje następujące funkcjonalności:

Program wczytuje z klawiatury liczbę n i tworzy tablicę dwuwymiarową o wymiarach n x n.
Program wypełnia tablicę liczbami losowymi z zakresu od 1 do 100 i wyświetla jej zawartość na ekranie.
Program oblicza i wyświetla sumę elementów na głównej przekątnej tablicy.
Program posiada menu, które umożliwia użytkownikowi wybór jednej z pięciu funkcji statycznych, które realizują poszczególne kroki zadania. Menu jest wyświetlane na początku programu i po każdym wykonaniu funkcji. Menu ma następującą postać:
Wybierz funkcję statyczną:
1.WczytajLiczbe
2.UtworzTablice
3.WypelnijTablice
4.WyswietlTablice
5.ObliczSume

Funkcja WczytajLiczbe wczytuje liczbę z klawiatury i zwraca ją jako wartość typu int. Funkcja sprawdza, czy podana wartość jest poprawną liczbą dodatnią i w razie błędu wyświetla komunikat i prosi o ponowne wprowadzenie danych. Funkcja umożliwia również zakończenie programu przez wpisanie litery q.
Funkcja UtworzTablice tworzy tablicę dwuwymiarową o podanych wymiarach i zwraca ją jako wartość typu int[,].Funkcja wczytuje liczbę wierszy i kolumn tablicy za pomocą funkcji WczytajLiczbe i wyświetla informację o utworzeniu tablicy.
Funkcja WypelnijTablice wypełnia tablicę liczbami losowymi z podanego zakresu i zwraca ją jako wartość typu int[,].Funkcja wczytuje dolną i górną granicę zakresu liczb losowych za pomocą funkcji WczytajLiczbe i sprawdza, czy użytkownik ma już utworzoną tablicę. Jeśli nie, funkcja prosi go o utworzenie tablicy za pomocą funkcji UtworzTablice. Funkcja wyświetla informację o wypełnieniu tablicy.
Funkcja WyswietlTablice wyświetla zawartość tablicy na ekranie i nie zwraca niczego (void). Funkcja sprawdza, czy użytkownik ma już utworzoną i wypełnioną tablicę. Jeśli nie, funkcja prosi go o utworzenie i wypełnienie tablicy za pomocą funkcji UtworzTablice i WypelnijTablice.
Funkcja ObliczSume oblicza sumę elementów na głównej przekątnej tablicy i zwraca ją jako wartość typu int. Funkcja sprawdza, czy użytkownik ma już utworzoną i wypełnioną tablicę. Jeśli nie, funkcja prosi go o utworzenie i wypełnienie tablicy za pomocą funkcji UtworzTablice i WypelnijTablice. Funkcja wyświetla wartość sumy na ekranie.
*/

        
        static void Main(string[] args)
        {
            #region code
            int n = WczytajLiczbe();
            int[,] M = UtworzTablice(n);
            WypelnijTablice(M, n);
            WyswietlTablice(M, n);
            int suma = ObliczSume(M, n);
            Console.WriteLine("Suma elementów na przekątnej Tablicy wynosi: " + suma);

            Console.ReadKey();
            #endregion
        }

        static int WczytajLiczbe()
        {
            int number;
            while (true)
            {
                Console.WriteLine("Podaj Liczbę n: ");
                string input = Console.ReadLine();

                if (input == "q")
                {
                    Console.WriteLine("Zakończono Program");
                    Thread.Sleep(1000);
                    Environment.Exit(0);
                }
                
                bool success = int.TryParse(input, out number);

                if (success && number > 0)
                {
                    return number;
                }
                else
                {
                    Console.WriteLine("Podana wartość nie jest poprawną liczbą dodatnią. Spróbuj ponownie lub wpisz q, aby zakończyć program: ");
                }
            }
        }

        static int[,] UtworzTablice(int n)
        {
            return new int[n, n];
        }

        static int[,] WypelnijTablice(int[,] M, int n)
        {
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = r.Next(1, 100);
                }
            }
            return M;
        }

        static void WyswietlTablice(int[,] M, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static int ObliczSume(int[,] M, int n)
        {
            int suma = 0;
            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    suma += M[i, j];
                }
            }
            return suma;
        }
    }
}
