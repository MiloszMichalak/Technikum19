// Implementowanie tablicy intow - z przypisanymi wartosciami

using System.Runtime.InteropServices;
using System.Threading.Channels;

int[] tab = {1, 2, 3, 4, 5, 6};

// wypisuje to ostatnia liczbe z tablicy
Console.WriteLine(tab[^1]);

// Deklaracja tablicy
int[] tab2 = new int[2];
tab2[0] = 2;
tab2[1] = 1;

// Zadanie
// Napisz proram, który pobiera od uzytkownika 5 liczb calkowitych i zapisuje je w tablicy, Natepnie program wyswietla sume
// wszystkich elementow w tablicy
// Console.WriteLine("Zadanie 1");
//
// int[] zadania = new int[5];
// int temp = 0;
// int liczba;
//
// while (temp < 5)
// {
//         Console.Write($"Podaj cyfre {temp + 1}: ");
//         while (!int.TryParse(Console.ReadLine(), out liczba))
//         {
//             Console.Write("Podaj prawidlowe wejscie: ");
//         }
//         zadania[temp] = liczba;
//         temp++;
// }
//
// int suma = 0;
// foreach (int item in zadania)
// {
//     suma += item;
// }
//
// Console.WriteLine($"Suma wszystkich liczb w tablicy wynosi: {suma}");

// Sposob z try catch
// int[] zadania = new int[5];
// int temp = 0;
//
// while (temp < 5)
// {
//     try
//     {
//         Console.Write($"Podaj cyfre {temp + 1}: ");
//         zadania[temp] = Convert.ToInt32(Console.ReadLine());
//         temp++;
//     }
//     catch (FormatException)
//     {
//         Console.WriteLine("Miales podac inta");
//     }
//     catch (ArgumentOutOfRangeException)
//     {
//         Console.WriteLine($"Podales za duza liczbe, powinines podac liczbe z przedzialu <{int.MinValue} ; {int.MaxValue}>");
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine($"Blad: {ex.Message}");
//     }
// }
//
// int suma = 0;
// foreach (int item in zadania)
// {
//     suma += item;
// }
//
// Console.WriteLine($"Suma wszystkich liczb w tablicy wynosi: {suma}");

Console.WriteLine("\nZadanie 2");
// Napisz program, który pobiera od użytkownika 5 liczb całkowitych i zapisuje je w tablicy, a następnie wyświetla sumę wszystkich elementów tablicy.
//     Zadeklaruj tablicę o rozmiarze 5 i nazwij ją numbers.
//     Użyj pętli for, aby pobrać od użytkownika 5 liczb całkowitych i zapisać je w tablicy numbers.

//     Wyświetl na ekranie komunikat, który prosi użytkownika o podanie kolejnej liczby całkowitej i użyj metody GetIntegerFromUser(), aby ją pobrać i zweryfikować.
//     Zdefiniuj metodę GetIntegerFromUser(), która przyjmuje od użytkownika liczbę całkowitą i zwraca ją. Jeśli użytkownik wprowadzi niepoprawną wartość, metoda wyświetli stosowny komunikat i poprosi o ponowne wprowadzenie liczby.
//     Użyj metody int.TryParse(), aby sprawdzić, czy wprowadzona wartość jest poprawną liczbą całkowitą i przypisać ją do zmiennej input.

//     Zdefiniuj metodę CalculateSum(int[] numbers), która przyjmuje tablicę liczb całkowitych i zwraca ich sumę.
//     Użyj pętli foreach, aby dodać do sumy każdy element tablicy numbers i zwrócić sumę.
//     Wywołaj metodę CalculateSum(numbers) i przypisz jej wynik do zmiennej sum.
//     Wyświetl na ekranie komunikat, który pokazuje sumę podanych liczb.

int[] numbers = new int[5];
for (int i = 0; i < 5; i++)
{
    numbers[i] = GetIntegerFromUser();
}

int sum = CalculateSum(numbers);
Console.WriteLine($"Suma liczb w tablicy wynosi: {sum}");

static int GetIntegerFromUser()
{
    int input;
    Console.Write("Podaj liczbe: ");
    while (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.Write("Podaj prawidlowe wejscie: ");
    }

    return input;
}

static int CalculateSum(int[] array)
{
    int suma = 0;
    foreach (int item in array)
    {
        suma += item;
    }
    return suma;
}

