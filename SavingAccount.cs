using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class SavingAccount : Bank
    {
        public decimal InterestRate;

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine("InterestRate");
        }

    }
}
