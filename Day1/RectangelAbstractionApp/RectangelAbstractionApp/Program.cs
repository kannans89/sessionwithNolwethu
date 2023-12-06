using RectangelAbstractionApp.Model;

namespace RectangelAbstractionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int x;//x exepcts an integer value
            x = 100;//x gets integer value


            Rectangle small;//small expects a rectnagel object
            small = new Rectangle();
            Console.WriteLine($"small " +
                $"widht is {small.width} " +
                $"color is {small.color}" +
                $"height is {small.height}");

            small.width = 10;
            small.height = 20;
            small.color = "pink";

            Console.WriteLine($"small " +
              $"widht is {small.width} " +
              $"color is {small.color}" +
              $"height is {small.height}");


            Console.WriteLine(small.GetHashCode());


        }
    }
}