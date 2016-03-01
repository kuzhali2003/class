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
            baseb = UserInput.AcceptNumberInput();
            Console.Write("Please enter the height: ");
            height = UserInput.AcceptNumberInput();
        }

        private double baseb { get; set; }
        private double height { get; set; }

        public void FindAreaT()
        {

            double areaT= .5 * baseb * height;
            Console.WriteLine("Area of the Triangle = " + areaT);
        }


    }
}


    


