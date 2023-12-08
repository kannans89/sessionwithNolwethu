using EFConsoleApp.Entity;

namespace EFConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new OrganizationDbContext();
            Organization org1 = new Organization {  Name="Microsoft"};
            Organization org2 = new Organization { Name = "Amazon" };
            db.Organizations.Add(org1);
            db.Organizations.Add(org2);

            db.SaveChanges();
            Console.WriteLine("saved objects to database");

        }
    }
}