using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorhismAccountApp.Model
{
    internal class SavingAccount : Account
    {
        public SavingAccount(string name, double balance, int accno) 
            : base(name, balance, accno)
        {
        }

        public override void Withdraw(double amt)
        {
            if (this._balance - amt > 1000)
            {
                this._balance = this._balance - amt;
            }
            else
              throw new InvalidOperationException("Minimum balance should be 1000");
        }
    }
}
