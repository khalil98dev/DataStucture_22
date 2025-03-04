using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JagedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //JagedArray: 

            int[][] Table =
            {
               new int [] { 1,2,3,4,5  },
               new int [] {2,5,4 },
               new int [] {1,5,6 }
            };
           


            for (int i = 0; i < Table.Length; i++) 
            { 
                for (int j = 0; j < Table[i].Length; j++) 
                {
                    Console.WriteLine(Table[i][j]); 
                
                }
            
            }


            Console.ReadLine(); 

        }
    }
}
