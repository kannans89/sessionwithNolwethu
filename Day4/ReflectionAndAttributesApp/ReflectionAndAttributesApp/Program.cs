using System.Reflection;

namespace ReflectionAndAttributesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  CaseStudy1();

            Type obj = typeof(Account);
            MethodInfo[] methods = obj.GetMethods();
            foreach (var m in methods)
            {
               // Console.WriteLine(m.Name);
                if (m.IsDefined(typeof(NeedUrgentAttention))) {

                    Console.WriteLine("Maarked with attribute :"+m.Name);
                }
            }

        }

        private static void CaseStudy1()
        {
            Type obj = typeof(Console);
            MethodInfo[] methods = obj.GetMethods();
            foreach (var m in methods)
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}