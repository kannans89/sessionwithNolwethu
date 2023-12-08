using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelegatesApp
{
    public delegate void DBalanceChanged(double newBalance, string name, int accono);
    public class Account
    {
        private string _name;
        private int _accountNo;
        private double _balance;
        public event DBalanceChanged OnBalanceChanged = null;



        public Account(string name, int accno, double balance)
        {
            _name = name;
            _accountNo = accno;
            _balance = balance;
            Console.WriteLine("Account created");

        }



        public void Deposit(double amt)
        {
            _balance = _balance + amt;//state has changed ,callback
            if (OnBalanceChanged != null)
            {
                OnBalanceChanged(_balance, _name, _accountNo);
            }


        }

        public void Withdraw(double amt)
        {
            _balance = _balance - amt;
            if (OnBalanceChanged != null)
            {
                OnBalanceChanged(_balance, _name, _accountNo);
            }
        }

        public int AccountNo
        {
            get
            {
                return _accountNo;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
    }
}
