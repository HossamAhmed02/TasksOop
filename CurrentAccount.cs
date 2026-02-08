using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    internal class CurrentAccount : Bank
    {
        public decimal OverdraftLimit;

        public override void ShowAccountDetails()
        {
            base.ShowAccountDetails();
            Console.WriteLine("OverdraftLimit");
        }
    }
}
