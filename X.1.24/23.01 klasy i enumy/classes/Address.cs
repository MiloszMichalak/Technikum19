namespace Klasy.classes;

public class Adress
{
    public string city { get; set; }
    public string street { get; set; }
    public string HouseNumber { get; set; }
    public string PostalCode { get; set; }

    public string GetAdress()
    {
        return $"Miasto: {city}, \n" +
               $"Ulica: {street}, \n" +
               $"Numer domu: {HouseNumber}, \n" +
               $"Kod pocztowy: {PostalCode}";
    }
}