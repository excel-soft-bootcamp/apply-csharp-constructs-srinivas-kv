using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATACarApp
{
    class VeriCorEngine : ICarEngine
    {
        public void Start()
        {
            Console.WriteLine("Nexon car is started");
        }
        public void Stop()
        {
            Console.WriteLine("Nexon car is stoped");
        }
    }
}
