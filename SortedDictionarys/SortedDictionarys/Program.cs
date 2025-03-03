using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedDictionarys
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,int> CustomerID1 = new SortedDictionary<string, int>()
            {
                {"Pizza",1 },
                {"Cola",1 },
                {"Annanas",1 },
                {"Tacos Pollete",1 },
                {"Chapati",1 }
            };


            if (CustomerID1.All(kvp => kvp.Value == 1))
            {
                Console.WriteLine("yes this Customer All demmands are 1");

            }
            else
                Console.WriteLine("No ");



            CustomerID1.Add("Marini", 2); 


            Console.ReadLine();


        }
    }
}
