using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator.Entities
{
    public class Account
    {
        public int AccountType { get; set; }
        public decimal Balance { get; set; }
        public decimal NegativeBalance { get; set; }
    }
}
