using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManIneheritanceApp.Model
{
    internal class Man:Object
    {

        public virtual void Play() {
            Console.WriteLine("Man is playing cards");
        }

        public void Read() {
            Console.WriteLine("Man is reading books");
        }
    }
}
