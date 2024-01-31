namespace Grafy___olimpiada;

public class Graph
{
    private List<Vertex> vertices = new List<Vertex>();
    private int N;

    public Graph(int n)
    {
        N = n;
        for (int i = 0; i <= n; i++)
        {
            vertices.Add(new Vertex());
        }
    }
    
    public void AddNeighbour(int v, int nei)
    {
        vertices[v].addNeighbour(nei);
        vertices[nei].addNeighbour(v);
    }

    public void DisplayGraph()
    {
        for (int i = 1; i <= N; i++)
        {
            Console.Write("{0} - ", i);
            vertices[i - 1].DisplayNeighbours();
        }
    }
}