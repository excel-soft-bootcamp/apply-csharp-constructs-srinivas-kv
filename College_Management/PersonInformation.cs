using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Management
{
    public abstract class PersonInformation
    {
        private string _name, _MobileNumber, _address;
        private int _DOB, _IDNumber;
        public PersonInformation(string name)
        {
            this._name = name;
        }
        public PersonInformation(string name, int DOB):this(name)
        {
            this._DOB = DOB;
        }
        public PersonInformation(string name, int DOB, string address) : this(name,DOB)
        {
            this._address = address;
        }
        public PersonInformation(string name, int DOB, string address, string MobileNumber) : this(name, DOB, address)
        {
            this._MobileNumber = MobileNumber;
        }
        public PersonInformation(string name, int DOB, string address, string MobileNumber, int IDNumber) : this(name, DOB, address, MobileNumber)
        {
            this._IDNumber = IDNumber;
        }
    }
}
