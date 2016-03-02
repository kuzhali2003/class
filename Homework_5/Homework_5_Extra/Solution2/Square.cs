using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
     class Square
    {
       
        public Square()
        {
            Console.Write("Please enter the length of the side of the Square:");
           Side = UserInput.AcceptNumberInput();
        }
       public  double Side{ get; set; }

        public  void FindArea()
        {
            double area = Side * Side;
            Console.WriteLine("Area of the square = " + area);
        }
       
    }
}
