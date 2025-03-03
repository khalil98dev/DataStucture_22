using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArrays
{
    internal class Program
    {
        static string BitToString(BitArray Bits)
        {
            char[] chars = new char[Bits.Length];

           
            for (int i = 0; i < Bits.Length; i++)
            {
                chars[i] = (Bits[i]) ?'1' :'0' ;  
            }
            
            return new string(chars);
        }

        static void Main(string[] args)
        {
            BitArray arr1 = new BitArray(11);



            arr1.SetAll(true);
            arr1[2] = false;
            arr1.Set(1, false);






            Console.WriteLine("Bits Contents: " + BitToString(arr1));





            //Byte array 

            byte[] bytearr = {0xAA,0x33};



            BitArray arr2 = new BitArray(bytearr);

            Console.WriteLine($"Content of an array from byte => {BitToString(arr2)}");


            Console.ReadLine();
        }
    }
}
