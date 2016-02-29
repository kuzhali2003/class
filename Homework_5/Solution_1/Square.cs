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
            sides = Int32.Parse(Console.ReadLine());
        }
        public int sides { get; set; }

        public void FindAreaS()
        {
            double areaa = sides * sides;
            Console.WriteLine("Area of the square = " + areaa);
        }

    }
}
