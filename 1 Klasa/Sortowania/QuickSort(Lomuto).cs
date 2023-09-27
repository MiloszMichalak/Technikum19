using System;

namespace Program{
    class SortowaniePrzezWybor{

        public static void QuickSortLomuto(int[] T, lewy prawy){
            System.Console.WriteLine("TODO");
        }

        public static void Main(string[] args){
            // Generowanie losowej tablicy
            Random random = new Random();
            int[] array = new int[20];
            for (int i = 0; i < 20; i++){
                array[i] = random.Next(1, 100);
            }

            // Wypisywanie nie posortowanej tablicy
            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (var item in array){
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            
            // TODO Sortowanie QuickSort w wersji Lomuto

            

            // Wypisywanie posortowanej tablicy
            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (var item in array){
                Console.Write(item + ", ");
            }
        }
    }
}