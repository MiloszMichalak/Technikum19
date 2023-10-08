using System;
using System.Collections;
// ZWYKLE METODY
namespace Program{
    public class nauka{

        // ZWYKLE METODY

        public static void przywitaj(){
            Console.WriteLine("Siema");
        }

        //Metoda obliczajaca sume 2 podanych liczb
        public static int sumowanie(int a, int b){
            return a + b;
        }

        //metoda odwracajaca stringa

        public static string odwrocString(string str){
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        //metoda, ktora przyjmuje dowolna liczbe argumentow
        public static int sumaWszystkiego(params int[] args) {
            int suma = 0;
            foreach (int arg in args){
                suma += arg;
            }
            return suma;
        }

            //Pokazanie rekurencji 
            //metoda nieskonczona
            public static void PetlaRekurencyjna(){
                PetlaRekurencyjna();
            }
            

            public static void Main(String[] args) {
            przywitaj();
            Console.WriteLine(sumowanie(1,2));
            Console.WriteLine(odwrocString("kot"));
            Console.WriteLine(sumaWszystkiego(1, 2, 3));
            System.Console.WriteLine("\n" + "REKURENCJA" + "\n");
            PetlaRekurencyjna();
        }
    }
}

/*
1
2
6




*/