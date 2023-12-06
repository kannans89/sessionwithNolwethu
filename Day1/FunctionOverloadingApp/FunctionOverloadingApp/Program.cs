namespace FunctionOverloadingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(100);
            Console.WriteLine(100.55);

            PrintInfo("Koenig");
            PrintInfo(100);
            PrintInfo(100.5);
            PrintInfo(100.5M);
            PrintInfo(100.5f);
            PrintInfo('1');


        }

        static void PrintInfo(string info)
        {

            Console.WriteLine($"overload no 1 :string value is {info} ");
           
        }

        static void PrintInfo(int info)
        {

            Console.WriteLine($"overload no 2 :int value is {info}  ");
            Console.WriteLine($"size of integer is {sizeof(int)} ");
        }

        static void PrintInfo(double info)
        {

            Console.WriteLine($"overload no 3 :double value is {info} ");
            Console.WriteLine($"size of double is {sizeof(double)} ");
        }

        static void PrintInfo(decimal info)
        {

            Console.WriteLine($"overload no 4 :decimal value is {info} ");
            Console.WriteLine($"size of decimal is {sizeof(decimal)} ");
        }

        static void PrintInfo(float info)
        {

            Console.WriteLine($"overload no 5:float value is {info} ");
            Console.WriteLine($"size of float is {sizeof(float)} ");
        }

        static void PrintInfo(char info)
        {

            Console.WriteLine($"overload no 6:char value is {info} ");
            Console.WriteLine($"size of char is {sizeof(char)} ");
        }
    }
}