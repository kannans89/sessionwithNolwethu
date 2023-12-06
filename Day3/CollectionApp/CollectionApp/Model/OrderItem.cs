using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    internal class OrderItem:Object
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }

        public double UnitPrice { get; set; }

        public double CostOfOrderItem() {
            return Quantity * UnitPrice;
        }
    }
}
