using System.Runtime.InteropServices;
using System;
using System.IO;
using System.Collections;

class Lekcja
{
    public static bool czyPierwsza(int n){
        for (int i = 2; i < (int)Math.Sqrt(n) / 2; i++) {
            if (n % i == 0 ){
                return false; 
            }
        }
        return false;
    }


    public static void Main(string[] args)
    {
        StreamWriter streamWriter = new StreamWriter(@"odpowiedzi/odp_przyklad.txt");
        StreamReader streamReader = new StreamReader(@"zalaczniki/przyklad.txt");
        ArrayList list = new ArrayList();
        while (!streamReader.EndOfStream){
            list.Add(streamReader.ReadLine());
        }

        int[] L = new int[list.Count]; // * Jest to tablica numerow z poczatku kazdej lini
        string[] N = new string[list.Count]; // * Jest to tablica z wyrazami za numerkami z poczatku

        int k = 0;
        foreach (string item in list){
            string[] Linia = item.Split(" ");
            L[k] = Convert.ToInt32(Linia[0]);
            N[k] = Linia[1];
            k++;
        }

        for (int i = 0; i < L.Length; i++) {
            if (L[i] > 4 && L[i] % 2 == 0){
                for (int j = 3; j < L[i]; j++){
                    if (czyPierwsza(j) && czyPierwsza(L[i] - j)){
                        streamWriter.Write($"{L[i]} {j} {L[i]-j}");
                        break;
                    }
                }
            }
        }
        


    }
}