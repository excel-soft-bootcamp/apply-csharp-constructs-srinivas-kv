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
            DoorStatusHandler handler = new DoorStatusHandler(observer_security.SendMessage);
            Door door = new Door();
            door.OnDoorActionChanged += handler;
            door.Open();
            door.Close();      
        }
    }
}
