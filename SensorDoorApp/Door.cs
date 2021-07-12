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
        string doorStatus = "";
        public event DoorStatusHandler OnDoorActionChanged;
        public void Open()
        {
            doorStatus = "Door Opened";
            OnDoorActionChanged.Invoke(doorStatus);

            this.SendNotification();
        }
        public void Close()
        {
            doorStatus = "Door Closed";
            OnDoorActionChanged.Invoke(doorStatus);
            this.SendNotification();
        }
        public void SendNotification ()
        {
            string notify = $"{this.doorStatus} and Time : {System.DateTime.Now.ToString()}";
            OnDoorActionChanged.Invoke(notify);
        }
    }
}
