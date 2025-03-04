using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_Exerceices
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // List integers
            //List<int> list = new List<int>()
            //{
            //    1,1,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,2,3,4,5,6
            //};

            //HashSet<int> set = new HashSet<int>();

            //list.ForEach(x =>set.Add(x) );

            //list = set.ToList();


            //list.ForEach(x => Console.WriteLine(x));
            //Find Common Members in List 


            //HashSet<int> list = new HashSet<int>() { 1, 2, 3, 4, 5, 6 }; 
            //HashSet<int> list2 = new HashSet<int>() { 1, 2, 3, 7,8,9 };

            ////Comon 

            ////list.IntersectWith(list2);

            ////Delete Common From List 
            //list.SymmetricExceptWith(list2);

            ////Substract list one from list two
            //// list.ExceptWith(list2);




            //list.ToList().ForEach(x => { Console.WriteLine(x); });

            List<string> list = new List<string>()
            {
                "Aymen",
                "Oussama",
                "Anis",
                "Yehya",
                "khaled",
                "Ines"
            };

            List<string> list2 = list.Where(word=>word.Distinct().Count() == word.Length).ToList();
           


            Console.WriteLine(string.Join(", ", list2)); 

            //HashSet<string> FiltredNames = new HashSet<string>();
            //foreach (string item in list)
            //{

            //    HashSet<char> FiltredCharachters = new HashSet<char>();
            //    foreach (char name in item) 
            //    {
            //        FiltredCharachters.Add(name);
                
            //    }

            //    if(FiltredCharachters.Count == item.Length)
            //        FiltredNames.Add(item);
            //}
            
            



            Console.ReadLine();

        }
    }
}
