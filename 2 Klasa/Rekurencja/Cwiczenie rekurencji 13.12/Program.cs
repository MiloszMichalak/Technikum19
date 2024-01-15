using System.IO.Pipes;

namespace Cwiczenie_rekurencji_13._12;

class Program
{
    static void Main(string[] args)
    {
        // 1. Zapisz iteracyjnie i rekurencyjnie obliczanie sumy kodów ASCII wpisanego przez usera słowa
        string input = Console.ReadLine()!;
        int suma = 0;
        foreach (char litera in input)
        {
            suma += litera;
        }

        Console.WriteLine(suma);
        Console.WriteLine(reku1(input));
    }

    public static int reku1(string input)
    {
        // idk co tutaj sie ma dziac
        if (input == "") return 0;
        return reku1(input.Substring(1)) + input[0];
    }
}
