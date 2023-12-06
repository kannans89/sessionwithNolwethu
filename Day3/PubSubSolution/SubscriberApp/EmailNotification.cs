using PublisherLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberApp
{
    internal class EmailNotification : IAccountSubscriber
    {
        public void BalanceChanged(double newbalance, string name, int accono)
        {
            Console.WriteLine("sending email to "+name + "balanc is now :"+newbalance);
        }
    }
}
