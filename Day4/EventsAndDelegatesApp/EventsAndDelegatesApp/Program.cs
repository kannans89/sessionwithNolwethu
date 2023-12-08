namespace EventsAndDelegatesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account("Nolwethu", 101, 2000);
         
            acc1.OnBalanceChanged += SmsNotification;
            acc1.OnBalanceChanged += EmailNotificaiton;
            acc1.Deposit(3000);
        }

        private static void SmsNotification(double newBalance, string name, int accono)
        {
            Console.WriteLine("sms sent to account "+name + "current balance is "+newBalance);
        }
        private static void EmailNotificaiton(double newBalance, string name, int accono)
        {
            Console.WriteLine("email sent to account " + name + "current balance is " + newBalance);
        }
    }
}