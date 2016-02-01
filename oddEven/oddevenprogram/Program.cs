using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oddevenprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int f1;
            int s2;
            Console.WriteLine("Enter the first number : ");
            f1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second Number : ");
            s2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Pattern : ");
            string name=Console.ReadLine();
            if (name=="odd")
            {
                for (f1 = 0; f1 < s2; f1++)
                {
                    if (f1 % 2 > 0)
                    
                        Console.WriteLine(f1);
                    
                }
            }
            else if (name=="even")
            {
                for (f1 = 0; f1 < s2; f1++)
                {
                    if (f1 % 2 == 0)

                        Console.WriteLine(f1); 
                    
                }
            }

            
        }
    }
}
