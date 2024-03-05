namespace _5._03___menu.classes;

public enum Kind // definicja typu anum Kind/rodzaj
{
    Ptak,
    Ryba,
    Gad,
    Płaz,
    Ssak
}

public class Animal
{
    //właściwości
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsMammal { get; set; }
    public Kind Kind { get; set; }

    public Animal(string name)
    {
        Name = name;
        BirthDate = DateTime.MinValue; // domyślna data urodzenia
        IsMammal = true;
        Kind = Kind.Ssak;
    }
    public Animal(string name, DateTime birthDate) : this(name)
    {
        BirthDate = birthDate;
    }
    public Animal(string name, DateTime BirthDate, bool IsMammal) : this(name, BirthDate)
    {
        IsMammal = IsMammal;
    }

    public Animal(string name, DateTime birthDate, bool IsMammal, Kind kind) : this(name, birthDate, IsMammal)
    {
        Kind = kind;
    }
    
    public string Describe()
    {
        string description = $"Nazwa zwierzęcia: {Name}. Data urodzenia: {BirthDate.ToShortDateString()}r. ";

        if (IsMammal) description += "Zwierze jest ssakiem. ";
        else description += "Zwierze nie jest ssakiem. ";
        description += "Rodzaj zwierzęcia: " + Kind;
        return description;
    }

    public void ShowAge()
    {
        //obliczenie wieku (w latach)
        int age = DateTime.Now.Year - BirthDate.Year;
        Console.WriteLine($"Wiek zwierzecia wynosi {age} lat.");
    }

}