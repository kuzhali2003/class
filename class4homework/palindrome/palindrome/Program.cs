using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a string(Q : Exit) : ");
            string s = Console.ReadLine().ToUpper();
            if (s  == "Q")
            { 
                Console.WriteLine("Thank you!Bye Bye. ");
             }
            
            else
            {
                char[] rev = s.ToCharArray();
                Array.Reverse(rev);
                string revs = new string(rev);
                if (s.Equals(revs))
                    Console.WriteLine(s + " is a palindrome. ");
                else
                    Console.WriteLine(s + " is not a palindrome. ");
            }
        }
    }
}
