using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Management
{
    class StudentIdCard : PersonInformation
    {
        private string _ParentsName, _Branch;
        public StudentIdCard(int IDNumber, string name, string Branch, string ParentsName,   int DOB, string address, string MobileNumber) :base(name, DOB, address, MobileNumber)
        {
            this._ParentsName = ParentsName;
            this._Branch = Branch;
        }

    }
}
