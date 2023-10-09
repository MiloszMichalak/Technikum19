﻿// Zadanie -1 - sprawdzanie czy liczba jest ibrahimowska czyli czy jest pierwsza i pomnozona ona przez 2 i dodane do niej jeden dalej daje liczbe pierwsza
System.Console.WriteLine("Zadanie -1");

bool czyPierwsza(int liczba){
    for(int i = 2; i < liczba; i++){
        if (liczba % i == 0){
            return false;
        }
    }
    return true;
}

System.Console.Write("Podaj jaka liczba chcesz sprawdzic: ");
int liczba = Convert.ToInt32(Console.ReadLine());

if (czyPierwsza(liczba) && czyPierwsza((liczba * 2) + 1)){
    System.Console.WriteLine("Jest to liczba ibrahimowska");
} else {
    System.Console.WriteLine("Nie jest to liczba ibrahimowska");
}

System.Console.WriteLine();


// Zadanie 0 wypisac wszystkie lkiczby ibrahima od 2 do 100
System.Console.WriteLine("Zadanie 0");
for (int i = 2; i <= 100; i++){
    if (czyPierwsza(i) && czyPierwsza(i * 2 + 1)){
        System.Console.WriteLine("Liczba ibrahimowska jest {0}", i);
    }
}

System.Console.WriteLine();

// Zadanie 1 - wygenerowac losowa macierz, minimum 20x20, nastepnie sprawdz ile liczb w tej macierzy ma wartosc sumy sasiadujacych liczb.
System.Console.WriteLine("Zadanie 1");
Random random = new Random();
int ile = 0;

// Generowanie losowej tablicy
int[,] M = new int[20, 20];
for (int i = 0; i < 20; i++){
    for (int j = 0; j < 20; j++){
        M[i, j] = random.Next(1, 100);
    }
}

// Wypisywanie tablicy
for (int i = 0; i < 20; i++){
    for (int j = 0; j < 20; j++){
        Console.Write(M[i,j] + "\t");
    }
    System.Console.WriteLine();
}

// Szukanie tych liczb w macierzy
for (int i = 0; i < 20; i++){
    for (int j = 1; j < 19; j++){
        if (M[i, j + 1] + M[i, j - 1] == M[i, j]){
            ile++;
        }
    }
}

System.Console.WriteLine("Tyle przypadkow wystepuje {0} razy", ile);

System.Console.WriteLine();

// Zadanie 2 - uzytkownik podaje ciag cyfr, bez spacji, spradzamy ktora z cyfr wystepuje najrzadziej w pierwszych 40 cyfrach
System.Console.WriteLine("Zadanie 2");
System.Console.Write("Podaj ciag cyfr: ");

decimal ciag = Convert.ToInt64(Console.ReadLine());
ile = 0;

int[] miejsca = new int[100];

// Liczenie ile jest danych cyfr w tablicy
foreach (int znak in Convert.ToString(ciag)){
    miejsca[znak]++;
    ile++;
    if (ile == 40){
        break;
    }
}

// Szukanie mina w tablicy;
int mini = 10;
for (int i = 0; i < 100; i++){
    if (miejsca[i] == 0){
        continue;
    }
    if (miejsca[i] < mini){
        mini = miejsca[i];
        }
}

int index = Array.IndexOf(miejsca, mini);
System.Console.WriteLine($"Najrzadziej wystepuje cyfra {(char)index} w pierwszych 40 cyfrach");

System.Console.WriteLine();

// Zadanie 3 - Do podanej liczby pierwszej większej od 7 podać 3 liczby pierwsze nieparzyste których suma jest równa tej liczbie
System.Console.WriteLine("Zadanie 3");
// no nie wiem
