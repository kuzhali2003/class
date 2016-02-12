using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4homeworkclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = " ";
            while (true)
            {
                Console.Write("Enter your input here : ");
                var input = (Console.ReadLine());
                Console.Write("Do you want to continue Y/N ? ");
                var decision = Console.ReadLine().ToUpper() == "Y";
                result = result+" " + input;
                result=result + "\n";
                if (!decision)
                {
                    Console.WriteLine(result +" "+ "Thank you. Bye Bye!" );
                    
                    break;
                }
            }
        }
    }
}
