using System;

// Algorytm na hornera
// int Horner(int system, string liczba)
// {
//     // Podaje sie -48 ze 1 w ascii = 49 wiec jak sie odejmie od tego to z acsii jedynki(49) zrobi sie 1
//     int wynik = liczba[0] - 48;
//     for (int i = 0; i < liczba.Length - 1; i++)
//     {
//         int temp = wynik;
//         wynik = system * temp + liczba[i + 1] - 48;
//     }
//     return wynik;
// }
//
// System.Console.Write("Podaj system w jakim podasz liczbe: ");
// int system = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Podaj liczbe która chcesz zamienic na system dziesietny: ");
// string liczba = Console.ReadLine();
//
// System.Console.WriteLine("W dziesietnym ta liczba wynosi: {0}", Horner(system ,liczba));

// Konwersja BIN => DEC oraz DEC => BIN
// Odwraca stringa zeby potegi i index sie zgadzaly bo jak sie nie odwroci to z 011 0 - 0, 1 - 1, 1 - 2 i wdziala to na odwrot 
// bo ostatni jest najwiekszy a jak sie odwroci to jest 1 - 0, 1 - 1, 0 - 2
int binToDec(string liczba)
{
    char[] liczbaReversed = liczba.ToCharArray();
    Array.Reverse(liczbaReversed);
    string liczba2 = new string(liczbaReversed);
    int suma = 0;
    for (int i = 0; i < liczba2.Length; i++)
    {
        if ((int)liczba2[i] - 48 == 1)
        {
            suma += (int)Math.Pow(2, i);
        }
    }
    return suma;
}

System.Console.WriteLine(binToDec(("011")));

string decToBin(int liczba)
{
    string wyjscie = "";
    while (liczba > 0)
    {
        wyjscie = liczba % 2 + wyjscie;
        liczba = liczba / 2;
    }
    return wyjscie;
}

System.Console.WriteLine(decToBin(3));

// Liczba decymalna do binarki rekurencyjnie
void decToBinReku(int liczba)
{
    if (liczba == 0) return;
    decToBinReku(liczba / 2);
    System.Console.Write(liczba % 2);
}

decToBinReku(4);
