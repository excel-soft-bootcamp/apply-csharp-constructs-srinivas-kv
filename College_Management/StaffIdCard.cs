using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Management
{
    class StaffIdCard : PersonInformation
    {
        private string _BranchName;
        public StaffIdCard(int IDNumber, string name, int DOB, string BranchName,   string address, string MobileNumber) :base(name, DOB, address, MobileNumber)
        {
            this._BranchName = BranchName;
        }
    }
}
