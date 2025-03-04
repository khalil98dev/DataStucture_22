using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unboxing is the inverse of boxing process 
            // is the process of extracting a value type from an object
            //The unboxing is critical processess ensure the type begin unboxing
            //matches the type of the object 

            //InvalidCastException 

            int ValurType = 10; 


            object objectValue = ValurType; //boxing

            int UnboxedValue = (int)objectValue;// unboxing 


           


        }
    }
}
