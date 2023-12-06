using StudentCounterApp.Model;

namespace StudentCounterApp
{
    internal class Program
    {
        static int bar = 20;
        static void Main(string[] args)
        {


            Student s1 = new Student("Studnet 1");
            Console.WriteLine(s1.GetCount());

            Student s2 = new Student("Studnet 2");
            Console.WriteLine(s2.GetCount());

            Student s3 = new Student("Studnet 3");
            Console.WriteLine(s3.GetCount());


            Console.WriteLine(Student.HeadCount());

            Foo();
            Console.WriteLine(bar);

        }


       static  void Foo() { 
        
        }
    }
}