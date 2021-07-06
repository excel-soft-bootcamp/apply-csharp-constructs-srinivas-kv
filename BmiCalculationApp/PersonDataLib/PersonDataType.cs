using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDataLib
{
    public static class PersonDataType
    {
        
        public static float GetHeight()
        {
          return ConsoleUserInputlib.ConsoleUserInputType.SetHeight();
           
        }
        public static float GetWeight()
        {
         return  ConsoleUserInputlib.ConsoleUserInputType.SetWeight(); 
        }
    }
}
