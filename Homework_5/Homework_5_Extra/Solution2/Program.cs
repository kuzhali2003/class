using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the type of shape (Circle/Square/Quit): ");
            string shape = Console.ReadLine().ToUpper();

            while (true)
            {
                if (shape == "SQUARE")
                {
                    Square objsquare = new Square();
                    objsquare.FindSideOrDimension();
                    break;
                }
                else if (shape == "CIRCLE")
                {
                    Circle objcircle = new Circle();
                    objcircle.FindAreaOrDimension();
                    break;
                }
                else if (shape == "QUIT")
                {
                    Console.WriteLine("Bye Bye");
                    break;
                }
                else
                    Console.WriteLine("Please enter valid input: ");
                break;
            }
        }
    }
}