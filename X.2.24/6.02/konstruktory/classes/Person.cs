namespace konstruktory.classes;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(String firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string SprawdzStan()
    {
        return "Zyje☠";
    }

    ~Person()
    {
        Console.WriteLine("Usunieto obiekt");
    }
}