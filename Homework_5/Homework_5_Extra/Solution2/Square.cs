using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Square
    {
        private double side, area;
        public Square()
        {
            Console.Write("Type of value being entered (Dimension/Area): ");
            string type = Console.ReadLine().ToUpper();
            if (type == "DIMENSION")
            {
                Console.Write("Please enter the length of the side of the Square:");
                Side = UserInput.AcceptNumberInput();
                FindArea();
            }
            else if(type=="AREA")
            {
                Console.Write("Please enter the area of  Square:");
                area = UserInput.AcceptNumberInput();
                FindSide();
            }
            else
                Console.WriteLine("Please enter valid input: ");
        }
        
        public void FindSide()
        {
            double squareroot = Math.Round(Math.Sqrt(area));
            Console.WriteLine("Side of the Square: " + squareroot);
        }

         public  double Side{ get; set; }
        
        public void FindArea()
        {
            double area = Side * Side;
            Console.WriteLine("Area of the square = " + area);
        }

    }
}
