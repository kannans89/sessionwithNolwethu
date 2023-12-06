using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAndDeserializationApp.Model
{

    [Serializable] //marking customer can be serialzed
    internal class Customer
    {
        public string Name { get; set; }

        public List<Order> Orders { get; set; }


    }
}
