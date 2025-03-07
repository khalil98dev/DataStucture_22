using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImplementationCraphByAjacenecyList
{
    internal class Program
    {
        class Graph
        {
            public enum eType { eUndirected=1,eDirected=2}

            public eType _GraphType {  get; set; } = eType.eUndirected; 

            public Dictionary<string,List<Tuple<string,int>>> _AdjacenecyList;

            public Dictionary<string, int> _vertexDictionary; 

            public int _NumberOfVerticies {  get; set; }    

            public Graph(List<string> Verticies,eType GraphType)
            {
                this._GraphType = GraphType;

                _NumberOfVerticies = Verticies.Count;

                _AdjacenecyList = new Dictionary<string, List<Tuple<string, int>>>();
                
                _vertexDictionary = new Dictionary<string, int>();


                for (int i = 0; i < _NumberOfVerticies; i++) 
                {
                   _vertexDictionary[Verticies[i]] = i;

                    _AdjacenecyList[Verticies[i]] = new List<Tuple<string, int>>(); 

                }

            }


            public void AddEdje(string Source,string Distination,int Weight)
            {
                if(!(_vertexDictionary.ContainsKey(Source) && _vertexDictionary.ContainsKey(Distination)))
                {
                    Console.WriteLine($"We can't creat edje between {Source} and {Distination},Check the " +
                        $"exstence of them");
                    return; 
                }

                List<Tuple<string, int>> Current = _AdjacenecyList[Source];

                _AdjacenecyList[Source].Add(new Tuple<string, int>(Source, Weight)); 

                if(_GraphType == eType.eUndirected)
                {
                    _AdjacenecyList[Distination].Add(new Tuple<string, int>(Source, Weight));
                }



            }

            public void RemoveEdje(string Source, string Distination)
            {
                if (!(_vertexDictionary.ContainsKey(Source) && _vertexDictionary.ContainsKey(Distination)))
                {
                    Console.WriteLine($"We can't creat edje between {Source} and {Distination},Check the " +
                        $"exstence of them");
                    return;
                }

                _AdjacenecyList[Source].RemoveAll(Item => Item.Item1 == Distination);

                if (_GraphType == eType.eUndirected)
                {
                    _AdjacenecyList[Distination].RemoveAll(Item => Item.Item1 == Source);
                }

            }

            public bool IsEdje(string Source,string Distination)
            {
                if (!(_vertexDictionary.ContainsKey(Source) && _vertexDictionary.ContainsKey(Distination)))
                {
                    Console.WriteLine($"We can't Find edje between " +
                        $"{Source} and {Distination},Check the " +
                        $"exstence of them");
                    return false;
                }
                foreach(var edje in _AdjacenecyList[Source] )
                {
                    if(edje.Item1 == Distination)
                    {
                        return true;
                    }
                }

                return false;


            }

            public void DisplayGraph(string Message)
            {
                Console.WriteLine("\n" + Message + "\n");

                // Loop through each vertex in the adjacency list
                foreach (var vertex in _AdjacenecyList)
                {
                    Console.Write(vertex.Key + " -> ");  // Print the vertex label

                    // Print all edges for the vertex
                    foreach (var edge in vertex.Value)
                    {
                        Console.Write($"{edge.Item1}({edge.Item2}) ");  // Print destination vertex and weight
                    }
                    Console.WriteLine();
                }
            }

            public int GetInDegree(string vertex)
            {
                int inDegree = 0;  // Initialize the indegree count to zero

                // Check if the vertex exists in the map
                if (_vertexDictionary.ContainsKey(vertex))
                {
                    // Loop through each vertex in the adjacency list
                    foreach (var source in _AdjacenecyList)
                    {
                        // Loop through the edges of the current vertex
                        foreach (var edge in source.Value)
                        {
                            // If the destination of the edge is the given vertex, increment the indegree
                            if (edge.Item1 == vertex)
                            {
                                inDegree++;
                            }
                        }
                    }
                }

                return inDegree;  // Return the total indegree of the vertex
            }

            public int GetOutDegree(string vertex)
            {
                int outDegree = 0;  // Initialize the outdegree count to zero

                // Check if the vertex exists in the map
                if (_vertexDictionary.ContainsKey(vertex))
                {
                    // The outdegree is simply the number of edges in the adjacency list of the vertex
                    outDegree = _AdjacenecyList[vertex].Count;
                }

                return outDegree;  // Return the total outdegree of the vertex
            }
        }


        static void Main(string[] args)
        {

            // Create a list of vertices with string labels
            List<string> vertices = new List<string> { "A", "B", "C", "D", "E" };

            // Example 1 in Slides: Undirected Graph
            Graph graph1 = new Graph(vertices, Graph.eType.eUndirected);

            // Add some edges with default weights=1 between vertices
            graph1.AddEdje("A", "B", 1);
            graph1.AddEdje("A", "C", 1);
            graph1.AddEdje("B", "D", 1);
            graph1.AddEdje("C", "D", 1);
            graph1.AddEdje("B", "E", 1);
            graph1.AddEdje("D", "E", 1);

            // Display the adjacency list to visualize the graph
            graph1.DisplayGraph("Adjacency List for Example1 (Undirected Graph):");

            Console.WriteLine("\n------------------------------\n");

            // Example 2 in Slides: Directed Graph
            Graph graph2 = new Graph(vertices, Graph.eType.eDirected);

            // Add some edges with weights between vertices
            graph2.AddEdje("A", "A", 1);
            graph2.AddEdje("A", "B", 1);
            graph2.AddEdje("A", "C", 1);
            graph2.AddEdje("B", "E", 1);
            graph2.AddEdje("D", "B", 1);
            graph2.AddEdje("D", "C", 1);
            graph2.AddEdje("D", "E", 1);

            // Display the adjacency list to visualize the graph
            graph2.DisplayGraph("Adjacency List for Example2 (Directed Graph):");

            // Get and display the indegree and outdegree of vertex 'D'
            Console.WriteLine("\nInDegree of vertex D: " + graph2.GetInDegree("D"));
            Console.WriteLine("\nOutDegree of vertex D: " + graph2.GetOutDegree("D"));

            Console.WriteLine("\n------------------------------\n");

            // Example 3 in Slides: Weighted Graph
            Graph graph3 = new Graph(vertices, Graph.eType.eUndirected);

            // Add some edges with weights between vertices
            graph3.AddEdje("A", "B", 5);
            graph3.AddEdje("A", "C", 3);
            graph3.AddEdje("B", "D", 12);
            graph3.AddEdje("C", "D", 10);
            graph3.AddEdje("B", "E", 2);
            graph3.AddEdje("D", "E", 7);

            // Display the adjacency list to visualize the graph
            graph3.DisplayGraph("Adjacency List for Example3 (Weighted Graph):");

            // Check if there is an edge between 'A' and 'B' and display the result
            Console.WriteLine("\nIs there an edge between A and B in Graph3? " + graph3.IsEdje("A", "B"));

            // Remove the edge between 'E' and 'D'
            graph3.RemoveEdje("E", "D");

            // Display the updated adjacency list after removing the edge
            graph3.DisplayGraph("After Removing Edge between E and D:");

            Console.ReadKey();

        }
    }
}
