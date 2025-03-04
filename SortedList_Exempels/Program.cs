using System;
using System.Collections.Generic;
using System.Linq;


namespace SortedList_Exempels
{
    internal class Program
    {
        public class Employee
        {
        

            public string Name { get; set; }
            public decimal Salary { get; set; }
            public string Departement { get; set; }

            public Employee(string Name,string Departement,decimal salary ) 
            { 
                this.Name = Name;
                this.Salary = salary;
                this.Departement = Departement;
            }

        }






        static void Main(string[] args)
        {

            SortedList<int, Employee> Employees = new SortedList<int, Employee>()
            {
                { 1, new Employee("Alice Johnson", "HR", 45000m) },
            { 2, new Employee("Bob Smith", "IT", 60000m) },
            { 3, new Employee("Charlie Davis", "Finance", 55000m) },
            { 4, new Employee("David White", "Marketing", 50000m) },
            { 5, new Employee("Emma Brown", "Sales", 52000m) },
            { 6, new Employee("Frank Wilson", "HR", 48000m) },
            { 7, new Employee("Grace Moore", "IT", 62000m) },
            { 8, new Employee("Helen Taylor", "Finance", 58000m) },
            { 9, new Employee("Ian Anderson", "Marketing", 51000m) },
            { 10, new Employee("Jack Thomas", "Sales", 53000m) },
            { 11, new Employee("Liam Carter", "HR", 46000m) },
            { 12, new Employee("Sophia Hall", "IT", 61000m) },
            { 13, new Employee("Mason Wright", "Finance", 56000m) },
            { 14, new Employee("Olivia Lewis", "Marketing", 52000m) },
            { 15, new Employee("Noah Walker", "Sales", 54000m) },
            { 16, new Employee("Lucas Adams", "HR", 47000m) },
            { 17, new Employee("Amelia Scott", "IT", 63000m) },
            { 18, new Employee("Ethan Harris", "Finance", 57000m) },
            { 19, new Employee("Ava Martin", "Marketing", 53000m) },
            { 20, new Employee("James Nelson", "Sales", 55000m) },
            { 21, new Employee("Henry King", "HR", 49000m) },
            { 22, new Employee("Charlotte Rodriguez", "IT", 64000m) },
            { 23, new Employee("Benjamin Perez", "Finance", 59000m) },
            { 24, new Employee("Emily Johnson", "Marketing", 54000m) },
            { 25, new Employee("Daniel Martinez", "Sales", 56000m) },
            { 26, new Employee("Jacob Lee", "HR", 50000m) },
            { 27, new Employee("Ella Jackson", "IT", 65000m) },
            { 28, new Employee("Michael Hernandez", "Finance", 60000m) },
            { 29, new Employee("Harper Young", "Marketing", 55000m) },
            { 30, new Employee("Alexander Allen", "Sales", 57000m) },
            { 31, new Employee("Samuel Scott", "HR", 51000m) },
            { 32, new Employee("Isabella Wright", "IT", 66000m) },
            { 33, new Employee("William Green", "Finance", 61000m) },
            { 34, new Employee("Mia Baker", "Marketing", 56000m) },
            { 35, new Employee("Matthew Gonzalez", "Sales", 58000m) },
            { 36, new Employee("Sebastian Turner", "HR", 52000m) },
            { 37, new Employee("Abigail Carter", "IT", 67000m) },
            { 38, new Employee("Elijah Lewis", "Finance", 62000m) },
            { 39, new Employee("Luna Clark", "Marketing", 57000m) },
            { 40, new Employee("Maverick Walker", "Sales", 59000m) },
            { 41, new Employee("Zoey Adams", "HR", 53000m) },
            { 42, new Employee("Gabriel Hall", "IT", 68000m) },
            { 43, new Employee("Levi King", "Finance", 63000m) },
            { 44, new Employee("Scarlett Perez", "Marketing", 58000m) },
            { 45, new Employee("Mila Nelson", "Sales", 60000m) },
            { 46, new Employee("Evelyn Rodriguez", "HR", 54000m) },
            { 47, new Employee("Hudson Martinez", "IT", 69000m) },
            { 48, new Employee("Aria Lee", "Finance", 64000m) },
            { 49, new Employee("Julian Hernandez", "Marketing", 59000m) },
            { 50, new Employee("Penelope Young", "Sales", 61000m) },
            { 51, new Employee("Nathaniel Allen", "HR", 55000m) },
            { 52, new Employee("Stella Scott", "IT", 70000m) },
            { 53, new Employee("Dominic Wright", "Finance", 65000m) },
            { 54, new Employee("Victoria Green", "Marketing", 60000m) }
            };


            var AllEmployeesHadSalaryaboveof1000 =
                Employees.Where(kvp => kvp.Value.Salary > 1000).
                OrderByDescending(kpv => kpv.Value.Salary)
                .
                Select(kvp => kvp.Value.Name);


            Console.WriteLine("List of Employees: ");
            foreach (var Empl in AllEmployeesHadSalaryaboveof1000)
            {
                Console.WriteLine(string.Join(",", Empl));
            }




            var GroupEmployeePerDeparetement =
                Employees.
                OrderBy(kpv => kpv.Value.Salary).
                GroupBy(kvp => kvp.Value.Departement);

            Console.WriteLine("Employees Per Deparetements");
            foreach (var Departement in GroupEmployeePerDeparetement)
            {
                Console.WriteLine(Departement.Key);
                Console.WriteLine("Total Salaries: "+Departement.Sum(s=>s.Value.Salary));
                Console.WriteLine("Max Salary: "+Departement.Max(s=>s.Value.Salary));
                Console.WriteLine("Min Salary: "+Departement.Min(s=>s.Value.Salary));
                Console.WriteLine("Average Salary: "+Departement.Average(s=>s.Value.Salary));
                foreach (var Employee in Departement)
                {
                    Console.WriteLine("   - "+Employee.Value.Name + " Salary :" + Employee.Value.Salary );
                }
            }

            
            Console.Read();

        }
    }
}
