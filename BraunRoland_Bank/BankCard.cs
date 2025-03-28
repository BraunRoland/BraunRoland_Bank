using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraunRoland_Bank
{
    internal class BankCard : BankingService
    {
        double accountBalance;
        string cardNumber;

        public string CardNumber { get => CardNumber; }

        public double AccountBalance { get => accountBalance; }

        public BankCard(Owner owner, double accountBalance, string cardNumber) : base(owner)
        {
            this.accountBalance = accountBalance;
            this.cardNumber = cardNumber;
        }

        public bool Purchase(double amount)
        {
            if (this.accountBalance - amount >= 0)
            {
                this.accountBalance -= amount;
                return true;
            }
            return false;
        }
    }
}
