using ConstructorInheritanceApp.Model;

namespace ConstructorInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //new ChildV1();

            var c1 = new ChildV2();
            Console.WriteLine(c1.Age);

            var c2 = new ChildV2();
            Console.WriteLine(c2.Age);

            var c3 = new ChildV2(20);
            Console.WriteLine(c3.Age);
        }
    }
}