namespace Milosz_Michalak.classes;

public class Person
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public DateTime DataUrodzenia { get; set; }
    public List<string> Imiona_dzieci;

    public Person(string imie, string nazwisko, DateTime dataUrodzenia, List<string> imionaDzieci)
    {
        Imie = imie;
        Nazwisko = nazwisko;
        DataUrodzenia = dataUrodzenia;
        Imiona_dzieci = imionaDzieci;
    }

    public string DzieciWlasciciela()
    {
        return $"Dzieci wlasciciela: {string.Join(", ", Imiona_dzieci)}";
    }
    
    
}