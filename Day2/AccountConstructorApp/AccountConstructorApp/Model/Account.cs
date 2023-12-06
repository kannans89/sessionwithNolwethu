using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AccountConstructorApp.Model
{
    internal class Account
    {
        private string _name;
        private int _accountNo;
        private double _balance;

        public Account(string name,int accno,double balance) { 
            _name = name;
            _accountNo = accno;
            _balance = balance;
            Console.WriteLine("Account created");

        }
        public void Deposit(double amt) {
            _balance = _balance + amt;
        }

        public void Withdraw(double amt) { 
          _balance = _balance - amt;    
        }

        public int AccountNo {
            get { 
             return _accountNo;
            }
        }
        public double Balance {
            get {
                return _balance;
            }
        }
        public string Name {
            get {
                return _name;
            }
        }
    }
}
