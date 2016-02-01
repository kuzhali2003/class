using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int r1;
            Console.WriteLine("Enter the N1 :");
            n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the N2 :");
            n2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the operation : ");
            string name = Console.ReadLine();
            if (name=="add")
            {
                r1 = n1 + n2;
                Console.WriteLine("Result : " + r1);
                Console.ReadLine();
                    }
            else if(name=="subtract")
            { r1 = n1 - n2;
                Console.WriteLine("Result : " + r1);
                Console.ReadLine();
            }
            else if(name=="multiply")
            { r1 = n1 * n2;
                Console.WriteLine("result : " + r1);
                Console.ReadLine();
            }
            else if(name=="divide")
            { r1  = n1 / n2;
                
               
                Console.WriteLine("Result : " + r1 );
                Console.ReadLine();
            }
                



        

        }
    }
}
