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
    class Triangle
    {
        public Triangle()
        {
            Console.Write("Please Enter the base:  ");
            baseb = Int32.Parse(Console.ReadLine());
            Console.Write("Please enter the height: ");
            height = Int32.Parse(Console.ReadLine());
        }

        public int baseb { get; set; }
        public int height { get; set; }

        public void FindAreaT()
        {
            double areaT = .5 * baseb * height;
            Console.WriteLine("Area of the Triangle: " + areaT);
        }

    }
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



    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an Option: Circle/Square/Rectangle/Triangle/Quit : ");
            string option = Console.ReadLine().ToUpper();
            
                while(true)
                  

                if (option == "Circle")
                {
                    Circle objcircle1 = new Circle();
                    objcircle1.FindArea();

                    
                }
                else if (option == "Square")
                {
                    Square objsquare = new Square();
                    objsquare.FindAreaS();
                    

                }
                else if (option == "Rectangle")
                {
                    Rectangle objrect = new Rectangle();
                    objrect.FindAreaR();
                    

                }
                else if (option == "Triangle")
                {

                    Triangle objtri = new Triangle();
                    objtri.FindAreaT();
                    
                }
                else if (option == "Quit")

                    Console.WriteLine("Thankyou! Bye Bye !");

            
        }
    }
}

