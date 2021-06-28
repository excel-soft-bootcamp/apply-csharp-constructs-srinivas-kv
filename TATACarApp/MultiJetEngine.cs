using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATACarApp
{
    class MultiJetEngine : ICarEngine
    {
        public void Start()
        {
            Console.WriteLine("Harrier car is started");
        }
        public void Stop()
        {
            Console.WriteLine("Harrier car is stoped");
        }
    }
}
