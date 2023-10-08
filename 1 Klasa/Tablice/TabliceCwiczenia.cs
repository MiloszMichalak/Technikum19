using System;
namespace Program{
    
    class Tablice{

        public static void wypiszTablice(int[] T){
                foreach (var siema in T){
                Console.Write(siema + " ");
            }
        }

        public static void Zadanie1(){
            // *Wygeneruj tablice z 15 losowymi liczbami dwucyfrowymi nieparzystymi
            Random r = new Random();
            int[] T = new int[15];
            int i = 0;
            while (i < 15){
                int losowa = r.Next(10, 99);
                if (losowa % 2 == 1){
                    T[i] = losowa;
                    i++;
                }
            }
            wypiszTablice(T);
        }

        public static void Zadanie2(){
            // *Wygeneruj tablice 20 dowolych liczb dwucyfrowych i potem zaokraglij kazda w gore do polnej dziesiatki
            Random r = new Random();
            for (int i = 0; i < 20; i++){
                int cos = r.Next(10, 99);
                if (cos % 10 != 0){
                    int dz = (int) cos / 10;
                    dz = (dz * 10) + 10;
                    Console.WriteLine(cos + " " + dz);
                } else{
                    Console.WriteLine(cos + " " + cos);
                }
            }   
        }

        public static void Zadanie3(){
            // *Wygeneruj list 12 losowych liczb dwucyfrowych podzielnych przez 7
            Random r = new Random();
            int[] T = new int[12];
            int i = 0;
            while (i < 12){
                int losowa = r.Next(10, 99);
                if (losowa % 7 == 0){
                    T[i] = losowa;
                    i++;
                }
            }
            wypiszTablice(T);
        }

        public static void Main(string[] args){
            Zadanie1();
            Console.WriteLine("\n");
            Zadanie2();
            Console.WriteLine("\n");
            Zadanie3();
        }
    }
}