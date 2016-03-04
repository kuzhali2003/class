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
            string shape;

            while (true)
            {

                Console.Write("Please enter the type of shape (Circle/Square/Quit): ");
                shape = Console.ReadLine().ToUpper();


                if (shape == "SQUARE")

                {
                    Square objsquare = new Square();
                    objsquare.FindSideOrDimension();
                }

                else if (shape == "CIRCLE")
                {
                    Circle objcircle = new Circle();
                    objcircle.FindAreaOrDimension();
                }
                else if (shape == "QUIT")

                    Console.WriteLine("Bye Bye");

                else
                    Console.WriteLine("Please enter valid input: ");
            }
        }
    }
}
