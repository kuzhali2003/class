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
                
                string input;
                Console.Write("Enter the Number : ");
                  input = Console.ReadLine();
                if(input == "Q")
                    
                    Console.WriteLine("Thank you.Bye Bye! ");
                else
                {
                    int num = Convert.ToInt32(input); 
                    
                    Console.WriteLine(num);
                }
            }

                  
          
                
                  
             
                 
                
            
                  
                    
            
         }
    }
}
