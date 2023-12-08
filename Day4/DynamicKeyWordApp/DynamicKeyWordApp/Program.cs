namespace DynamicKeyWordApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var x="howdy";// compile time
           // x.Foo();

            dynamic y; //runtime type
            y = "Hello";

            Console.WriteLine(y.GetType()); ;

           // Console.WriteLine(y.Foo());

            dynamic customer = new { 
              FirstName = "Nolwethu",
              LastName = "Nolwethu"
            };
            string fullName = customer.FirstName + " " + customer.LastName;
            Console.WriteLine(fullName.ToUpper());

        }
    }
}