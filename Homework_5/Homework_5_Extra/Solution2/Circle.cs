using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Circle
    {
        private double radius, area;
        public Circle()
        {
            Console.Write("Type of value being entered (Dimension/Area): ");
            string type = Console.ReadLine().ToUpper();
            if (type == "DIMENSION")
            {
                Console.Write("Please enter the radius of the Circle: ");
                radius = UserInput.AcceptNumberInput();
                FindArea();

            }
            else if (type == "AREA")
            {
                Console.Write("Please enter the area of Circle: ");
                area = UserInput.AcceptNumberInput();
                FindRadius();
            }
            else
                Console.WriteLine("Enter a valid input");

        }
        public void FindArea()
        {

            double area = Math.PI * (radius * radius);
            Console.WriteLine("Area of the circle = " + area);
        }
        public void FindRadius()
        {
            double squareroot = Math.Round(Math.Sqrt(area / Math.PI));
            Console.WriteLine("radius of the circle: " + squareroot);
        }

    }
}
