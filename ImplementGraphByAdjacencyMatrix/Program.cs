using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ImplementGraphByAdjacencyMatrix
{
    internal class Program
    {
        public class WeightObj
        {
            int Weight { get; set; }
            public string relation { get; set; }    

            public WeightObj(int Weight)
            {
                this.Weight = Weight;


            }

            public WeightObj()
            {
                
            }

            public WeightObj(string relation) 
            {
                this.relation = relation;
            }


            public override string ToString()
            {
                
                return relation??"not";
            }
        }
        [Description("The firt T templae value for the vertcies Data type and the second Tt for the Weight Object Type")]
        public class Graph<T>
        {
            public enum eGraphType { eDirected = 1, eUndirected = 2 }
            private eGraphType Type { get; set; }

            private WeightObj[,] _AdjacencyMatrix { get; set; }

            private Dictionary<T, int> _VarticiesDictionary { get; set; }

            private int _MatrixRowsColumn { get; set; }


            public Graph(List<T> ListOfVetricies, eGraphType Type)
            {
                _MatrixRowsColumn = ListOfVetricies.Count;

                this.Type = Type;

                //Make a dictionary full with Verticies; 

                _VarticiesDictionary = new Dictionary<T, int>();
                for (int i = 0; i < _MatrixRowsColumn; i++)
                {
                    _VarticiesDictionary.Add(ListOfVetricies[i], i);

                }

                //Create the matrix value; 
                _AdjacencyMatrix = new WeightObj[_MatrixRowsColumn, _MatrixRowsColumn];


            }




            public void AddEdje(T Source, T Distination, WeightObj Weight)
            {
                if (!(_VarticiesDictionary.ContainsKey(Source) && _VarticiesDictionary.ContainsKey(Distination)))
                {
                    Console.WriteLine($"We cant add {Source} => {Distination} EDJE");
                    return;
                }

                _VarticiesDictionary.TryGetValue(Source, out int SourceIndex);
                _VarticiesDictionary.TryGetValue(Distination, out int DistinationIndex);


                _AdjacencyMatrix[SourceIndex, DistinationIndex] = Weight;


                if (this.Type == eGraphType.eUndirected)
                {
                    _AdjacencyMatrix[DistinationIndex, SourceIndex] = Weight;
                }
                else
                {
                    _AdjacencyMatrix[DistinationIndex, SourceIndex] = null;
                }

            }

            public void Display()
            {
                string Space = "\t\t";
                int SourceIndex = 0, DistinationIndex = 0;
                //Print Head
                for (int j = 0; j < _MatrixRowsColumn; j++)
                {
                    string key = _VarticiesDictionary.FirstOrDefault(kpv => kpv.Value == j).Key.ToString();

                    Console.Write(Space + " " + key);
                }
                //Iterat inside the matrix to print all values 
                for (int i = 0; i < _MatrixRowsColumn; ++i)
                {
                    SourceIndex = i;
                    string key = _VarticiesDictionary.FirstOrDefault(kpv => kpv.Value == i).Key.ToString();

                    Console.Write("\n" + key);
                    DistinationIndex = 0;
                    for (int k = 0; k < _MatrixRowsColumn; ++k)
                    {
                        var value = _AdjacencyMatrix[SourceIndex, DistinationIndex];

                        if (value == null)
                        {
                            value = new WeightObj("not");
                        }

                        Console.Write(Space + " " + value.ToString());
                        DistinationIndex++;
                    }



                    Console.WriteLine(Space);
                }

            }
        
            public void RemoveEdje(T Source, T Distination)
            {
                AddEdje(Source, Distination, null);
            }
        

            public int GetInDegree(T item)
            {
                _VarticiesDictionary.TryGetValue(item, out int IndexOfItem);

                int InDegree = 0; 
                for(int i=0; i < _MatrixRowsColumn;i++)
                {
                    if (_AdjacencyMatrix[IndexOfItem,i]!=null)
                    {
                        InDegree++;
                    }
                }

                return InDegree; 
            }

            public int GetOutDegree(T item)
            {
                _VarticiesDictionary.TryGetValue(item, out int IndexOfItem);

                int OutDegree = 0;
                for (int i = 0; i < _MatrixRowsColumn; i++)
                {
                    if (_AdjacencyMatrix[i, IndexOfItem] != null)
                    {
                        OutDegree++;
                    }
                }

                return OutDegree;
            }


        }



        static void Main(string[] args)
        {
            List<string> Verticies = new List<string>()
            {
                "A","B","C","D"
            };


            Graph<string> myGraph = new
                Graph<string>(Verticies, Graph<string>.eGraphType.eUndirected);


            myGraph.AddEdje("A", "B", new WeightObj("Freind"));
            myGraph.AddEdje("A", "C", new WeightObj("Freind"));
            myGraph.AddEdje("B", "D", new WeightObj("Freind"));
            myGraph.AddEdje("C", "D", new WeightObj("Freind"));

            //before remove Adgjes 

            Console.WriteLine("Befaore remove Adgje");
            myGraph.Display();

            Console.WriteLine($"\n\n\nIn degree of 'A' = {myGraph.GetInDegree("A")}");
            Console.WriteLine($"Out degree of 'A' = {myGraph.GetInDegree("A")}");


            myGraph.RemoveEdje("A", "B");

            Console.WriteLine("\n\n\nAfter remove Adgje");
            myGraph.Display();
            Console.WriteLine($"\n\n\nIn degree of 'A' = {myGraph.GetInDegree("A")}");
            Console.WriteLine($"Out degree of 'A' = {myGraph.GetInDegree("A")}");
            //WeightObj myGraph2 = new WeightObj();  
            //Console.WriteLine(myGraph2.ToString());

            Console.ReadLine(); 
        }
    }
}
