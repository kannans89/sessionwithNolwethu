using AccountConstructorApp.Model;

namespace AccountConstructorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Account acc1 = new Account("Nolwethu", 1001, 5000);
            acc1.Deposit(1000);
            PrintDetails(acc1,"acc1 details");
           


            Account acc2 = acc1;//pass by refernce
            PrintDetails(acc2,"acc2 details");
          

            acc2.Deposit(500);

            Console.WriteLine("balance of acc1 is " + acc1.Balance);
            Console.WriteLine("balance of acc2 is " + acc2.Balance);

            Console.WriteLine(acc1.GetHashCode());
            Console.WriteLine(acc2.GetHashCode());


            Account acc3 = new Account("kannan", 2001, 1000);
            PrintDetails(acc3, "acc3 details");
         

        }//main

        //passing by refernce ,DRY--> DontRepeat Yourself
        static void PrintDetails(Account acc, string details) {

            Console.WriteLine(details.ToUpper());
            Console.WriteLine("name is " + acc.Name);
            Console.WriteLine("balance is " + acc.Balance);
            Console.WriteLine("acnno is " + acc.AccountNo);
            Console.WriteLine("hashocde is "+acc.GetHashCode());
            Console.WriteLine("===============================");
        }
    }//class
}//namespce