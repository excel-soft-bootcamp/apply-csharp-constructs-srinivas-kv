using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDoorApp
{
    public delegate void StatusInformerDeledate(string status);
    public delegate string MessageSenderDelegate();
    class SecuritySystem
    {
        public void Inform(string status)
        {
            this.SendMessage();
        }
        public string SendMessage()
        {
            return "Message";
        }
        
    }
}
