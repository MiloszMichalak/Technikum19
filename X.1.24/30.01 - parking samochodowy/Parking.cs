using System.Collections;

namespace _30._01___parking_samochodowy;

// Utwórz klasę Parking, która reprezentuje parking samochodowy.
// Klasa ta powinna mieć następujące właściwości: Name (nazwa parkingu), Cars (tablica samochodów, które znajdują się na parkingu).
// Klasa ta powinna mieć również następujące metody: AddCar, która dodaje samochód do pierwszego wolnego miejsca
// na parkingu (lub wyświetla komunikat, że nie ma wolnych miejsc), RemoveCar, która usuwa samochód z podanego indeksu miejsca
// na parkingu (lub wyświetla komunikat, że podany indeks jest nieprawidłowy lub miejsce jest puste), ShowCars,
// która wyświetla informacje o wszystkich samochodach na parkingu (lub informuje, że miejsce jest wolne).

public class Parking
{
    public Parking(int slots, string name)
    {
        Slots = slots;
        Name = name;
        cars = new Car[Slots];
    }

    public string Name { get; set; }
    public static int Slots { get; set; }
    private Car[] cars;
    
    public void AddCar(int index, Car car)
    {
        cars[index] = car;
    }

    public void RemoveCar(int slot)
    {
        if (cars[slot].Equals(null))
        {
            Console.WriteLine("W tym miejscu nie ma samochodu");
        }

        
    }

    public void ShowCars()
    {
        for (int i = 0; i < cars.Length; i++)
        {
            if ()
            {
                Console.WriteLine($"Na miejscu {i} stoi {cars[i].ShowInformation()}");
            }
        } 
    }
    
}