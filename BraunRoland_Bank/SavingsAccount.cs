using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraunRoland_Bank
{
    internal class SavingsAccount : BankAccount
    {
        static double baseInterest;
        public  double Interest { get => baseInterest; set => baseInterest = value; }

        public SavingsAccount(Owner owner) : base(owner)
        {
            Interest = baseInterest;
        }


        public override bool Withdraw(double amount)
        {
            if (this.Balance - amount >= 0)
            {
                this.Balance -= amount;
                return true;
            }
            return false;
        }

        public void AddInterest()
        {
            this.Balance += this.Balance * (Interest / 100);
        }
    }
}
