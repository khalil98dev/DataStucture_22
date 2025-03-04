using System;
using System.Collections.Generic;
using System.Linq;


namespace DictionaryAggregateFunctions
{
    internal class Program
        
    {


        static void Main(string[] args)
        {
            
            float SumOfMarks(Dictionary<string, float> ListOfStudent)
            {
                return ListOfStudent.Sum(s => s.Value); 
            }
            
            float AverageOfStudents(Dictionary<string, float> ListOfStudent)
            {
                return ListOfStudent.Average(s=>s.Value); 
            }

            void Print(IEnumerable<KeyValuePair<string, float>> Resulted)
            {
                foreach (KeyValuePair < string,float> student in Resulted)
                {
                    Console.WriteLine($"Student name: {student.Key}.. Student mark: {student.Value}");
                }
            }



            Dictionary<string, float> Students = new Dictionary<string, float>()
            {
                {"Ali",15},
                {"Moussa",11},
                {"khalid",17},
                {"Anis",5},
                {"Yousra",12},
                {"selma",13},
                {"Ayoub",10},
                {"yasser",15},
                {"Mohamed",20},
                {"khouloud",15},
                {"marina",12},
                {"yamina",20}

            };


            //Calcutae Sum of notes:
            Console.WriteLine($"Sum of Marks is: {SumOfMarks(Students)}");
            Console.WriteLine($"Average of Marks is: {AverageOfStudents(Students)}");
            //Print Student in order by mark ;
            var OrderedStudents = Students.OrderBy(s => s.Value);
            Print(OrderedStudents);


            Console.ReadKey();  

        }
    }
}
