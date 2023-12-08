namespace WordDocumentInterOperability
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var wordService = new WordDocumentService())
            {
                wordService.AddTextToDocument("Hello Nolwethu,you are lerning C# and interoperalbity");
                wordService.SaveDocument(@"c:\temp\NolwethuInfo.docx");
            }

            Console.WriteLine("document is saved");
           
        }
    }
}