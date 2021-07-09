using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDoorApp
{
    public delegate void DoorStatusHandler (string status);
    public class Door
    {
        string doorStatus = "close";
        public event DoorStatusHandler onDoorActionChanged;
        public void DoorFunction()
        {
            doorStatus = "open";
            onDoorActionChanged.Invoke(this.doorStatus);
        }
    }
}
