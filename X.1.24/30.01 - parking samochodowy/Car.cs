namespace _30._01___parking_samochodowy;

public class Car
{
    public enum Color
    {
        Red,
        Blue,
        Green,
        Black,
        White
    }

    public Car(string brand, string model, int year, Color color)
    {
        Brand = brand;
        Model = model;
        Year = year;
        this.color = color;
    }

    public string Brand { get; }
    public string Model { get; }
    public int Year { get; }
    public Color color { get; }
    
    // Klasa ta powinna mieć również metodę ShowInformation, która wyświetla informacje o
    // samochodzie na konsoli w formacie: This is {Brand} {Model} from {Year}, color {Color}.
    public string ShowInformation()
    {
        return $"This is {Brand} {Model} from {Year}, color {color}";
    }
    
    
}