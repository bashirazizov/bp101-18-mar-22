using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    class BankAccount
    {
        public string Swift;
        public string Code;
        public string Bank;
        public int Balance;

        public string Withdraw(int amount)
        {
            if (amount>Balance)
            {
                return "Balansda kifayet qeder vesait yoxdur";
            }
            else
            {
                this.Balance -= amount;
                return "Pulu goturun";
            }
        }

        public string Deposit(int amount)
        {
            this.Balance += amount;
            return "Hesabiniza pul daxil edildi";
        }
    }
}
