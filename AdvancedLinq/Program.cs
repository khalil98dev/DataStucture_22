using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> fruitsCategory = new Dictionary<string, string>
            //      {
            //          { "Apple", "Tree" },
            //          { "Banana", "Herb" },
            //          { "Cherry", "Tree" },
            //          { "Strawberry", "Bush" },
            //          { "Raspberry", "Bush" }
            //      };

            //var Result = fruitsCategory.GroupBy(f =>f.Value);

            //foreach (var result in Result)
            //{
            //    Console.WriteLine($"Category: {result.Key}");
            //    foreach (var item in result)
            //    {
            //        Console.WriteLine($"    - {item.Key}");
            //    }
            //}


            Dictionary<string, string> Stor = new Dictionary<string, string>()
            {
                  {"Cahier64","Cahier" },
                  {"Cahier120","Cahier" },
                  {"Cahier96","Cahier" },
                  {"RedPen","Pen" },
                  {"GreenPen","Pen" },
                  {"YellowPen","Pen" },
                  {"A4Paper","Paper" },
                  {"A5Paper","Paper" },
                  {"A6Paper","Paper" },
                  {"A2Paper","Paper" },
            };

            var  StoreResult = Stor.GroupBy(Item => Item.Value);  
            foreach (var Category in StoreResult)
            {
                Console.WriteLine($"Categry: {Category.Key} Count({Category.ToList().Count})");

                foreach (var item in Category)
                {
                    Console.WriteLine($"     - {item.Key}");
                }
            }

            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "Apple", 5 },
            { "Banana", 2 },
            { "Orange", 7 }
        };


            var SortedFB = fruitBasket.
                                                Where(x => x.Value > 3)
                                                .OrderByDescending(x => x.Key)
                                                .Select(x => new {x.Key,x.Value});
            foreach (var item in SortedFB) 
            {
                Console.WriteLine($"item : {item.Key} ");
            }
                                                



            Console.ReadLine();


        }




    }
}
