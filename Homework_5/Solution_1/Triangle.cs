using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Triangle
    {


        public Triangle()

        {
            Console.Write("Please enter the base: ");
            baseb = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the height: ");
            height = Int32.Parse(Console.ReadLine());
        }

        public int baseb { get; set; }
        public int height { get; set; }

        public void FindAreaT()
        {

            double areaT= .5 * baseb * height;
            Console.WriteLine("Area of the circle = " + areaT);
        }


    }
}


    


