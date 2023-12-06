using ThisPointerApp.Model;

namespace ThisPointerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Player p1 = new Player("PlayerA", 20,GenderType.Female);
            PrintDetails(p1, "p1 details");

            Player p2 = new Player("Player B", 28);
            PrintDetails(p2, "p2 details");

             Player elder  =p1.WhoIsElder(p2);
            PrintDetails(elder, "Edler");
        



        }

        private static void PrintDetails(Player player, string details)
        {
            Console.WriteLine(details.ToUpper());
            Console.WriteLine("name is:"+player.Name);
            Console.WriteLine("Age is:" + player.Age);
            Console.WriteLine("Gender is:" + player.Gender);
            Console.WriteLine("hashcode is "+player.GetHashCode());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}