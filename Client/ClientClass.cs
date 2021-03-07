using AdapterPattern.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Client
{
    public class ClientClass
    {
        public string getId()
        {
            IAdapter adapter = new ConcreteAdapter();
            return adapter.getId();
        }
    }
}
