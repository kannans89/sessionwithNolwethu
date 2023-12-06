using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManIneheritanceApp.Model
{
    internal class Boy : Man
    {

        public override void Play()
        {
            Console.WriteLine("Boy is playing football");
        }

        public void Eat() {
            Console.WriteLine( "boy is eating burger");
        }
    }
}
