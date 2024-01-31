namespace Grafy___olimpiada;

class Program
{
    static void Main(string[] args)
    {
        int a, b;
        List<string> list = Console.ReadLine()!.Split(" ").ToList();
        int n = Convert.ToInt32(list[0]);
        int m = Convert.ToInt32(list[1]);
        Graph graph = new Graph(n);
        
        for (int i = 0; i < m; i++)
        {
            list = Console.ReadLine()!.Split(" ").ToList();
            a = Convert.ToInt32(list[0]);
            b = Convert.ToInt32(list[1]);
            
            graph.AddNeighbour(a, b);
        }
        
        graph.DisplayGraph();
    }
}
