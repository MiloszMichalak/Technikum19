using System;
using System.Collections;

//Sprawdzian z PoPr C#. Grupa 1

// Zadanie 1 - working

ArrayList dzielniki = new ArrayList();
int n = int.Parse(Console.ReadLine());
for (int i = 1; i < n; i++){
    if (n % i == 0){
        dzielniki.Add(i);
    }
}

foreach (int i in dzielniki){
    System.Console.Write(i + " ");
}

System.Console.WriteLine("\n");

// Zadanie 2 - working

Random random = new Random();
int[] T = new int[20];
int dopoki = 0;
while (dopoki < 20){
    int losowa = random.Next(100, 999);
    if (losowa % 50 == 0){
        T[dopoki] = losowa;
        dopoki++;
    }
}

// Zadanie 3 - working

System.Console.Write("Liczba parzysta: ");
n = int.Parse(Console.ReadLine());
int[] losowaTablica = new int[n];

for (int i = 0; i < n; i++){
    losowaTablica[i] = random.Next(10, 99);
}

int suma1 = 0;
int suma2 = 0;
int polowa1 = n/2;

for (int i = 0; i < polowa1; i++){
    suma1 += losowaTablica[i];
}

for (int i = polowa1; i < losowaTablica.Length; i++){
    suma2 += losowaTablica[i];
}

if (suma1 > suma2){
    System.Console.WriteLine("1 polowa jest wieksza");
} else if (suma1 < suma2){
    System.Console.WriteLine("2 polowa jest wieksza");
} else {
    System.Console.WriteLine("polowy sa rowne");
}

// Zadanie 4 - dziala
int[,] M = new int[25, 25];
int suma = 0;
for (int i = 0; i < 25; i++){
    for (int j = 0; j < 25; j++){
        M[i, j] = random.Next(100, 999);
    }
}

// glowna petla z liczbami sprawdzajacymi
for (int i = 100; i < 999; i++){
    int ile = 0;
    int sumaPowtorzonych = 0;
    // petla od kolumn
    for (int j = 0; j < 25; j++){
        //petla od wierszy
        for (int k = 0; k < 25; k++){
            if (i == M[j, k]){
                ile++;
                sumaPowtorzonych += M[j, k];
            }
        }
    }
    if (ile > 2){
        suma += sumaPowtorzonych;
    }
}

System.Console.WriteLine(suma);
