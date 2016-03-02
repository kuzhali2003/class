using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Area
    {
        public double area;
        public Area()
        {
            Console.Write("Please enter the area of  Square:");
            area = UserInput.AcceptNumberInput();
        }

        public void FindSide()
        {
            double squareroot = Math.Round(Math.Sqrt(area));
            Console.WriteLine("Side of the Square: " + squareroot);
        }
    }
}
