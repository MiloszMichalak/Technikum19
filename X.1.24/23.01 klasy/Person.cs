namespace Klasy;
class Person
{
    public string FirstName { get; private set; }
    public string LastName { private get; set; } 
    public float Height { get; set; }
    public float Weight { get; set; }
    public Adress Adress { get; set; }
    public DateTime DateOfBirth { get; set; }

    public void SetFirstName(string name)
    {
        FirstName = name;
    }

    public string GetLastName()
    {
        return LastName;
    }
}