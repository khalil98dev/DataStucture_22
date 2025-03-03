using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList Numbers = new ArrayList();


            Numbers.Add(1);
            Numbers.Add(2);
            Numbers.Add(3);
            Numbers.Add(5);
            Numbers.Add(16);
            Numbers.Add(1);
            Numbers.Add(11);
            Numbers.Add(13);
            Numbers.Add(12);


            int Sum = Numbers.Cast<int>().Sum();
            double Average = Numbers.Cast<int>().Average();

            int Max = Numbers.Cast<int>().Max();    
            int Min = Numbers.Cast<int>().Min();


            int TargetNumber = 1; 

            int CounttheTargetnumber = Numbers.Cast<int>().Count(n=>n== TargetNumber);

            var OddNumbers = Numbers.Cast<int>().Where(n => n%2 == 0); 
            var EvenNumbers = Numbers.Cast<int>().Where(n => n % 2 ==1);


            Console.WriteLine("List array elements :");

            foreach (var i in Numbers)
            {
                Console.WriteLine(i.ToString());    

            }


            Console.WriteLine($"\n\nSum : {Sum}");
            Console.WriteLine($"\n\nAverage : {Average}");
            Console.WriteLine($"\n\nMax : {Max}");
            Console.WriteLine($"\n\nMin : {Min}");
            Console.WriteLine($"\n\nTarget Number Count : {CounttheTargetnumber}");


            Console.WriteLine("Odd numbers: ");

            foreach (var i in OddNumbers)
            {
                Console.WriteLine($"{i.ToString()}");   
            }


            Console.WriteLine("Even numbers: ");

            foreach (var i in EvenNumbers)
            {
                Console.WriteLine($"{i.ToString()}");
            }





            Console.ReadLine(); 





        }
    }
}
