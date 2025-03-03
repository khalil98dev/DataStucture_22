using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SortedSets
{
    internal class Program
    {
        public class Employee : IComparable<Employee>
        { 
            public string EmployeeName { get; set; }

            public float Salary { get; set; }
        
            public int EmployeeId { get; set; } 
            
            public Employee(string EmployeeName, float Salary, int EmployeeId)
            {
                this.EmployeeName= EmployeeName;
                this.Salary = Salary;
                this.EmployeeId = EmployeeId;
            }

        public int CompareTo(Employee other)
        {
            if (other == null) return 1;
            return this.EmployeeId.CompareTo(other.EmployeeId);
        }



    }


        static void Main(string[] args)
        {
            SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };

            SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };


            // Union
            SortedSet<int> unionSet = new SortedSet<int>(set1);
            unionSet.UnionWith(set2);
            Console.WriteLine("\nUnion:");
            foreach (int item in unionSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            SortedSet<int> SymetricExpectWith = new SortedSet<int>(set1);

            SymetricExpectWith.SymmetricExceptWith(set2);

            Console.WriteLine("\nSymmetric:");
            foreach (int item in SymetricExpectWith)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            // Intersection
            SortedSet<int> intersectSet = new SortedSet<int>(set1);
            intersectSet.IntersectWith(set2);
            Console.WriteLine("\nIntersection:");
            foreach (int item in intersectSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Difference
            SortedSet<int> differenceSet = new SortedSet<int>(set1);
            differenceSet.ExceptWith(set2);
            Console.WriteLine("\nDifference (set1 - set2):");
            foreach (int item in differenceSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Subset and Superset
            Console.WriteLine("\nSubset:");
            if (set1.IsSubsetOf(set2))
                Console.WriteLine("Set1 is a subset of Set2");
            else
                Console.WriteLine("Set1 is not a subset of Set2");


            Console.WriteLine("\nSuperset:");
            if (set1.IsSupersetOf(set2))
                Console.WriteLine("Set1 is a superset of Set2");
            else
                Console.WriteLine("Set1 is not a superset of Set2");





            //Check equalit of sets or SubSet Or SuperSet 


            SortedSet<string> Commands = new SortedSet<string>()
            {
                "khalil",
                "Mohamed",
                "khalil",
                "khaled"
            };


            SortedSet<string> CommandsTwo= new SortedSet<string>()
            {
                "khalil",
                "Mohamed",
                "khalil",
                "khaled",
                "Adem"
            };

           //Hello khalil bachir i want to implement


            Console.WriteLine((Commands.SetEquals(CommandsTwo)) ? "Yes, the two sets are equals" : "No, the sets are not equals"); 
            Console.WriteLine((CommandsTwo.IsSupersetOf(Commands)) ? "Yes, the First set is SubSet of the Second Set" : "No, the sets are not equals"); 

            Console.ReadKey();
        }
    }
}

