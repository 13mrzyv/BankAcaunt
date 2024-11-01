using BankAcaunt.Model;
using BankAcaunt.UIcomponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAcaunt.Repository
{
    public class database
    {
        private readonly ui2 _ui2;
        public database()
        {
            _ui2 = new ui2();
        }
        private List<user> users = new List<user>();
        public List<user> _users
        {
            get { return users; }
        }
        public void SignUp(user x)
        {
            Thread.Sleep(2500);
            _users.Add(x);
            Console.WriteLine("User added to the system...");

        }
        public user SignIn(string Email, string Password)
        {

            foreach (user user1 in _users)
            {
                if (user1.Email == Email && user1.Password == Password)
                {
                    Thread.Sleep(2500);
                    Console.WriteLine("Sign in was sucsesfull...");
                    _ui2.Begin(user1);
                    return user1;
                }

            }
            Console.WriteLine("Sign in was failed...");
            return null;

        }
        public void usersilme(user user)
        {
            _users.Remove(user);
        }
    }
}
