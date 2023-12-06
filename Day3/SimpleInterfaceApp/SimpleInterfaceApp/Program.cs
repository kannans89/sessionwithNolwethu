namespace SimpleInterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new CustomerDb());
            DoDbOperations(new InvoiceDb());
            DoDbOperations(new OrderDb());

        }

       static void DoDbOperations(ICrudable crudable)
        {
            Console.WriteLine("starting db operations");
            crudable.Create();
            crudable.Read();
            crudable.Update();
            crudable.Delete();
            Console.WriteLine();

        }
    }
}