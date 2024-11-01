using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcaunt.Model
{
    public class usercard
    {
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public int Balance = 0;
    }
}
