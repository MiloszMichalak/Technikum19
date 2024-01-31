namespace Grafy___olimpiada;

public class Graph
{
    private List<Vertex> vertices = new List<Vertex>();

    public Graph(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            vertices.Add(new Vertex());
        }
    }
    
    public void AddNeighbour(int v, int nei)
    {
            
    }
}