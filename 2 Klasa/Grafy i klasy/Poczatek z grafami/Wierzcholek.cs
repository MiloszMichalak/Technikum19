namespace Grafy_i_klasy;

public class Wierzcholek {
    List<int> polaczenia = new List<int>();
    
    //DodajPolaczenie(wierzcholek)
    // polaczenia add wierzcholek

    public void DodajPolaczenie(int wierzcholek){
        polaczenia.Add(wierzcholek);
    }

    public void WypiszPolaczenia(){
        foreach (var item in polaczenia){
            Console.Write("{0} ", item);
        }
    }

    public List<int> PobierzPolaczenia()
    {
        return this.polaczenia;
    }
    
}