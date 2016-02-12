using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace printwithoutn
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number to exit : ");
            int n = Int32.Parse(Console.ReadLine());
            
            for (int i=1; true; i++)
                
            {
                Console.WriteLine(i);
                if (i==n )
                    break;
        }
                
                       
                
            

        }
    }
}
