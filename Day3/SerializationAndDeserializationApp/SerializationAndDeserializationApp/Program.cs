using SerializationAndDeserializationApp.Model;
using System.Runtime.Serialization.Formatters.Binary;

namespace SerializationAndDeserializationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CaseStudy1();

            //  CaseStudy2();

            CaseStudy3();
        }

        private static void CaseStudy3()
        {
            var c1 = new Customer { Name = "Nolwethu" };
        }

        private static void CaseStudy2()
        {
            FileStream fs = new FileStream("c1.binary", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Customer c= (Customer) bf.Deserialize(fs);
            Console.WriteLine(c.Name);
            fs.Close();
        }

        private static void CaseStudy1()
        {
            var c1 = new Customer { Name = "Nolwethu" };
            FileStream fs = new FileStream("c1.binary", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,c1);
            fs.Close();
            Console.WriteLine("customer serialized to file");


        }
    }
}