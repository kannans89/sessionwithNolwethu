namespace SingleTonAndThreadApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  CaseStudy1();

            Task.Run(() =>
            {
                PrintingService service1 = PrintingService.GetInstance();
                service1.Print();

            });
            Task.Run(() =>
            {
                PrintingService service2 = PrintingService.GetInstance();
                service2.Print();
            });
            Task.Run(() =>
            {
                PrintingService service3 = PrintingService.GetInstance();
                service3.Print();
            });

            Console.WriteLine("end");

            Console.ReadLine();

        }

        private static void CaseStudy1()
        {
            PrintingService service1 = PrintingService.GetInstance();

            PrintingService service2 = PrintingService.GetInstance();

            Console.WriteLine(service1.GetHashCode());
            Console.WriteLine(service2.GetHashCode());

            service1.Print();
            service2.Print();
        }
    }
}