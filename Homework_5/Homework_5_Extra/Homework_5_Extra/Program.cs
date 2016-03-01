using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_Extra
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";

            while (true)
            {
                Console.Write("Please enter the type of the vehicle (Bike/Car/Train/Plane/Quit): ");
                result = Console.ReadLine().ToUpper();
                if (result == "BIKE")
                    Console.WriteLine(Bike.message);
                else if (result == "CAR")
                    Console.WriteLine(Car.message);
                else if (result == "PLANE")
                    Console.WriteLine(Plane.message);
                else if (result == "TRAIN")
                    Console.WriteLine(Train.message);
                else if (result == "QUIT")
                { Console.WriteLine("Bye Bye");
                break; }
                else 
                    Console.WriteLine("Please enter valid input: ");
            }

        }
    }
}