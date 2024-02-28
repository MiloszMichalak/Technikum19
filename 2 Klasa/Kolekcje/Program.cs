using System.Collections;

namespace Kolekcje;

class Program
{
    
    static void Main(string[] args)
    {
        // 1. Stwórzcie tablicę 115 pierwszych liczb, 
        // które w repreznetacji binarnej kończą się na 11
        // 11, 111, 1011, 1111, .....
        Console.WriteLine("Zadanie 1");
        int[] T = new int[115];
        T[0] = 3;
        for (int i = 1; i < T.Length; i++)
        {
            T[i] = T[i - 1] + 4;
        }

        foreach (var item in T)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine("\n");
        
        
        // 2. Stwórzcie plik o nazwie osoby z zawartością 5 osob:
        //
        // imie; nazwisko ; wiek

        // i wstawcie do tablicy obiekty (struktury) typu osoba 
        // z właściwościami / polami z pliku, czyli imie, nazwisko, wiek
        Console.WriteLine("Zadanie 2");
        StreamReader streamReader = new StreamReader(@"..\..\..\osoby.txt");
        Person[] persons = new Person[5];
        int licznik = 0;

        while (!streamReader.EndOfStream)
        {
            Person person = default;
            string[] data = streamReader.ReadLine()!.Split(";");
            
            person.Name = data[0];
            person.Surname = data[1];
            person.Age = Convert.ToInt32(data[2]);
            
            persons[licznik++] = person;
        }

        foreach (var item in persons)
        {
            Console.WriteLine(item.GetInfo());
        }
        
        streamReader.Close();

        Console.WriteLine("\n");
        
        // 3. Stwórz listę 6 losowych słów składających się z 3 różnych samogłosek (List, ArrayList)
        Console.WriteLine("Zadanie 3");
        Random random = new Random();
        
        List<char> samogloski = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'y' };
        List<string> slowa = new List<string>();
        
        char litTemp;
        for (int i = 0; i < 6; i++)
        {
            string slowo = new string("");
            List<char> samogloskiCopy = new List<char>(samogloski);
            for (int j = 0; j < 3; j++)
            {
                litTemp = samogloski[random.Next(0, samogloski.Count())];
                slowo += litTemp;
                samogloski.Remove(litTemp);
            }

            samogloski = samogloskiCopy;
            slowa.Add(slowo);
        }

        foreach (var item in slowa)
        {
            Console.WriteLine(item);
        }

        // 4. Stwórz kolejkę (queue) 4 losowych liczb fibonacciego < 100 (mogą się powtarzać). 
        //     Wyświetl kolejkę, usuń z niej 2 elementy i wyświetl pozostałe 2
        Console.WriteLine("\n");
        
        Console.WriteLine("Zadanie 4");
        ArrayList fibonaci = new ArrayList();
        
        int k = 1;
        while (Fibo(k) < 100)
        {
            fibonaci.Add(Fibo(k++));
        }
        
        Queue queue = new Queue();
        for (int i = 0; i < 4; i++)
        {
            queue.Enqueue(fibonaci[random.Next(0, fibonaci.Count)]);
        }
        
        foreach (var item in queue)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        queue.Dequeue();
        queue.Dequeue();
        
        foreach (var item in queue)
        {
            Console.Write(item + " ");
        }
        
        Console.WriteLine("\n");

        // 5. Stwórz stos (stack) 5 kolejnych dwucyfrowych liczb pierwszych.
            // Wyświetl stos, usuń 3 wyrazy i zwów wyświetl stos.
        Console.WriteLine("Zadanie 5");
        List<int> pierwsze = new List<int>();
        k = 10;
        while (pierwsze.Count < 5)
        {
            if (CzyPierwsza(k)) pierwsze.Add(k);
            k++;
        }
        
        Stack<int> stack = new Stack<int>();
        foreach (var item in pierwsze)
        {
            stack.Push(item);
        }
        
        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
        stack.Pop();
        stack.Pop();
        stack.Pop();
        
        foreach (var item in stack)
        {
            Console.Write(item + " ");
        }
    }
    
    public static int Fibo(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;
        return Fibo(n - 1) + Fibo(n - 2);
    }

    public static bool CzyPierwsza(int n)
    {
        for (int i = 2; i < n/2; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    struct Person
    {
        public string Name;
        public string Surname;
        public int Age;

        public string GetInfo()
        {
            return $"Imie i nazwisko: {Name} {Surname}, wiek: {Age}";
        }
    }
}
