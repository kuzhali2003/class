using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array : ");
            var inputsize = Int32.Parse(Console.ReadLine());

            int[] numbarray = new int[inputsize];
            int i = 0;
            while (i < numbarray.Length) 
            { 
                Console.Write("enter the value at index " + 0 + ":");
                numbarray[i] = Int32.Parse(Console.ReadLine());
                i++;
            }
            Array.Sort(numbarray);
            for ( i = 0; i < numbarray.Length; i++)
            {
                Console.WriteLine(numbarray[i]);
            }
           
                Console.WriteLine("Reverse sorted array : ");
            for (i = numbarray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(numbarray[i]);
                
            }

        }

    }
}
