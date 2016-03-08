using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Solution_4
{
    class TextHelper
    {
        public string count { get; set; }
        public string input { get; set; }

        public TextHelper()
        {
            Console.Write("Please enter what you want to count (Char/Vowel): ");
            count = Console.ReadLine().ToLower();
            if (count == "char" || count == "vowel")
            {
                Console.Write("Please enter some text: ");
                input = Console.ReadLine().ToLower();
            }
            else
                Console.WriteLine("Please enter a valid option.");
        }

        public void FindText()
        {
            if (count == "char")
            {
                Console.WriteLine("The number of characters in " + input + " is " + (input.Length));
            }
            else
            {
                int total = 0;
                string sentence = input;
                for (int i = 0; i < sentence.Length; i++)
                {
                    if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' ||
                        sentence[i] == 'u')
                    {
                        total++;
                    }
                }
                Console.WriteLine("The number of vowels in  " + input + " is " + total);
            }
        }

    }
}
