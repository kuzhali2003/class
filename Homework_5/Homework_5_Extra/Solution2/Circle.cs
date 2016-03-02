using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Circle
    {
        private double radius;
        public Circle()
        {
            Console.Write("Please enter the radius of the Circle: ");
            radius = UserInput.AcceptNumberInput();
        }
        public void FindArea()
        {

            double area = Math.PI * (radius * radius);
            Console.WriteLine("Area of the circle = " + area);
        }

    }
}
