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
            length = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the width: ");
            width = Int32.Parse(Console.ReadLine());

        }
        public int length { set; get; }
        public int width { get; set; }
        public void FindAreaR()
        {
            double arear = length * width;
            Console.WriteLine("Area of the rectangle: " + arear);
        }
    }
}
