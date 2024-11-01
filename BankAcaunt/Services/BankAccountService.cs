using BankAcaunt.Model;
using BankAcaunt.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcaunt.Services
{
    public class BankAccountService
    {
        private readonly database _database;

        public BankAccountService()
        {
            _database = new database();
        }

        public void SignUp(user x)
        {
            if (string.IsNullOrEmpty(x.Email) || string.IsNullOrEmpty(x.Name) || string.IsNullOrEmpty(x.Surname) || string.IsNullOrEmpty(x.Password) || string.IsNullOrEmpty(x.CardNumber) || string.IsNullOrEmpty(x.Cvv))
            {
                Console.WriteLine("ERROR... The variables must be filled.");
            }
            else if (x.Password.Length != 8)
            {
                Console.WriteLine("ERROR... Password must be 8 characters long.");
            }
            else if (x.CardNumber.Length != 16)
            {
                Console.WriteLine("ERROR... Card Number must be 16 characters long.");
            }
            else if (x.Cvv.Length != 3)
            {
                Console.WriteLine("ERROR... Cvv must be 3 characters long.");
            }
            else
            {
                _database.SignUp(x);
            }

        }
        public void SignIn(string Email, string Password)
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                Console.WriteLine("ERROR...");
            }
            else
            {
                _database.SignIn(Email, Password);
            }
        }
    }
}
