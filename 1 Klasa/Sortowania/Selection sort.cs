using System;

namespace Program{
    class SortowaniePrzezWybor{
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
            
            // Sortowanie przez wybor rosnaco
            for (int i = 0; i < array.Length - 1; i++){  
                int minIndex = i;  
                for (int j = i + 1; j < array.Length; j++){  
                    if (array[j] < array[minIndex]){  
                        minIndex = j;  
                    }  
                }  
                int temp = array[minIndex];  
                array[minIndex] = array[i];  
                array[i] = temp;  
            }

            //Sortowanie przez wybor malejaco
            for (int i = array.Length - 1; i > 0 - 1; i--){  
                int minIndex = i;  
                for (int j = 0; j < i; j++){  
                    if (array[j] < array[minIndex]){  
                        minIndex = j;  
                    }  
                }  
                int temp = array[i];  
                array[i] = array[minIndex];  
                array[minIndex] = temp;  
            }

            // Wypisywanie posortowanej tablicy
            Console.WriteLine("Tablica po sortowaniu: ");
            foreach (var item in array){
                Console.Write(item + ", ");
            }
        }
    }
}