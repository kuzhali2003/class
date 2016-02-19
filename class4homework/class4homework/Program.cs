using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class4homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name ?  ");
            string samplename = Console.ReadLine();
           //Console.WriteLine("string length : " + samplename.Length);
            //Console.WriteLine(samplename.Substring(11));
            var samplestring = samplename.Substring(11, samplename.Length-11);
            Console.WriteLine("Hi " + samplestring + ". "+ "what are you doing today ? ");
            Console.ReadLine();
        }
    }
}
