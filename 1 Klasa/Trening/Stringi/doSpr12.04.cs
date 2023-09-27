using System.Collections.ObjectModel;
using System;
using System.Collections;

class Lekcja{
    //Napisz funckje ktora oblicza srednia arytmetyczna dwoch wpisanych liczb
    public static double avg(int a, int b) {
        double x = (double) a;
        double y = (double) b;
        return (x + y) / 2;
    }


    // TODO Napisz funkcje rekurencyjna wypisujaca ciag: 1, 2, 3, 3, 4, 3, 5, 3, 7

    


    // TODO Zapisz do pliku 20 różnych liczb dwucyfrowych. Otwórz plik i wpisz wszystkie te liczby, których suma cyfr wynosi 10


    public static void Main(string[] args){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Srednia 2 liczb");
        System.Console.WriteLine(avg(a, b));
        System.Console.WriteLine("\n");
        System.Console.WriteLine("Ciag Belgijski");
        ArrayList sequence = GenerateSequence(9);
        foreach (int i in sequence){
            System.Console.WriteLine(i);
        }
    }
}