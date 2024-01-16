namespace Klasy;

internal class Program
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public float Height { get; set; }
        public float Weight { get; set; }
    }

    public static void Main(string[] args)
    {
        Person nowak = new Person();
    }
}
