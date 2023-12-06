namespace HtmlFileReadWriteApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            FileStream fs = new FileStream("hello.html", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            while (!sr.EndOfStream) {
               string line= sr.ReadLine();
                Console.WriteLine(line);
            }

            sr.Close();
            fs.Close();
        }

        private static void CaseStudy1()
        {
            FileStream fs = new FileStream("hello.html", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("<h1>Hello Nolwethu welcome to file write app</h1>");
            sw.WriteLine("<h1>Hello Nolwethu welcome to file write app</h1>");
            sw.Close();
            fs.Close();

            Console.WriteLine("file created");
        }
    }
}