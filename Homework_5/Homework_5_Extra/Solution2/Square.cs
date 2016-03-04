using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Square
    {
        // public double area ;
        private readonly string type;
        public Square()
        {
            Console.Write("Type of value being entered (Dimension/Area): ");
            type = Console.ReadLine().ToUpper();

            while (true)
            {
                if (type == "DIMENSION")
                {
                    Console.Write("Please enter the length of the side of the Square:");
                    Sideofsquare = UserInput.AcceptNumberInput();
                    break;
                }
                else if (type == "AREA")
                {
                    Console.Write("Please enter the area of  Square:");
                    area = UserInput.AcceptNumberInput();
                    break;
                }

                else
                    Console.WriteLine("Please enter valid input: ");
                break;
            }

        }
        public double Sideofsquare { get; set; }

        public double area { get; set; }
        public void FindSideOrDimension()
        {
            if (type == "AREA")
            {
                double squareroot = Math.Round(Math.Sqrt(area));
                Console.WriteLine("Side of the Square: " + squareroot);
            }
            else
            {
                double Area1 = Sideofsquare * Sideofsquare;
                Console.WriteLine("Area of the square = " + Area1);
            }
        }

    }
}
