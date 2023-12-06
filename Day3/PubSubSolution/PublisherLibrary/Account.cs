using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLibrary
{
    public class Account
    {
        private string _name;
        private int _accountNo;
        private double _balance;
        private List<IAccountSubscriber> _subscribers=new List<IAccountSubscriber>();

        public Account(string name,int accno,double balance) { 
            _name = name;
            _accountNo = accno;
            _balance = balance;
            Console.WriteLine("Account created");

        }

        public void AddSubscriber(IAccountSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Deposit(double amt) {
            _balance = _balance + amt;//state has changed ,callback

            foreach(IAccountSubscriber subscriber in _subscribers)
            {
                subscriber.BalanceChanged(_balance, _name, _accountNo);

            }
        }

        public void Withdraw(double amt) { 
          _balance = _balance - amt;
            foreach (IAccountSubscriber subscriber in _subscribers) { 
              subscriber.BalanceChanged(amt, _name, _accountNo);
            }
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
