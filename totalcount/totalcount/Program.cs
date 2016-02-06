using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalcount
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputnum, i;
            int n;
            Console.WriteLine("Enter the totalcount : ");
            n = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("enter the operation :");
             string oper = Console.ReadLine();
            if (oper == "add")
            {
                int r = 0;
                for (i = 0; i < n; i++)
                {
                    Console.WriteLine("Enter the number " + (i + 1));
                    inputnum = Int32.Parse(Console.ReadLine());
                    
                    r = r + inputnum;

                }
                Console.WriteLine(r);
            }
            else if(oper == "multiply")
            {
                int r = 1;
                for(i=0;i< n;i++)
                {
                    Console.WriteLine("Enter the number " + (i + 1));
                    inputnum = Int32.Parse(Console.ReadLine());
                   
                    r = r * inputnum;

                }
                Console.WriteLine(r);
            }
        }
    }
}
