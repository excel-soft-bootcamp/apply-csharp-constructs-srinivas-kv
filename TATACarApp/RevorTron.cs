using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TATACarApp
{
    class RevorTron : ICarEngine
    {
        public void Start()
        {
            Console.WriteLine("Hexa car is started");
        }
        public void Stop()
        {
            Console.WriteLine("Hexa car is stoped");
        }
    }
}
