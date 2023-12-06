using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerToStringEqualsApp.Model
{
    internal class Customer
    {
        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"Name is {Name} City is {City} parent value is {base.ToString()}";
        }

        public override bool Equals(object second)
        {

            Customer secondCustomer = (Customer)second;

            if (Name == secondCustomer.Name && City == secondCustomer.City)
            {
                return true;
            }
            else
                return false;

        }
    }
}
