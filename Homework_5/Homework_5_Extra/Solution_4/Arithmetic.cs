using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Solution_4
{
    class Arithmetic
    {
        public double ActualInput { get; set; }
        public string OperationType;

        public Arithmetic()
        {
            Console.Write("Please enter the type of operation (Square/Root/IsPrime):");
            OperationType = Console.ReadLine().ToUpper();
            if (OperationType == "SQUARE" || OperationType == "ROOT" || OperationType == "ISPRIME")
            {
                Console.WriteLine("Please enter a number : ");
                ActualInput = UserInput.AcceptNumberInput();
            }
            else
             Console.WriteLine("Enter a valid Input!");
           }
        public void Calculate()
        {
            if (OperationType == "SQUARE")
            {
                double result1 = ActualInput*ActualInput;
                Console.WriteLine("The square of " + ActualInput + "  is " + result1);
            }
            else if (OperationType == "ROOT")
            {
                double result2 = Math.Sqrt(ActualInput);
                Console.WriteLine(" The Root of " + ActualInput + " is " + result2);
            }
            else
            {
                int number = Convert.ToInt32(ActualInput);
                int result = CheckPrime.Check_Prime(number);
                if (result == 0)
                    Console.WriteLine("{0} is not a prime number", number);
                else
                    Console.WriteLine("{0} is  a prime number", number);

            }
        }
    }
}
