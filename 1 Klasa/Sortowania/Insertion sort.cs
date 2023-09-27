using System;

namespace Program{
    class SortowaniePrzezWstawianie{
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
            
            // Sortowanie poprzez wstawianie
            for (int i = 1; i < array.Length; i++){
                int temp = array[i];
                int j = i - 1;
                while(temp < array[j] && j > 0){
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = temp;
            }

            // Wypisywanie posortowanej tablicy
            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (var item in array){
                Console.Write(item + ", ");
            }
        }
    }
}