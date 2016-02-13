using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program5homework
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; true; i++)
            {
                string input;
                Console.Write("Enter the Number : (enter Q to exit) : ");
                input = Console.ReadLine();
                if (input == "Q")

                {
                    Console.WriteLine("Thank you.Bye Bye! ");
                    break;
                }
                else
                {
                    int num;
                    num = Convert.ToInt32(input);



                    if (num % 30 == 0)

                        Console.WriteLine(num + " is a multiple of 30 , 15, 3 ");

                    else if

                        (num % 15 == 0 && num % 3 == 0)

                        Console.WriteLine(num + " is a multiple of 15, 3 ");

                    else if

                        (num % 3 == 0)
                        Console.WriteLine(num + " is a multiple of 3 ");

                    else

                        Console.WriteLine(num + " is not a multiple of 3, 15, 30 ");
                }
                
            }       
          }
        }
    }

