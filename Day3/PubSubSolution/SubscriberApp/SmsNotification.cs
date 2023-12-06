using PublisherLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberApp
{
    internal class SmsNotification : IAccountSubscriber
    {
        public void BalanceChanged(double newbalance, string name, int accono)
        {
            Console.WriteLine("sending sms to " + name + "balanc is now :" + newbalance);
        }
    }
}
