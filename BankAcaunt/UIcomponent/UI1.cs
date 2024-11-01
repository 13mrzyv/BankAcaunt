using BankAcaunt.Model;
using BankAcaunt.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcaunt.UIcomponent
{
    internal class UI
    {
        private readonly BankAccountService _bankAccountService;
        public UI()
        {
            _bankAccountService = new BankAccountService();
        }
        public void Begin()
        {
            Console.WriteLine("...HElLO...");
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("1--Sign Up... \n2--Sign in...");
                Console.Write("What do you want to do.? (1/2) -");
                string x = Console.ReadLine();
                if (x == "1")
                {
                    SignUp();
                }
                else if (x == "2")
                {
                    SignIn();
                }
                else
                {
                    Console.WriteLine("ERROR... Make the right choice..!");
                }
            }
        }
        public void SignUp()
        {
            user user1 = new user();

            Console.Write("email-");
            user1.Email = Console.ReadLine();
            Console.Write("name-");
            user1.Name = Console.ReadLine();
            Console.Write("surname-");
            user1.Surname = Console.ReadLine();
            Console.Write("password-");
            user1.Password = Console.ReadLine();
            Console.Write("card number-");
            user1.CardNumber = Console.ReadLine();
            Console.Write("cvv-");
            user1.Cvv = Console.ReadLine();


            _bankAccountService.SignUp(user1);
        }
       public void SignIn()
        {
            Console.Write("email-");
            string Email = Console.ReadLine();
            Console.Write("password-");
            string Password = Console.ReadLine();

            _bankAccountService.SignIn(Email, Password);
        }
    }
}
