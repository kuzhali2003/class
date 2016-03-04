using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    class LoginService
    {
        // string entry;
        public string entry { get; set; }
        public string entry1 { get; set; }
        public LoginService()


        {
            while (true)
            {
                entry1 = " ";
                // Console.Write("Please enter an action(Login/Logoff/Quit): ");
                // entry1 = Console.ReadLine();
                // Console.WriteLine("Thanks.You are now logged out.");
                Console.Write("Please enter an action(Login/Logoff/Quit): ");
                entry = Console.ReadLine().ToLower();

                if (entry == "login")

                {
                    Console.WriteLine("Hi. You are now logged in to the student network");
                    entry1 = entry;
                }

                else if (entry == "logoff")
                {
                    if ((entry == "logoff") && (entry1 == "login"))

                        Console.WriteLine("Thanks.Youare now logged out!");
                }
                else if (entry == "quit")
                {
                    if ((entry1 == "login") && (entry == "quit"))
                        Console.WriteLine("Sorry you have to logoff before you can Quit.");
                    else
                        Console.WriteLine("Thank you !");
                }
            }

        }
    }
}         
            
        
    

       
