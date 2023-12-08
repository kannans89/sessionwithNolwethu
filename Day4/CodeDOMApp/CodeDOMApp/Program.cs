using System.CodeDom;
using System.CodeDom.Compiler;

namespace CodeDOMApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var compileUnite= new CodeCompileUnit();
            var theNamespace = new CodeNamespace("KoenigRootNamesapce");
            compileUnite.Namespaces.Add(theNamespace);

            var personClass = new CodeTypeDeclaration("Person");
            theNamespace.Types.Add(personClass);

            var walkMethod = new CodeMemberMethod();
            walkMethod.Name = "Walk";
            walkMethod.Attributes = MemberAttributes.Public | MemberAttributes.Final;
            personClass.Members.Add(walkMethod);


            var provider = CodeDomProvider.CreateProvider("VisualBasic");//Csharp,VisualBasic
            provider.GenerateCodeFromCompileUnit(compileUnite, Console.Out, new CodeGeneratorOptions { BracingStyle = "C" });
        }
    }
}