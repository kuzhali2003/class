using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the type of input (Number/Text/Quit):");
            string inputType = Console.ReadLine().ToUpper();
            if (inputType == "NUMBER")
            {
               Arithmetic objnew=new Arithmetic();
                objnew.Calculate();
            }
            else if (inputType == "TEXT")
            {
                TextHelper objtext=new TextHelper();
                objtext.FindText();
               }
            else if(inputType == "QUIT")
                Console.Write("Bye Bye!");
            else
            {
                Console.WriteLine("Please enter a valid input!");
            }
        }
    }
}
