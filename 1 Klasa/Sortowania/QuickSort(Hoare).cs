using System;

namespace Program{
    class SortowaniePrzezWybor{


        // Write fucntion with QuickSort Hoare

        public static void QuickSortHoare(int[] T, int lewy, int prawy){
            int i = lewy;
            int j = prawy;
            int pivot = T[(lewy+prawy)/2];

            while (i <= j){
                while (T[i] < pivot){
                    i++;
                }
                while (T[j] > pivot){
                    j--;
                }
                if (i <= j){
                    int temp = T[i];
                    T[i] = T[j];
                    T[j] = temp;
                    i++;
                    j--;
                }
            }
            if (lewy < j){
                QuickSortHoare(T, lewy, j);
            } 
            if (prawy > i){
                QuickSortHoare(T, i, prawy);
            }
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
            
            // Sortowanie QuickSort w wersji Hoare
            Console.WriteLine("Tablica po sortowaniu: ");
            QuickSortHoare(array, 0, (array.Length) - 1);

            // Wypisywanie posortowanej tablicy
            foreach (var item in array){
                System.Console.Write(item + ", ");
            }
            System.Console.WriteLine();
        }
    }
}