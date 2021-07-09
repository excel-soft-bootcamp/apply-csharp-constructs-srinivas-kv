using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDoorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem observer_security = new SecuritySystem();
            DoorStatusHandler addressofInformation = new DoorStatusHandler(observer_security.Inform);
            Door _open = new Door();
            _open.onDoorActionChanged += addressofInformation;
            Door _close = new Door();
            _close.onDoorActionChanged += addressofInformation;
            
        }
    }
}
