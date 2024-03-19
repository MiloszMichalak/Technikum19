using System.Reflection;
using System.Runtime.InteropServices.JavaScript;

namespace _19._03.classes;

public enum StatusSamochodu
{
    Nowy,
    Uzywany,
    Zabytkowy
}

public class Samochod
{

    private string Marka;
    private string Model;
    private int RokProdukcji;
    private double PojemnoscSilnika;
    private bool CzyDiesel;
    private DateTime DataZakupu;
    private StatusSamochodu statusSamochodu;

    public Samochod()
    {
        Marka = "Nieznana";
        Model = "Nieznany";
        RokProdukcji = 0;
        PojemnoscSilnika = 0.0;
        CzyDiesel = false;
        DataZakupu = DateTime.Now;
    }

    public Samochod(string marka, string model, int rokProdukcji)
    {
        Marka = marka;
        Model = model;
        RokProdukcji = rokProdukcji;
    }

    public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika) : this(marka, model,
        rokProdukcji)
    {
        PojemnoscSilnika = pojemnoscSilnika;
    }

    public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika, bool czyDiesel) : this(marka,
        model,
        rokProdukcji, pojemnoscSilnika)
    {
        CzyDiesel = czyDiesel;
    }

    public Samochod(string marka, string model, int rokProdukcji, double pojemnoscSilnika, bool czyDiesel,
        DateTime dataZakupu, StatusSamochodu statusSamochodu) : this(marka, model, rokProdukcji, pojemnoscSilnika,
        czyDiesel)
    {
        Marka = marka;
        Model = model;
        RokProdukcji = rokProdukcji;
        PojemnoscSilnika = pojemnoscSilnika;
        CzyDiesel = czyDiesel;
        DataZakupu = dataZakupu;
        this.statusSamochodu = statusSamochodu;
    }

    public string WyswietlInformacje()
    {
        return $"Informacje: {Marka}, {Model}, {RokProdukcji}, {PojemnoscSilnika}, {CzyDiesel}, {DataZakupu.ToShortDateString()}, {statusSamochodu}";
    }

    public string ObliczWiekSamochodu()
    {
        int wiek = DateTime.Now.Year - DataZakupu.Year;

        if (DateTime.Now.Month > DataZakupu.Month ||
            DateTime.Now.Month == DataZakupu.Month && DateTime.Now.Month > DataZakupu.Month) wiek--;
        
        return wiek.ToString();
    }
}
