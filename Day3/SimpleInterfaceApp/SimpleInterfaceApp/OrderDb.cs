using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp
{
    internal class OrderDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("OrderDb created");
        }

        public void Delete()
        {
            Console.WriteLine("OrderDb deleted");
        }

        public void Read()
        {
            Console.WriteLine("OrderDb read");
        }

        public void Update()
        {
            Console.WriteLine("OrderDb updated");
        }
    }
}
