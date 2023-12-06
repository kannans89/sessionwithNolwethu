using RectanglePropertiesApp.Model;

namespace RectanglePropertiesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Rectangle r1 = new Rectangle();
            r1.Widht = -10;
            r1.Height = 20;

            Console.WriteLine("Width is "+r1.Widht);
            Console.WriteLine("Height is " + r1.Height);
            Console.WriteLine("Area is "+r1.CalcuateArea());
        }
    }
}