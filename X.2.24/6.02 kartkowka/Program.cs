using Milosz_Michalak.classes;

namespace Milosz_Michalak;

class Program
{
    static void Main(string[] args)
    {
        List<string> dzieci = new List<string>()
        {
            "Bartek",
            "Janek",
            "Radek"
        };
        
        Person person = new Person("Jan", "Nowak", new DateTime(2000, 8, 15), dzieci);
        Car car = new Car("Ferrari", "Testarossa", Colors.Red, 1960, 100000, person);

        // wypiywanie dzieci
        Console.WriteLine(person.DzieciWlasciciela());
        
        // wypisywanie informacji o klasie Car
        Console.WriteLine(car.GetInfo());
        
        // zmiana koloru samochodu na black
        car.Color = Colors.Black;
        Console.WriteLine(car.GetInfo());
    }
}
