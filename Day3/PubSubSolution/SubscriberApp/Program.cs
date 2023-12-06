using PublisherLibrary;

namespace SubscriberApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account("Nolwathu", 101, 5000);
          
            acc1.AddSubscriber(new EmailNotification());
            acc1.AddSubscriber(new SmsNotification());
            acc1.Deposit(1000);

        }
    }
}