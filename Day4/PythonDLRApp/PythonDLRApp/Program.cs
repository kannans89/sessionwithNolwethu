using IronPython.Hosting;

namespace PythonDLRApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string scriptPath = @"C:\temp\add.py";
            var engine = Python.CreateEngine();
            var scope = engine.CreateScope();
            var source = engine.CreateScriptSourceFromFile(scriptPath);
            source.Execute(scope);

            if (scope.ContainsVariable("add"))
            {
                dynamic result = scope.GetVariable("add")(5, 3);
                Console.WriteLine("result of python addition is :" + result);
            }
            else {
                Console.WriteLine("add function not found in file");
            }
        }
    }
}