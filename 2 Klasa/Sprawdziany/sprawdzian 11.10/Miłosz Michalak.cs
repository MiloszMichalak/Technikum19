using System;
using System.Collections;

int nwd(int a, int b){
    while (a != b){
        if (a > b){
            a -= b;
        } else {
            b -= a;
        }
    }
    return a;
}

// no tak prawie na pierwsza
bool czyPierwsza(int a){
    for (int i = 3; i < a; i++){
        if (a % i == 0){
            return false;
        }
    }
    return true;
}

// Zadanie -1 - imo work
System.Console.WriteLine("Zadanie -1");

int n = Convert.ToInt32(Console.ReadLine());
int f = Convert.ToInt32(Console.ReadLine());

if (!czyPierwsza(nwd(n, f))){
    System.Console.WriteLine("Liczby sa parami ibrahima paszy");
} else {
    System.Console.WriteLine("Liczby nie sa parami ibrahima paszy");
}

System.Console.WriteLine();

// Zadanie 0 -  tez work
System.Console.WriteLine("Zadnaie 0");

for (int i = 20; i <= 50; i++){
    for (int j = 20; j <= 50; j++){
        if (!czyPierwsza(nwd(i, j))){
            System.Console.WriteLine("Parami ibrahima paszy sa liczby: {0} i {1}", i, j);
        }
    }
}

System.Console.WriteLine();

// Zadanie 1 - smiesznie wyszlo
System.Console.WriteLine("Zadanie 1");

Random random = new Random();    
int[,] M = new int[20, 20];
int losowa;

for (int i = 0; i < 20; i++){
    for (int j = 0; j < 20; j++){
        losowa = random.Next(1, 10);
        if (losowa > -1 && losowa < 5){
            M[i, j] = 0;
            }else if (losowa == 5 && losowa == 6){
                M[i, j] = 1;
            } else if (losowa == 7 && losowa == 8){
                M[i, j] = 2;
            } else {
                M[i, j] = random.Next(3, 5);
            }
        }
    }


int ile = 0;
int suma;
  // liczy to caly srodek  
    for (int i = 1; i < 19; i++){
        for (int j = 1; j < 19; j++){
            suma = M[i - 1, j] + M[i + 1, j] + M[i, j - 1] + M[i, j + 1] + M[i - 1, j - 1] + M[i - 1, j + 1] + M[i + 1, j - 1] + M[i -1 , j - 1];
            if (M[i, j] == suma){
                ile++;
            }
        }
    }
    

// aaaa sprawdze se rogi
suma = M[0, 1] + M[1, 1] + M[1, 0];
if (suma == M[0 ,0]){
    ile++;
}

suma = M[18, 0] + M[18, 1] + M[18, 1];
if (suma == M[19, 19]){
    ile++;
}

suma = M[0, 18] + M[1, 18] + M[0, 19];
if (suma == M[0, 19]){
    ile++;
}

suma = M[18, 18] + M[18, 19] + M[19, 18];
if (suma == M[19, 19]){
    ile++;
}

// no to jeszcze zostaly linie boczne
suma = 0;
for (int i = 0; i < 20; i++){
    for (int j = 0; j < 20; j++){
        if (i == 0 && i == 19){
            suma = M[i - 1, j] + M[i - 1, j + 1] + M[i, j + 1] + M[i + 1, j + 1] + M[i + 1, j];
            if (M[i, j] == suma){
                ile ++;
            }
        }
    }
}

for (int i = 0; i < 20; i++){
    for (int j = 0; j < 20; j++){
        if (j == 0 && j == 19){
            suma = M[i, j - 1] + M[i - 1, j + 1] + M[i, j + 1] + M[i + 1, j + 1] + M[i, j + 1];
            if (M[i, j] == suma){
                ile++;
            }
        }
    }
}
// XD
System.Console.WriteLine("Taki przypadek wystepuje {0} razy", ile);

System.Console.WriteLine();

// Zadanie 2 - imo work to
System.Console.WriteLine("Zadanie 2");
string? kodBuraka = Console.ReadLine();

ile = 0;
int[] miejsca = new int[100];

foreach (int znak in kodBuraka){
    miejsca[znak]++;
}

int maks = 0;
foreach (int cyfra in miejsca){
    if (cyfra == 0){
        continue;
    }
    if (cyfra > maks){
        maks = cyfra;
    }
}

foreach (int cyfra in miejsca){
    if (cyfra == maks){
        ile++;
    }
}

if (ile == 2){
    System.Console.WriteLine("Tak");
} else {
    System.Console.WriteLine("Nie");
}

System.Console.WriteLine();

// Zadanie 3 - jak do tego doszlo nie wiem
System.Console.WriteLine("Zadanie 3");

ArrayList mozeGotowaLiczba = new ArrayList();

n = Convert.ToInt32(Console.ReadLine());
int polowaLiczby = n / 2 + 1;
int mozeGotowa = 0;
ile = 0;

for (int i = polowaLiczby; i > 1; i--){
    mozeGotowaLiczba.Add(i);
    mozeGotowa += i;
    if (mozeGotowa < n){
        continue;
    } else if (mozeGotowa > n){
        mozeGotowa -= (int)mozeGotowaLiczba[mozeGotowaLiczba.Count - 1];
        mozeGotowaLiczba.RemoveAt(mozeGotowaLiczba.Count - 1);
    } else {
        ile++;
        break;
    }
}

polowaLiczby = n/2;
mozeGotowa = 0;
mozeGotowaLiczba.Clear();

for (int i = polowaLiczby; i > 1; i--){
    mozeGotowaLiczba.Add(i);
    mozeGotowa += i;
    if (mozeGotowa < n){
        continue;
    } else if (mozeGotowa > n){
        mozeGotowa -= (int)mozeGotowaLiczba[mozeGotowaLiczba.Count - 1];
        mozeGotowaLiczba.RemoveAt(mozeGotowaLiczba.Count - 1);
    } else {
        ile++;
        break;
    }
}

if (ile == 2){
    System.Console.WriteLine("tak");
} else {
    System.Console.WriteLine("nie");
}    


System.Console.WriteLine();

// Zadanie 4
// .
