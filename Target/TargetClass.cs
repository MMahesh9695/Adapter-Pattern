using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Target
{
    public class TargetClass
    {
        public int getMyId()
        {
            Random rand = new Random();
            return rand.Next(1, 2);
        }
    }
}
