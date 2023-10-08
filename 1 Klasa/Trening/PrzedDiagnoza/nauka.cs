using System;
using System.Collections;
// Przed diagnoza

// Algorytmy: 

// Napisz i przetestuj alorytm euklidesa odejmowanie
int euklidesOdejmowanie(int a, int b){
    while (a != b){
        if (a > b){
            a -= b;
        } else{
            b -= a;
        }
    }
    return a;
}

int euklidesModulo(int a, int b){
    int temp;
    while (b > 0){
        temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}

System.Console.WriteLine("Wprowadz liczby: ");
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Nwd");
System.Console.WriteLine(euklidesOdejmowanie(x, y));
System.Console.WriteLine(euklidesModulo(x, y));

System.Console.WriteLine();

// Napisz i pzetestuj algorytm sortowania babelkowego na tablicy

void bubbleSort(int[] arr){
    int temp;
    int size = arr.Length;
    for (int i = size - 1; i > 0; i--){
        for (int j = 0; j < i; j++){
            if (arr[j] > arr[j + 1]){
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
}

// Generowanie losowej tablicy
Random random = new Random();
int[] arr = new int[5];
for (int i = 0; i < arr.Length; i++){
    arr[i] = random.Next(1,10);
}

System.Console.WriteLine("Tablica przed posortowaniem");
foreach (int i in arr){
    System.Console.WriteLine(i);
}

bubbleSort(arr);

System.Console.WriteLine("Tablica po posortowaniu");
foreach (int i in arr){
    System.Console.WriteLine(i);
}

// Wypisz wszystkie pary liczb zaprzyjaznionych z przedzialu 1-10 000
int sumaDzielnikowWlasciwych(int a){
    int suma = 0;
    for (int i = 1; i < a / 2; i++){
        if (a % i == 0){
            suma += i;
        }
    }
    return suma;
}

System.Console.WriteLine("Pary liczb zaprzyjaznionych z przedzialu 1-10 000");
for (var i = 1; i < 10000; i++){
    int temp = sumaDzielnikowWlasciwych(i);
    if (i == sumaDzielnikowWlasciwych(temp) && temp!= i){
        System.Console.WriteLine(i + " " + temp);
    }
}

System.Console.WriteLine();

// Listy - tablice -  w tablicy 30 lsoowych liczb trzycyfrowych
// znajdz ilosc wielokrotnosc liczby 17 (zapisz te kliczby w tablicy wynikowej)

ArrayList lista = new ArrayList();
for (var i = 0; i < 30; i++){
    lista.Add(random.Next(100, 1000));
}

ArrayList wynikowa = new ArrayList();

foreach (int item in lista){
    if (item % 17 == 0){
        wynikowa.Add(item);
    }
}

System.Console.WriteLine("Wielokrotnosci 17 w liscie");
foreach (var item in wynikowa){
    System.Console.Write(item + " ");
}

System.Console.WriteLine();

// Macierz - wypisz sumy kolejnych ramek w macierzy kwadratowej o n parzystym

int n = 6;
int[,] Maciora = new int[n, n];
for (int i = 0; i < n; i++){
    for (int j = 0; j < n; j++){
        Maciora[i, j] = random.Next(1, 10);
    }
}

for (int i = 0; i < n; i++){
    for (int j = 0; j < n; j++){
        System.Console.Write(Maciora[i,j] + "  ");
    }
    System.Console.WriteLine();
}

// Sposob przez sumy
ArrayList sumy = new ArrayList();

int suma;
for (int i = 1; i <= n/2; i++){
    suma = 0;
    for (int j = n / 2 - i; j <= n / 2 + i; j++){
        for (int k = n / 2 - i; k < n / 2 + i; k++){
            suma += Maciora[j, k];
        }
    }
    sumy.Add(suma);
}

System.Console.WriteLine();

foreach (var item in sumy){
    System.Console.WriteLine(item);
}
