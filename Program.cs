using AdapterPattern.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientClass client = new ClientClass();
            string id = client.getId();
            Console.Write(id);
            Console.ReadKey();
        }
    }
}
