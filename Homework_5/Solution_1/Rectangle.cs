using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Rectangle
    {
        public Rectangle()
        {
            Console.Write("Please Enter the length: ");
            length = UserInput.AcceptNumberInput();
            Console.Write("Please enter the width: ");
            width = UserInput.AcceptNumberInput();

        }
        private double length { set; get; }
        private double width { get; set; }
        public void FindAreaR()
        {
            double arear = length * width;
            Console.WriteLine("Area of the rectangle: " + arear);
        }
    }
}
