using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please enter an Option: Circle/Square/Rectangle/Triangle/Quit : ");
                string option = Console.ReadLine().ToLower();

                if (option == "circle")
                {
                    Circle objcircle1 = new Circle();
                    objcircle1.FindArea();
                }

                else if (option == "square")
                {
                    Square objsquare = new Square();
                    objsquare.FindAreaS();
                }
                else if (option == "rectangle")
                {
                    Rectangle objrect = new Rectangle();
                    objrect.FindAreaR();

                }
                else if (option == "triangle")
                {

                    Triangle objtri = new Triangle();
                    objtri.FindAreaT();
                }
                else if (option == "quit")

                    Console.WriteLine("Thankyou! Bye Bye !");


            }
        }
    }
}

