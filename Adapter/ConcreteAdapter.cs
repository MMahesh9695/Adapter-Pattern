using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class ConcreteAdapter : IAdapter
    {
        TargetClass T = new TargetClass();
        public string getId()
        {            
            return T.getMyId().ToString();
        }
    }
}
