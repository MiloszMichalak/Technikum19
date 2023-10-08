using System;


class Lekcja{

    public static int SumaCyfr(int a){
        int suma = 0;
        while (a > 0){
            suma += a % 10;
            a /= 10;
        }
        return suma;
    }

    public static string OdwrotNapisu(string napis){
        char[] C = napis.ToCharArray();
        Array.Reverse(C);
        string wynik = new string(C);
        return wynik;
    }

    public static string PolowkiLiczby(int x){
        string wynik = "";
        while (x > 1){
            wynik += x/2 + "-";
            x /= 2;
        }
        return wynik;
    }

    public static int rerekumkum1(int x){
        if (x == 1){
            return 3;
        } else {
            return rerekumkum1(x - 1) + 2;
        }
    }

    public static int rerekumkum2 (int y){
        if (y == 1){
            return 6;
        } else {
            return rerekumkum2(y - 1) * 2;
        }
    }

    public static int rerekumkum3 (int z){
        if (z == 1 || z == 2){
            return 1;
        }
        return 2 * rerekumkum3(z - 2) + rerekumkum3(z - 1);
    }

    public static int rerekumkum5(int a){
        if (a == 1) return 1;
        if (a == 2) return 2;
        if (a == 3) return 3;
        return 3 * rerekumkum5(a - 3) - rerekumkum5(a - 1);
    }

    public static void Main(string[] args){
        System.Console.WriteLine("Zadanie 1");
        System.Console.WriteLine(SumaCyfr(123));

        System.Console.WriteLine("\nZadanie 2");
        System.Console.WriteLine(OdwrotNapisu("Siema"));

        System.Console.WriteLine("\nZadanie 3");
        PolowkiLiczby(30);

        System.Console.WriteLine("\nReReKumKum\n");
        int ile = int.Parse(System.Console.ReadLine());
        for (int i = 1; i < ile; i++){
            System.Console.WriteLine(rerekumkum1(i));
        }

        System.Console.WriteLine("\nZadanie 2");
        for (int i = 1; i < ile; i++) {
            System.Console.WriteLine(rerekumkum2(i));
        }

        System.Console.WriteLine("\nZadanie 3");
        for (int i = 1; i < ile; i++) {
            rerekumkum3(i);
        }
    }
}
