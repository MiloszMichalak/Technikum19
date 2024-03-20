using Microsoft.VisualBasic;

namespace PrzedKolekcjami;

class Program
{
    static void Main(string[] args)
    {
        // 1. Wpisz do tablicy n liczb podanych przez usera w sposób rosnący i wypisz te z nich, które są "portugalskie".
        //     Przez liczby portugalskie rozumiemy liczby samotne czyli takie które nie 
        //     mają sąsiada w otoczeniu 2.
        // WE:
        // 3 7 9 13 19
        // WY:
        // 3 13 19

        Console.WriteLine("Zadanie 1");

        Console.WriteLine("Podaj ciag liczb");
        string[] ciag = Console.ReadLine().Split().ToArray();
        
        for (int i = 1; i < ciag.Length - 1; i++)
        {
            if (Convert.ToInt32(ciag[i]) - 2 > Convert.ToInt32(ciag[i - 1]) &&
                Convert.ToInt32(ciag[i]) + 2 < Convert.ToInt32(ciag[i + 1]))
            {
                Console.WriteLine(ciag[i]);
            }
        }

        Console.WriteLine();

        
        // 2. User podaje dowolny werset z Pana Tadeusza. Sprawdź czy w tym wersecie jakaś
        // literka występuje co najmniej 3 razy. Użyj tablic
        Console.WriteLine("Zadanie 2");
        char[] wers = Console.ReadLine().ToCharArray();
        
        int[] alfabet = new int[150];
        foreach (var litera in wers)
        {
            alfabet[litera]++;
        }
        
        for (int i = 0; i < alfabet.Length; i++)
        {
            if (alfabet[i] >= 3) 
            { 
                Console.Write(Strings.Chr(i) + " ");
            }
        }

        Console.WriteLine();
        
        // 3. User podaje dwie liczby brytyjskie.
        // Przez liczby brytyjskie rozumiemy dwie 
        //     dowolne liczby dwucyfrowe różniące się przynajmniej o 50.
        //     Zapisz do listy wszystkie liczby pierwsze znajdujące się 
        // między powyższymi liczbami.
        Console.WriteLine("Zadanie 3");
        Console.WriteLine("Podaj dwie liczby brytyjskie");
        string[] liczby = Console.ReadLine().Split().ToArray();
        
        List<int> przedzial = new List<int>();
        
        for (int i = Convert.ToInt16(liczby[0]) + 1; i < Convert.ToInt16(liczby[1]); i++)
        {
            if (czyPierwsza(i))
            {
                przedzial.Add(i);
            }
        }
        
        foreach (var cyfra in przedzial)
        {
            Console.Write(cyfra + " ");
        }

        Console.WriteLine();

        // 4. Utwórz strukturę losowych osób z losowymi danymi. Zasady:
        // - wiek między 20 a 50 lat
        //     - imię 4 literowe zaczynająca się na A.
        // - Nazwisko to odwrócenie imienia.
        //     Wylosuj takie 4 osoby i dodaj je do listy Osób. User nic tu nie wprowadza.
        Console.WriteLine("Zadanie 4");
        Random random = new Random();
        List<Osoba> osoby = new List<Osoba>();
        string literki = "abcdefghijklmnoprstuwyz";
        
        for (int i = 0; i < 4; i++)
        {
            string imie = new string("a");
            for (int j = 0; j < 3; j++)
            {
                imie += literki[random.Next(0, literki.Length)];
            }
        
            char[] odwroconeImie = imie.ToCharArray();
            Array.Reverse(odwroconeImie);
            string nazwisko = new string(odwroconeImie);
        
            Osoba osoba = new Osoba(random.Next(20, 50), imie, nazwisko);
            
            osoby.Add(osoba);
        }
        
        foreach (var osoba in osoby)
        {
            Console.WriteLine(osoba.getInfo());
        }

        Console.WriteLine();

        // 5. Utwórz kolejkę liczb doskonałych 
        //         (liczby które równają się sumie swoich dzielników właściwych). 
        //     Umieść w niej 4 najmniejszych liczb doskonałych.
        //     Wyświtl kolejkę, usuń z niej 2 liczby i znów wyświetl to co zostało.
        Console.WriteLine("Zadanie 5");
        Queue<int> doskonale = new Queue<int>();
        int k = 1;
        while (doskonale.Count < 4)
        {
            if (k == sumaDzielnikow(k))
            {
                doskonale.Enqueue(k);
            }

            k++;
        }

        doskonale.Dequeue();
        doskonale.Dequeue();

        foreach (var liczba in doskonale)
        {
            Console.Write(liczba + " ");
        }

        Console.WriteLine();

        // 6. Stwórz stos nieparzystych dwucyfrowych wielokrotności liczby 13.
        //     Usuń z tego stosu 2 liczby i wyświetl znów ten stos 
        // dziwiąc się temu co na nim zostało.
        Console.WriteLine("Zadanie 6");
        Stack<int> stos = new Stack<int>();
        for (int i = 10; i < 100; i++)
        {
            if (i % 2 == 1 && i % 13 == 0)
            {
                stos.Push(i);
            }
        }

        stos.Pop();
        stos.Pop();

        foreach (var liczba in stos)
        {
            Console.Write(liczba + " ");
        }

        Console.WriteLine();

        // 7. Kod Hufmanna to zamiana ciągu w stylu AAAAABBBBBBBCCC na 5A7B3C.
        //     Niech user poda wam n ciągów które zapiszecie do zwykłej tablicy.
        //     Potem przenieście te dane do słowinika, gdzie kluczem będzie kod ciągu
        //     a wartością ten ciąg.
        Console.WriteLine("Zadanie 7");


        Console.WriteLine();

        // 8. Stwórz graf składający się z 6 wierzchołków i 7 krawędzi. 
        //     Wypisz najwyższy stopień wierzchołka. Jeśli kilka wierzchołków ma ten sam stopień
        //     to wypisz dowolny z nich.
        Console.WriteLine("Zadanie 8");



    }

    struct Osoba
    {
        public Osoba(int wiek, string imie, string nazwisko)
        {
            Wiek = wiek;
            Imie = imie;
            Nazwisko = nazwisko;
        }

        private int Wiek;
        private string Imie;
        private string Nazwisko;

        public string getInfo()
        {
            return $"Imie: {Imie}, Nazwisko: {Nazwisko}, Wiek: {Wiek}";
        }
    }

    public static int sumaDzielnikow(int n)
    {
        int suma = 0;
        for (int i = 1; i < n; i++)
        {
            if (n % i == 0)
            {
                suma += i;
            }
        }

        return suma;
    }

    public static bool czyPierwsza(int n)
    {
        for (int i = 2; i < n / 2; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
