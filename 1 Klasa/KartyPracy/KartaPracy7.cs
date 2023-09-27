using System;
using System.Collections;

namespace KartaPracy7{

    public class Operacje{
        public static int[] losowanieTablicy(){
            Random random = new Random();
            int[] T = new int[40];
            for (int i = 0; i < T.Length; i++) {
                T[i] = random.Next(10, 99);
            }
            return T;
        }

        public static void wypiszTablice(int[] T){
            foreach (var element in T){
                Console.Write(element + " ");
            }
        }

        public static int szukanieMaxa(int[] T){
            int maks = T[0];
            foreach (var element in T) {
                if (element > maks){
                    maks = element;
                }
            }
            return maks;
        }

        public static int szukanieMina(int[] T){
            int mini = T[0];
            foreach (var element in T) {
                if (element < mini){
                    mini = element;
                }
            }
            return mini;
        }
    }


    public class Zadania{
        public static int Zadanie1(int[] T){
            return Operacje.szukanieMaxa(T);
        }

        public static int Zadanie2(int[] T){
            return Operacje.szukanieMina(T);
        }

        public static int Zadanie3(int[] T){
            return Operacje.szukanieMaxa(T) - Operacje.szukanieMina(T);
        }

        public static int Zadanie4(int[] T){
            int vMax = T[0];
            foreach (var element in T) {
                if (element < Operacje.szukanieMaxa(T) && element > vMax){
                    vMax = element;
                }
            }
            return vMax;
        }

        public static int Zadanie5(int[] T){
            int vMin = T[0];
            foreach (var element in T) {
                if (element > Operacje.szukanieMina(T) && element < vMin){
                    vMin = element;
                }
            }
            return vMin;
        }

        public static int Zadanie6(int[] T){
            int ile = 0;
            foreach (var element in T) {
                if (element == Operacje.szukanieMaxa(T)){
                    ile++;
                }
            }
            return ile;
        }

        public static int Zadanie7(int[] T){
            int ile = 0;
            foreach (var element in T) {
                if (element == Operacje.szukanieMina(T)){
                    ile++;
                }
            }
            return ile;
        }

        public static int Zadanie8(int[] T){
            int input = int.Parse(Console.ReadLine());
            int ile = 0;
            foreach (var element in T) {
                if (element == input){
                    ile++;
                }
            }
            return ile;
        }

        public static double Zadanie9(int[] T){
            int suma = 0;
            foreach (var element in T) {
                suma += element;
            }
            double avg = suma / T.Length;
            return Math.Round(avg, 1);
        }

        public static int Zadanie10(int[] T){
            int suma = 0;
            for (int i = 0; i < 40;i++) {
                if (i % 2 == 0){
                    suma += T[i];
                }
            }
            return suma;
        }

        public static double Zadanie11(int[] T){
            int suma = 0;
            for (int i = 0; i < 40;i++) {
                if (i % 2 != 0){
                    suma += T[i];
                }
            }
            double avg = suma / T.Length;
            return Math.Round(avg, 2);
        }
        
        public static int Zadanie12(int[] T){
            int ilosc = 0;
            foreach (var element in T) {
                int ile = 0;
                for (int i = 10; i < 100; i++) {
                    if (element == i){
                        ile++;
                    }
                }
                if (ile == 1){
                    ilosc++;
                }
            }
            return ilosc;
        }

        public static double Zadanie14(int[] T){
            double zwrot = 0;
            foreach (var element in T){
                int ile = 0;
                for (int i = 10; i < 100; i++){
                    if (element == i){
                        ile++;
                    }
                }
                if (ile > 1){
                    double ilosc = ile / 2;
                    zwrot = Math.Round(ilosc, MidpointRounding.ToEven);
                }
            }
            return zwrot;
        }


    }


    public class Program{

        public static void Main(string[] args){
            int[] T = Operacje.losowanieTablicy();
            Operacje.wypiszTablice(T);
            Console.WriteLine("\n");

            Console.WriteLine("Zadanie 1");
            Console.WriteLine(Zadania.Zadanie1(T));

            Console.WriteLine("Zadanie 2");
            Console.WriteLine(Zadania.Zadanie2(T));

            Console.WriteLine("Zadanie 3");
            Console.WriteLine(Zadania.Zadanie3(T));
            
            Console.WriteLine("Zadanie 4");
            Console.WriteLine(Zadania.Zadanie4(T));

            Console.WriteLine("Zadanie 5");
            Console.WriteLine(Zadania.Zadanie5(T));

            Console.WriteLine("Zadanie 6");
            Console.WriteLine(Zadania.Zadanie6(T));

            Console.WriteLine("Zadanie 7");
            Console.WriteLine(Zadania.Zadanie7(T));

            Console.WriteLine("Zadanie 8");
            Console.WriteLine(Zadania.Zadanie8(T));

            Console.WriteLine("Zadanie 9");
            Console.WriteLine(Zadania.Zadanie9(T));

            Console.WriteLine("Zadanie 10");
            Console.WriteLine(Zadania.Zadanie10(T));

            Console.WriteLine("Zadanie 11");
            Console.WriteLine(Zadania.Zadanie11(T));

            Console.WriteLine("Zadanie 12");
            Console.WriteLine(Zadania.Zadanie12(T));
            
            /* TODO zadanie 13*/

            System.Console.WriteLine("Zadanie 14");
            System.Console.WriteLine(Zadania.Zadanie14(T));
        }
    }
}