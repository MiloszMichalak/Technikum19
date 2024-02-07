using konstruktory.classes;

namespace konstruktory;

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Jan", "Nowak");

        Console.WriteLine(person.SprawdzStan());
    }
}
