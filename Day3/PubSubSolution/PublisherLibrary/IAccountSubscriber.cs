using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLibrary
{
    public interface IAccountSubscriber
    {
        void BalanceChanged(double newbalance,string name,int accono);
    }
}
