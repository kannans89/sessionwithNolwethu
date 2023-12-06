using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp
{
    internal class InvoiceDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Invoice created");
        }

        public void Delete()
        {
            Console.WriteLine("Invoice delted");
        }

        public void Read()
        {
            Console.WriteLine("Invoice read");
        }

        public void Update()
        {
            Console.WriteLine("Invoice updated");
        }
    }
}
