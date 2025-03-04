using System; 

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Boxin is the procecess of converting the value type to a refrece type 
            //this involve wrapping the value type like (int,float,char) in object 

            //Exemple: 
            int ValueType = 10;
            object RefType = ValueType;

            Console.WriteLine(ValueType); //call from stack 
            Console.WriteLine(RefType);// call from heap 

            Console.ReadLine(); 


        }
    }
}
