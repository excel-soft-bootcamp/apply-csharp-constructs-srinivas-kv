using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_Management
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentIdCard _StudentIdCard = new StudentIdCard(001, "Srinivas", "MCA", "Venkatesh", 19 / 07 / 1997, "Arasikere", "8884182584");
            StaffIdCard _StaffIdCard = new StaffIdCard(112, "Kumar", 12 / 12 / 1976, "MBA",   "Mysuru", "8884182556");
            GuestIdCard _GuestIdCard = new GuestIdCard(1121, "Venkatesh", "Srinivas", 12 / 09 / 1965, "Arasikere", "9998886664");
        }
    }
}
