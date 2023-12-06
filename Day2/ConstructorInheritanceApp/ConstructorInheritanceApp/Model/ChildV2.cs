using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInheritanceApp.Model
{
    internal class ChildV2 : ParentV2
    {

        public ChildV2():base(100)//hardcoded values
        { 
        
        
        }

        public ChildV2(int age) : base(age)
        {


        }
    }
}
