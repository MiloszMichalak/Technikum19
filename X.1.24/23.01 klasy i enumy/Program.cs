using Klasy.classes;
namespace Klasy;

internal class Program
{
    public static void Main(string[] args)
    {
        Person nowak = new Person();

        nowak.SetFirstName("Bartosz");
        nowak.LastName = "Nowak";
        
        Console.WriteLine($"Imie: {nowak.FirstName}, Nazwisko: {nowak.GetLastName()}");

        Student student1 = new Student();
        student1.StudentNumber = "123456";

        Console.WriteLine("Number indexu ucznia: " + student1.StudentNumber);

        Teacher teacher1 = new Teacher();
        
        teacher1.Subjects = new List<string> {"Matematyka", "Informatyka", "Historia"};

        foreach (var subject in teacher1.Subjects)
        {
            Console.WriteLine(subject);
        }

        Console.WriteLine(string.Join(", ", teacher1.Subjects));

        nowak.Adress = new Adress();
        nowak.Adress.city = "Poznan";
        nowak.Adress.street = "28 czerwca";
        nowak.Adress.HouseNumber = "5";
        nowak.Adress.PostalCode = "62-043";
        
        Console.WriteLine(nowak.Adress.GetAdress());

        nowak.DateOfBirth = DateTime.Now;
        Console.WriteLine("Data i czas: " + nowak.DateOfBirth);

        nowak.DateOfBirth = new DateTime(2000, 08, 13);
        Console.WriteLine("Data urodzenia: {0}", nowak.DateOfBirth.ToShortDateString());
        
        nowak.DateOfBirth = new DateTime(2000, 08, 13);
        Console.WriteLine("Data i czas: {0}", nowak.DateOfBirth.ToLongDateString());
        
        Console.Clear();
        Person p1 = new Person();
        p1.gender = Person.Gender.Mezczyzna;
        Console.WriteLine(p1.gender);
        
        p1.ranks = Person.Ranks.Administrator;
        Console.WriteLine("Ranga uzytkownika p1: {0}", p1.ranks);
        
    }
}
