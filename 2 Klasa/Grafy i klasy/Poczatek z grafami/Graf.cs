namespace Grafy_i_klasy;

public class Graf
{
    List<Wierzcholek> Wierzcholki = new List<Wierzcholek>();

    public Graf(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Wierzcholki.Add(new Wierzcholek());
        }
    }
    
    //DodajKrawedz(wierzcholek, z czym sie laczy)

    public void DodajKrawedz(int wierzcholek, int[] polaczenia) {
        foreach (var item in polaczenia)
        {
            Wierzcholki[wierzcholek].DodajPolaczenie(item);
        }
    }
    
    // WypiszKrawedzie(wierzcholek)

    public void WypiszKrawedzie(int wierzcholek)
    {
        foreach (var item in Wierzcholki[wierzcholek].PobierzPolaczenia())
        {
            Console.WriteLine("{0}-{1}", wierzcholek, item);
        }
    }
}
