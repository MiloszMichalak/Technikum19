using _27._02.classes;

namespace _27._02;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        Person person2 = new Person("John");
        Person person3 = new Person("Dexter", "Parker", 23);
        Person person4 = new Person("Ryan", "Tylley", 27, 188);

        Console.WriteLine(person1.GetData());
        Console.WriteLine(person2.GetData());
        Console.WriteLine(person3.GetData());
        Console.WriteLine(person4.GetData() + "Wzrost: " + person4.Height);

        Console.WriteLine("Zainicjowano {0} obiektow klasy person", Person.Counter);
    }
}
