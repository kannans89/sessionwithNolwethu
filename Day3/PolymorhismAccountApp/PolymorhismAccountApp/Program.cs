using PolymorhismAccountApp.Model;

namespace PolymorhismAccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            try
            {
                CaseStudy2();
            }
          
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            Console.WriteLine("end of program");
        }

        private static void CaseStudy2()
        {

            Exception ex; // ex exepcts object of Exceptio or subclasses of Exception

            ex= new InvalidOperationException();

           // ex = new IndexOutOfRangeException();

          //  ex = new FormatException();

            throw ex;

        }

        private static void CaseStudy1()
        {
            var currentAcc = new CurrentAccount("Mr.CA Hodler", 1000, 1);
            PrintDetails(currentAcc);
            try
            {
                currentAcc.Withdraw(2001);
                PrintDetails(currentAcc);
            }
            catch (Exception ex) //polymorphism (ISA)
            {
                Console.WriteLine("Catching excpetion");
                Console.WriteLine(ex.Message);
            }

            var savingAcc = new SavingAccount("Mr.SA Holder", 2000, 2);
            PrintDetails(savingAcc);
        }

        static void PrintDetails(Account acc) {

            Console.WriteLine("Name is "+acc.Name);
            Console.WriteLine("BAlance is " + acc.Balance);
            Console.WriteLine("accno is " + acc.Accno);
            Console.WriteLine();
        }
    }
}