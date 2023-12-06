using RectangleEncapsulationApp.Model;

namespace RectangleEncapsulationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Rectangle r1 = new Rectangle();
            r1.SetHeight(10);
            r1.SetWidth(20);

            Console.WriteLine("height is " + r1.GetHeight());
            Console.WriteLine("widht is "+r1.GetWidth());
            Console.WriteLine("Area is "+r1.CalcuateArea());


            Rectangle r2 = new Rectangle();
            r2.SetHeight(50);
            r2.SetWidth(30);
            Console.WriteLine("height is " + r2.GetHeight());
            Console.WriteLine("widht is " + r2.GetWidth());
            Console.WriteLine("Area is " + r2.CalcuateArea());

        }
    }
}