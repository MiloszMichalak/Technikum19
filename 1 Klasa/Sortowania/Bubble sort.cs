using System;

namespace Program{
    class SortowanieBabelkowe{
        public static void Main(string[] args){
            //Tworzenie losowej tablicy
            Random random = new Random();
            int[] arr = new int[20];
            for (int i = 0; i < 20; i++){
                arr[i] = random.Next(1, 100);
            }

            // Wypisywanie poczatkowej nie posortowanej tablicy
            Console.WriteLine("Tablica przed sortowaniem: ");
            foreach (var item in arr){
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            
            int n = arr.Length;  
            // Sortowanie babelkowe
            for (int i = n - 1; i > 0; i--){
                for (int j = 0; j < i; j++){
                    if (arr[j] > arr[j + 1]){
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            // Wypisywanie posortowanej tablicy
            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (var item in arr){
                Console.Write(item + ", ");
            }
        }
    }
}