namespace SimpleDelegateApp
{
    delegate void DPrintMessage(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>(); 

            //CaseStudy1();

            //CaseStudy2();

           // PrintWizard(PrintGoodBye);
           //  PrintWizard(PrintHello);

            //PrintWizard(delegate (string name)
            //{
            //    Console.WriteLine("Anonymous delegate method called");
            //    Console.WriteLine(name.ToUpper());

            //});

            PrintWizard((name)=>
            {
                Console.WriteLine("Anonymous delegate method called");
                Console.WriteLine(name.ToUpper());

            });

        }
        static void PrintWizard(DPrintMessage fptr)
        {
            Console.WriteLine("Doing some printing operation ");
            Console.WriteLine("printing over");
            fptr("CHAMP complted work");//function callback
        }
        private static void CaseStudy2()
        {

            DPrintMessage x=PrintHello;
            x += PrintGoodBye;
            x += PrintHello;

            x("CHAMP");
        }

        private static void CaseStudy1()
        {
            DPrintMessage x;// x expects any method having same delegate signature
            x = PrintHello;

            x("Nolwethu");
            x = PrintGoodBye;
            x("Nolwethu");

            //x = Foo;
            //x();
        }

        static void PrintHello(string name)
        {

            Console.WriteLine("Hello says "+name);
        }

        static void PrintGoodBye(string name)
        {
            Console.WriteLine("Goodbye says "+name);
        }

        static void Foo() {
            Console.WriteLine("inside foo");
        }

       
            
    }
}