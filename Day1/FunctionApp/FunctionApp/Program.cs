namespace FunctionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            PrintName("Nolwethu", 10);
            PrintLine('@');
            PrintName("SA", 5);
            PrintLine('@');
            string[] devNames= GetDevelopers();
            foreach (string devName in devNames)
            {
                Console.WriteLine(devName);
            }
            string result = CheckEven(30);
            Console.WriteLine(result);
        }

        static void PrintName(string name,int iterations) { 
        
            for(int iteration=1;iteration<=iterations; iteration++)
            {
                Console.WriteLine(name.ToUpper());
            }
         
        }
        static void PrintLine(char separator) {
            for (int iter = 1; iter <= 50; iter++) { 
               Console.Write(separator);
             }
            Console.WriteLine();
        }

        static string[] GetDevelopers()
        {
            string[] developers = { "Nolwethu","Kannan","John" };
        
            return developers;
        }


        static string CheckEven(int no) {

            if(no%2==0)
            {
                return $"Number {no} is  even no";
            }

            return    $"Number {no} is no even no";
        }
    }
}