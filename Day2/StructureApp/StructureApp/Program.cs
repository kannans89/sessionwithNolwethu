namespace StructureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Point p1 = new Point();
            p1.X = 10;
            p1.Y = 20;


            Point p2 = p1;
            p2.X = 100;

            Console.WriteLine("p2 x value is:"+p2.X);
            Console.WriteLine("p1 x value is:" + p1.X);

        }
    }
}