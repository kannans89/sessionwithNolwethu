using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonAndThreadApp
{
    internal class PrintingService
    {
        private static PrintingService bucket;
        private static object _lock = new object();
        private PrintingService() {
            Console.WriteLine("service created");
        }

        public static PrintingService GetInstance() {

            lock (_lock)
            {
                if (bucket == null)
                {
                    bucket = new PrintingService();
                }

                return bucket;
            }
        }

        public void Print()
        {
            Console.WriteLine("starting printing operation "+this.GetHashCode());
        }
    }
}
