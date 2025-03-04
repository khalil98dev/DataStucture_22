using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSets_IsSubSet
{
    internal class Program
    {
        static void Main(string[] args)
        {

            HashSet<int> NumbersCollectionOne = new HashSet<int>()
            {
                1,2,3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,16
            };

            HashSet<int> NumbersCollectionTwo = new HashSet<int>()
            {
                1,2,3,  5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15,16,18,19,18,17,1,5,6,7,8,9,
                10,11,12,13,14,16,4
            };

            


            Console.WriteLine(NumbersCollectionOne.IsSubsetOf(NumbersCollectionTwo));
            Console.WriteLine(NumbersCollectionTwo.IsSupersetOf(NumbersCollectionOne));


            HashSet<string> Concats = new HashSet<string>()
            {
                "Khalil","Mohamed","Anis"
            };

            HashSet<string> DriveContact = new HashSet<string>()
            {
                "Khalil","Omar","Oumnia","Ayoub","Moussa","Taher","khaoula","zineb","Mohamed","aridj",
                "Anayiiz","Anis"
            };


            Console.WriteLine(Concats.IsSubsetOf(DriveContact));


            Console.ReadLine();


        }
    }
}
