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
            int radius = Int32.Parse(Console.ReadLine());
            int radr1 = radius;

        }
           public int radr1 { get; set; } = 5;

            public  void  FindArea()
        {
            double area = 3.14 * (radr1 * radr1);

            Console.WriteLine("Area of the circle = " + area);
        
            
        }
    }


    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an option circle/square/rect/triangle/quit : ");
            string option = Console.ReadLine();
            Circle objcircle1 = new Circle();
            objcircle1.FindArea();


        }
    }
}
