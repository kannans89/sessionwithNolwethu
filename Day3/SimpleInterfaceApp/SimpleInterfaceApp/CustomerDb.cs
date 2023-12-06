using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleInterfaceApp
{
    internal class CustomerDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("CustomerDb created");
        }

        public void Delete()
        {
            Console.WriteLine("CustomerDb delete");
        }

        public void Read()
        {
            Console.WriteLine("CustomerDb read");
        }

        public void Update()
        {
            Console.WriteLine("CustomerDb updated");
        }
    }
}
