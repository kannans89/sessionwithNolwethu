namespace CommandLineArgsApp
{
    internal class Program
    {
        static void Main(string[] userNames)
        {
            Console.WriteLine("No of values passed to userNames");
            Console.WriteLine(userNames.Length);

            //for (int index = 0; index < userNames.Length; index++)
            //{
            //    Console.WriteLine("Hello " + userNames[index]);
            //}

            //for (int index = userNames.Length-1; index >= 0; index--)
            //{
            //    Console.WriteLine("Hello " + userNames[index]);
            //}

            foreach (string name in userNames) {
                Console.WriteLine("hello "+name.ToUpper());
            }
        }
    }
}