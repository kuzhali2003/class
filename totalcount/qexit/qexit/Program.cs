using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qexit
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; true; i++)
            {


                Console.Write("Enter the Number : ");
                string input = Console.ReadLine().ToUpper();
                if (input == "Q")
                { 
                    Console.WriteLine("Thank you.Bye Bye! ");
                break; }
                else
                {
                    int num = Convert.ToInt32(input); 
                    
                    Console.WriteLine(num);
                }
            }

                  
          
                
                  
             
                 
                
            
                  
                    
            
         }
    }
}
