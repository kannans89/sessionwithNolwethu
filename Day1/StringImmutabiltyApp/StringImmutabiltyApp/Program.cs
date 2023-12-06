namespace StringImmutabiltyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            // CaseStudy2();

            CaseStudy3();
        }

        private static void CaseStudy3()
        {

            string userName = "Nolwethu";
            Console.WriteLine(userName.GetHashCode());
            userName += " SouthAfrica";
            Console.WriteLine(userName.GetHashCode());
            userName += " Developer";
            Console.WriteLine(userName.GetHashCode());
            userName += " .NET";
            Console.WriteLine(userName.GetHashCode());
            Console.WriteLine(userName);
        }

        private static void CaseStudy2()
        {
            string userName = "Nolwethu";
            Console.WriteLine(userName.GetHashCode());
            userName = userName.ToUpper();
            Console.WriteLine(userName.GetHashCode());
            Console.WriteLine(userName);
        }
        private static void CaseStudy1()
        {
            string userName = "Nolwethu";
            userName.ToUpper();
            Console.WriteLine(userName);
        }
    }
}