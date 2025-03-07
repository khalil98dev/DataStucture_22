using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArrray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 3 };

            Array.Sort(numbers);


            Console.WriteLine("Sorted array:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }


            string[] Users = { "khalil", "Anis", "koko", "Aymen", "Yasmine", "Ines" };

            int SearchedIndex = Array.IndexOf(Users, "Ines");


            // MultiDimentional Array : 

            int[,] ints = 
            {
                {1,2,3,4,5,6 },{5,7,8,9,10,5},{1,2,3,4,6,7 },{5,7,8,9,10,11}
               
           
            };


            

            int[][] JaggedArray =
            {
                new int[]{1,2,3},
                new int[]{1,2,3,5},
                new int[]{1,2,3}
      

            };



//            int[][] JaggedArray2 = new int[3][];

//            JaggedArray2[0][0] = 1;
//            JaggedArray2[0][1] = 2;
//;
            int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 } };


            //int result = Array.IndexOf(numbers, 4);




            //Copy Array; 

            string[] koko = new string[Users.Length];
            Array.Copy(Users, koko, Users.Length);

            Console.WriteLine("Print copy array elements");
            for (int i = 0; i < koko.Length; i++)
            {
                Console.WriteLine(koko[i]); 
            }

            Console.WriteLine($"Searcher value is: {SearchedIndex+1}");

            //Linq with Array 

            var result  = koko.Where(x => x != "khalil");
            Console.WriteLine("Print  array elements with Condition ");
            foreach (var item in result)
            {
                Console.WriteLine("- "+item);
            }


            var result2 = koko.Select(x => x == "khalil");
            Console.WriteLine("Print  array elements with Condition ");
            foreach (var item in result2)
            {
                Console.WriteLine("- " + item);
            }

            int[] num = { 1, 2, 5, 4, 6, 9, 87, 4, 56, 4 };


            Console.WriteLine("numbers before select: ");
            Array.Sort(num);
            for (int i = 0;i < num.Length;i++)
            {
                Console.WriteLine(num[i]);  
            }
            var result3 = num.Select(n=>n*2);
            
            
            Console.WriteLine("Numbers multiplied by 2:");

            foreach (var item in result3)
            {
                Console.WriteLine(" - " + item);
            }





            Console.ReadLine(); 
        }
    }
}
