using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_3
{
    class LoginService
    {


        public LoginService()
        {
            Console.Write("Please enter an action(Login/Logoff/Quit): ");
            string entry = Console.ReadLine().ToLower();

        }

    public void Login()
        {
            bool entry = true;
            if (entry)


                Console.WriteLine("Hi. You are now logged in to the student network");


            else
                Console.WriteLine("Thanks.Youare now logged out !");

        }
    
}
}
         
            
        
    

       
