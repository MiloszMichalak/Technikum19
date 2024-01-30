namespace Klasy.classes;
class Person
{
    internal enum Ranks
    {
        Administrator = 1,
        Moderator = 2,
        User = 3,
        Guest = 4
    }
    
    internal enum Gender
    {
        Kobieta,
        Mezczyzna
    }
    
    public string FirstName { get; private set; }
    public string LastName { private get; set; } 
    public float Height { get; set; }
    public float Weight { get; set; }
    public Adress Adress { get; set; }
    public DateTime DateOfBirth { get; set; }
    public Gender gender { get; set; }
    public Ranks ranks { get; set; }

    public void SetFirstName(string name)
    {
        FirstName = name;
    }

    public string GetLastName()
    {
        return LastName;
    }
}