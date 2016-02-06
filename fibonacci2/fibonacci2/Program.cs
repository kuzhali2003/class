using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1,e1,i;
            int f1, f2 ,f3;
            Console.WriteLine("Enter starting number : ");
            s1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter ending number : ");
            e1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("fibonacci series : ");

            f1 = 0;
                
                f2 = 1;
          
          
                Console.WriteLine(f1);
                Console.WriteLine(f2);
           
            
            
                for (i = s1; i <= e1; i++)
                {


                    f3 = f1 + f2;
                    f1 = f2;
                    f2 = f3;

                    if (f3 >= s1 && f3 >= e1)
                    { break; }
                    Console.WriteLine(f3);
            

                
                

          


            }

        }
    }
}
