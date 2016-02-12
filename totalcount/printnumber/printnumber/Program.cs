using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number to exit : ");
            int n = Int32.Parse(Console.ReadLine());
            int i = 1;
            while(i<=n)
            {
                Console.WriteLine(i);
                i = i + 1;

            }
        }
    }
}
