using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_Union
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> PhoneNumbers1 = new HashSet<string>()
            { "0771278844","0667503327","0778541666","0569872332"};

            HashSet<string> PhoneNumbers2 = new HashSet<string>()
            { "0771278844","0667503327","0778541666","0799432516"};

             HashSet<string> PhoneNumbers3 = new HashSet<string>()
            { "0771278844","0667503327","0778541666","0799432516"};


            // PhoneNumbers1.UnionWith(PhoneNumbers2);   
            // PhoneNumbers1.IntersectWith(PhoneNumbers2);
            //Deferences

            // PhoneNumbers1.ExceptWith(PhoneNumbers2);    


            //foreach (var phoneNumber in PhoneNumbers1)
            //{
            //    Console.WriteLine(phoneNumber);
            //}

            Console.WriteLine($"Is Phones1 Equal Phones2? {PhoneNumbers1.SetEquals(PhoneNumbers2)}");
            Console.WriteLine($"Is Phones2 Equal Phones3? {PhoneNumbers2.SetEquals(PhoneNumbers3)}");





            Console.ReadLine();
        }
    }
}
