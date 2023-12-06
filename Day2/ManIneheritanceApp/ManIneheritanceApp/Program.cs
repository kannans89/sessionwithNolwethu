using ManIneheritanceApp.Model;

namespace ManIneheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CaseStudy1();

            //  CaseStudy2();

            // CaseStudy3();

            // CaseStudy4();

            CaseStudy5();

           
        }

        private static void CaseStudy5()
        {
            //Highest level of polyorphism

            object x;// x expects anything under object
            x = 10;
            Console.WriteLine(x.GetType());
            x = "hello";
            Console.WriteLine(x.GetType());
            x = new Man();
            Console.WriteLine(x.GetType());
            x = new Boy();
            Console.WriteLine(x.GetType());

            Boy y =(Boy) x;//casting
            y.Play();
            y.Eat();
            y.Read();
           

        }

        private static void CaseStudy4()
        {
            AtThePark(new Man());
            AtThePark(new Boy());
            AtThePark(new Kid());
            AtThePark(new Toddler());
        }

        static void AtThePark(Man x) // (ISA type of Man)
        {
            Console.WriteLine("At the park");
            x.Play();
        }
        private static void CaseStudy3()
        {
            Man x; //(ISA) x expects Man or subclasses of Man

            x = new Boy();//polymorhic
            x.Play();
            x.Read();

        }

        private static void CaseStudy2()
        {

            Boy y;//y expects an object of Boy class
            y = new Boy();
            y.Play();
            y.Eat();
            y.Read();
        }

        private static void CaseStudy1()
        {

            Man x;// x expects an object of Man class
            x = new Man();
            x.Play();
            x.Read();
        }
    }
}