using BankAcaunt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BankAcaunt.UIcomponent
{
    internal class ui2
    {
        public void Begin(user y)
        {
            while (true)
            {
                Console.WriteLine("...OPERATIONS...");
                Console.WriteLine("*1-Enter money");
                Console.WriteLine("*2-Spend money");
                Console.WriteLine("*3-Get Balance");
                Console.WriteLine("*4-Delete User");
                Console.WriteLine("*5-User Information");
                Console.WriteLine("*6-Change Pasword");
                Console.WriteLine("*7-Log Out");
                Console.Write("What do you want to do.? (1/2/3/4/5/6/7) -");
                string a = Console.ReadLine();
                if (a == "1")
                {
                    Console.Write("Amount--");
                    string artmebleg = Console.ReadLine();
                    int artmeblegInt = Convert.ToInt32(artmebleg);
                    y.Balance = y.Balance + artmeblegInt;
                    Console.WriteLine("* Balance increased * Current Balance--" + y.Balance);
                    Thread.Sleep(2500);
                }
                else if (a == "2")
                {
                    Console.Write("Amount--");
                    string azmebleg = Console.ReadLine();
                    int azmeblegInt = Convert.ToInt32(azmebleg);
                    if (azmeblegInt > y.Balance)
                    {
                        Console.WriteLine("The card does not have the amount you want...");
                    }
                    else
                    {
                        y.Balance = y.Balance - azmeblegInt;
                        Console.WriteLine("* Money withdrawn * Current Balance--" + y.Balance);
                    }
                    Thread.Sleep(2500);
                }
                else if (a == "3")
                {
                    Console.WriteLine("Your balance--" + y.Balance);
                    Thread.Sleep(2500);
                }
                /*
                else if (a == "4")
                {
                    d.usersilme(y);
                    Thread.Sleep(2500);
                    break;
                }
                */
                else if (a == "5")
                {
                    Console.WriteLine("Gmail--" + y.Email);
                    Console.WriteLine("Name--" + y.Name);
                    Console.WriteLine("Surname--" + y.Surname);
                    Console.WriteLine("Password--" + y.Password);
                    Console.WriteLine("Card Number--" + y.CardNumber);
                    Console.WriteLine("Card CVV--" + y.Cvv);
                    Console.WriteLine("Balance--" + y.Balance);
                    Thread.Sleep(2500);
                }
                else if (a == "6")
                {
                    Console.Write("Do you want to change the password? yes/no--");
                    string qerar = Console.ReadLine();
                    if (qerar == "yes")
                    {
                        y.Password = Console.ReadLine();
                    }
                    Thread.Sleep(2500);
                }
                else if (a == "7")
                {
                    Console.WriteLine("Log out...");
                    break;
                }
                else
                {
                    Console.WriteLine("Error... Make the right choice..!");
                }
            }
        }
    }
}
