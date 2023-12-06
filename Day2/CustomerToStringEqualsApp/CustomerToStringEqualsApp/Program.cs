using CustomerToStringEqualsApp.Model;

namespace CustomerToStringEqualsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            var c1 = new Customer();
            c1.Name = "A";
            c1.City = "B";

            Console.WriteLine(c1);
            Console.WriteLine(c1.ToString()) ;


            var c2 = new Customer();
            c2.Name = "A";
            c2.City = "B";

            var c3 = c1;

            Console.WriteLine(c1==c2);//Referential equality
            //Console.WriteLine(c3==c1);

            Console.WriteLine(c1.Equals(c2));//value based equality
        }
    }
}