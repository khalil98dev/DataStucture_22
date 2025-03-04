using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitWise
{
    internal class Program
    {
        static string BitArrayToString(BitArray data)
        {
            char[] Elements = new char[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                Elements[i] = (data[i]) ? '1' : '0'; 

            }

            return new string(Elements);    
        }
        static void Main(string[] args)
        {
            //
          BitArray Arr1 = new BitArray(8);
        //  BitArray Arr2 = new BitArray(new bool[] {true,true,false,true});

         Arr1.SetAll(false); 
        Arr1.Set(7,true); 

            Console.WriteLine(BitArrayToString(Arr1));


            //BitArray result =  new BitArray(Arr1);
            //result.Or(Arr2); 

            //Console.WriteLine($"Arr1 bit and Arr2 \n {BitArrayToString(result)}");

            //BitArray orResult = new BitArray(Arr1);
            //orResult.Xor(Arr2);   
            //Console.WriteLine($"Arr1 OR  Arr2 \n {BitArrayToString(orResult)}");


            //BitArray xoRResult = Arr1.Xor(Arr2);
            //Console.WriteLine($"Arr1 XOR Arr2 \n {BitArrayToString(xoRResult)}");

            //BitArray Not = new BitArray(Arr1);
            //Not.Not();  
            //Console.WriteLine($"not arr1 \n {BitArrayToString(xoRResult)}");




            Console.ReadKey();  


        }
    }
}
