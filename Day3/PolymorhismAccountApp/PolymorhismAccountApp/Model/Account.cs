using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorhismAccountApp.Model
{
    internal abstract class Account
    {
        private string _name;
        protected double _balance;
        private int _accno;

        public Account(string name, double balance, int accno) { 
        
             this._name = name;
            this._balance = balance;
            this._accno = accno;
        
        }

        public void Deposit(double amt) {
            _balance += amt;
        }

        public abstract void Withdraw(double amt);

        public string Name { get { return _name; } }
        public double Balance { get { return _balance; } }

        public int Accno { get { return _accno; } }

    }
}
