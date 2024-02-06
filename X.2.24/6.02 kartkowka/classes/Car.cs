namespace Milosz_Michalak.classes;

public enum Colors
{
    Black,
    White,
    Red,
    Orange,
    Pink
}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public ushort Year { get; set; }
    public float Price;
    public Person Owner { get; set; }
    public Colors Color { get; set; }

    public Car(string brand, string model, Colors color, ushort year, float price, Person owner)
    {
        Brand = brand;
        Model = model;
        Color = color;
        Year = year;
        Price = price;
        Owner = owner;
    }

    public string GetInfo()
    {
        return $"Marka: {Brand}, Model: {Model}, Kolor: {Color}, Rok: {Year}, Cena: {Price} PLN, Wlasciciel: {Owner.Imie} {Owner.Nazwisko}, data urodzenia: {Owner.DataUrodzenia.ToShortDateString()}";
    }
    
}