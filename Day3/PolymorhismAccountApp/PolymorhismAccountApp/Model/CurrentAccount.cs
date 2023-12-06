using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorhismAccountApp.Model
{
    internal class CurrentAccount : Account
    {
        public CurrentAccount(string name, double balance, int accno) 
            : base(name, balance, accno)
        {
        }

        public override void Withdraw(double amt)
        {
            if (_balance - amt >= -1000)
            {
                _balance = _balance - amt;
            }
            else
                throw new InvalidOperationException("reached credit limit");
        }
    }
}
