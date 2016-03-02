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
            Console.Write("Type of value being entered (Dimension/Area): ");
            string type = Console.ReadLine().ToUpper();
            while (shape == "SQUARE")
            {
                if ((shape == "SQUARE") && (type == "DIMENSION"))

                {
                    Square objsquare = new Square();
                    objsquare.FindArea();
                }

                else
                {
                    Area objsquare1 = new Area();
                    objsquare1.FindSide();
                }
                while (shape == "CIRCLE")
                {
                    if ((shape == "CIRCLE") && (type == "DIMENSION"))
                    {
                        Circle objcircle = new Circle();
                        objcircle.FindArea();
                    }
                    else
                    {
                        CircleArea objcir = new CircleArea();
                        objcir.FindRadius();
                    }
                }
            }
        }
    }
}