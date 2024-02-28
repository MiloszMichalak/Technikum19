namespace _27._02.classes;

public class Person
{
    // pole statyczne ktore przechowuje ile razy uzyto konstruktor
    public static int Counter = 0;
    
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public float Height { get; set; }
    
    // konstruktor statyczny jest wywolywany automatycznie, aby zainicjowac klase przed jej utworzeniem
    // Jest wywolywany tylko raz niezaleznie od ilosci obiektow, jest wywolywany przed uzyciem typu
    // Nie moze miec parametrow ani modyfikatorow dostepu
    // Sluzy do inicjowania pol statycznych lub wykonywaina innych operacji statycznych

    static Person()
    {
        Console.WriteLine("Czy to sie zainicjowalo?");
    }
    
    // Konsktruktor domyslny jest bez parametrowy. Jeśli klasa nie ma żadnego konstruktora, to konstruktor domyślny jest 
    // wywolywany przy tworzeniu obiektu. Inicjuje on wszystkie pola do ich wartosci domyslnych. Jesli zdefiniujemy
    // jakis konstruktor parametryczny to nie otrzymamy automatycznie konstruktora domyslnego i mozemy/musimy go samodzielnie zadelkarowac
    public Person()
    {
        Name = "Nieznane";
        Surname = "Nieznane";
        Counter++;
    }
    
    // Konstruktor parametryczny. Sluzy do inicjowania pol obiektu zgodnie z wartosciami podanymi przy tworzeniu obiektu. 
    // Mozemy miec wiele konstruktorow parametrycznych, o ile roznia sie liczba lub typem parametrow
    public Person(string name)
    {
        Name = name;
        Counter++;
    }

    public Person(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
        Counter++;
    }
    
    // this sluzy do wywolania innego konstruktora tej samej klasy, czyli konstruktora parametrycznego z trzema parametrami
    // Dzieki temu konstruktor z czterema paramterami nie musi inicjowac pol Name, Surname, Age a moze skupic sie na dodadniu pola Height
    // Jest to unikniecie powtarzania kodu i zapewnienie spojnosci danych
    
    // Konstruktor parametryczny klasy person z 4 parametrami
    public Person(string name, string surname, int age, float height) : this(name, surname, age)
    {
        Height = height;
    }
    

    public string GetData()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}";
    }
}