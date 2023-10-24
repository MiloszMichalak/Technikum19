namespace Logoalkolator
{
    class Program
    {
        public static void Main(string[] args)
        {
            String login, password, funkcja;
            String operation = new string("");
            int randomNumber, number, dzialanie, wynik;
            int result = 0;
            Random random = new Random();
            bool flaga = true;
            double wyjscie = 0;
            double liczba, temp;
            
            Console.WriteLine("Podaj login i hasło\n");

            while (flaga)
            {
                Console.Write("Podaj login: ");
                string? userLogin = Console.ReadLine();
                Console.Write("Podaj haslo: ");
                string? userPassword = Console.ReadLine();
                Console.WriteLine();

                StreamReader streamReader = new StreamReader("..\\..\\..\\Database\\users.txt");
                while (!streamReader.EndOfStream)
                {
                    String[] values = streamReader.ReadLine()!.Split(";");
                    login = values[0];
                    password = values[1];
                    if (userLogin == login && userPassword == password)
                    {
                        flaga = false;
                    }
                }
                if (flaga)
                {
                    Console.WriteLine("Podales nieprawidlowe dane, sprobuj jeszcze raz");
                }
            }
            
            number = random.Next(1, 10);
            result = number;
            operation += number;
            randomNumber = random.Next(2, 3);
            while (randomNumber > 0)
            {
                number = random.Next(1, 10);
                dzialanie = random.Next(1, 3);
                switch (dzialanie)
                {
                    case 1:
                        result += number;
                        operation += "+";
                        break;
                    case 2:
                        result -= number;
                        operation += "-";
                        break;
                }
                operation += number;
                randomNumber--;
            }
            Console.Write("Rozwiaz to rownanie zeby uzyskac dostep do kalkulatora: {0} = ", operation);
            // nie dam mu szansy jak nie potrafi nawet liczby wpisac XDDDDDD
            int.TryParse(Console.ReadLine(), out wynik);
            if (wynik == result)
            {
                Console.Write("Podaj liczbe z ktora chcesz od poczatku dzialac: ");
                while (!double.TryParse(Console.ReadLine(), out wyjscie))
                {
                    Console.Write("Podaj jeszcze raz liczbe bazowa: ");
                }

                while (true)
                {
                    Console.WriteLine("Napisz koniec aby zakonczyc dzialanie programu\n" + 
                                      "Jakie dzialanie chcesz wykonac: +, -, *, / \n" + 
                                      "Zapisz dzialanie w jednej lini");
                    Console.Write(wyjscie + " ");
                    funkcja = Console.ReadLine()!;
                    // tryb awaryjny i dziala
                    if (funkcja.Equals("koniec"))
                    {
                        Console.WriteLine("Milo bylo wspolpracowac z trzezwa wersja ciebie");
                        return;
                    }
                        
                    String[] wartosci = funkcja.Split(" ");
                    funkcja = wartosci[0];
                    string liczbaTemp = wartosci[1];
                    while (!double.TryParse(liczbaTemp, out liczba))
                    { 
                        Console.Write($"{wyjscie} {funkcja} "); 
                        liczbaTemp = Console.ReadLine()!;
                    }

                    temp = wyjscie;
                    switch (funkcja)
                    {
                        case "+":
                            wyjscie += liczba;
                            break;
                        case "-" :
                            wyjscie -= liczba;
                            break;
                        case "*":
                            wyjscie *= liczba;
                            break;
                        case "/":
                            wyjscie /= liczba;
                            break;
                        default:
                            Console.WriteLine("Podaj prawidlowe dzialanie");
                            break;
                    }
                    Console.WriteLine($"{temp} {funkcja} {liczba} = {wyjscie}");
                }
            }
            else
            {
                Console.WriteLine("Pierw ziomek wytrzezwiej, a pozniej sie za to bierz");
            }
        }
    }
}
