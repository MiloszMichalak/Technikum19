using _19._03.classes;

namespace _19._03;

class Program
{
    static void Main(string[] args)
    {
        Samochod samochod = new Samochod("Ferrari", "Testarossa", 1969, 3.6, false, new DateTime(2020, 6, 24),
            StatusSamochodu.Zabytkowy);
        Console.WriteLine(samochod.WyswietlInformacje());
        Console.WriteLine(samochod.ObliczWiekSamochodu());
        
        Samochod samochodDomyslny = new Samochod();
        Console.WriteLine(samochodDomyslny.WyswietlInformacje());

        Samochod samochod2 = new Samochod("Volkswagen", "Golf", 2004);
        Console.WriteLine(samochod2.WyswietlInformacje());
    }
}
