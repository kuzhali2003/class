using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Square
    {
        public Square()
        {
            Console.Write("Please enter the side: ");
            side = UserInput.AcceptNumberInput();

        }
        private double side { get; set; }

        public void FindAreaS()
        {
            double areaa = side * side;
            Console.WriteLine("Area of the square = " + areaa);
        }

    }
}
