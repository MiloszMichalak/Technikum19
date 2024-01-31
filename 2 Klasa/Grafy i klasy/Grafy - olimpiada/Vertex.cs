namespace Grafy___olimpiada;

public class Vertex
{
    private List<int> neighbours = new List<int>();

    public void addNeighbour(int nei)
    {
        neighbours.Add(nei);
    }

    public void DisplayNeighbours()
    {
        foreach (var item in neighbours)
        {
            Console.WriteLine(item + " ");
        }
    }
}