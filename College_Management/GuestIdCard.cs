using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Management
{
    public class GuestIdCard :PersonInformation
    {
        private string _ChildName;

        public GuestIdCard(int IDNumber, string name, string ChildName,  int DOB, string address, string MobileNumber) :base(name, DOB, address, MobileNumber)
        {
            this._ChildName = ChildName;
        }


    }
}
