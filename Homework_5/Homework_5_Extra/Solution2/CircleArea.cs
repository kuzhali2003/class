using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class CircleArea
    {
        public double area;
        public CircleArea()
        {
            Console.Write("Please enter the area of Circle: ");
            area = UserInput.AcceptNumberInput();
        }

        public void FindRadius()
        {
            double squareroot = Math.Round(Math.Sqrt(area/Math.PI));
            Console.WriteLine("radius of the circle: " + squareroot);
        }
    }
}
