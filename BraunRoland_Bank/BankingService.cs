using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BraunRoland_Bank
{
    abstract class BankingService
    {
        Owner owner;

        public BankingService(Owner owner)
        {
            this.owner = owner;
        }

        public Owner Owner { get => owner;}
    }
}
