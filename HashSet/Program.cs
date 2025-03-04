using System;
using System.Collections.Generic;
using System.Linq;
namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet<string> list = new HashSet<string>();

            //list.Add("Banana");
            //list.Add("Banana");
            //list.Add("Banana");
            //list.Add("Banana");
            //list.Add("koko");
            //list.Add("Apple");
            //list.Add("Banana");
            //list.Add("Banana");
            //list.Add("Banana");




            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //list.Remove("Banana");

            //if (list.Contains("Banana"))
            //    Console.WriteLine("Banan is found");
            //else Console.WriteLine("Banana not found");





            //int[] number = { 1, 2, 3, 1, 2, 3,4, 1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3,5 };

            //HashSet<int> FiltredNumbers = new HashSet<int>();
            //number.ToList().ForEach(n => FiltredNumbers.Add(n));

            //FiltredNumbers.ToList().ForEach(Item=>Console.WriteLine(Item));


            HashSet<string> names = new HashSet<string> 
            { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };

            Console.WriteLine("All Names:");
            foreach (string name in names)
            {
                Console.WriteLine(" - " + name);
            }


            var StartWithE = names.Where(s => s.StartsWith("E"));
            Console.WriteLine("Names Start With E:");
            foreach (string name in StartWithE)
            {
                Console.WriteLine(" - " + name);
            }


            var EndWithA = names.Where(s => s.EndsWith("a"));
            Console.WriteLine("Names End With A:");
            foreach (string name in EndWithA)
            {
                Console.WriteLine(" - " + name);
            }


            var Length = names.Where(s => s.Length>4);
            Console.WriteLine("Names LEnght > 4 :");
            foreach (string name in Length)
            {
                Console.WriteLine(" - " + name);
            }





            Console.ReadLine();


        }
    }
}
