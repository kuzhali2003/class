using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Circle

    {
       

        


            public Circle()

            {
                Console.Write("Please enter the radius: ");
                 radius = Int32.Parse(Console.ReadLine());
            }

            public int radius { get; set; }

            public void FindArea()
            {

                double area = 3.14 * (radius * radius);
                Console.WriteLine("Area of the circle = " + area);
            }


        
    }
}
