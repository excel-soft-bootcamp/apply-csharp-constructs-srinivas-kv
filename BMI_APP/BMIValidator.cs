using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_APP
{
    class BMIValidator
    {

        private int BMIValue;
        public void validateBMI(int BMIValue)
        {
            if (BMIValue > 18.5)
            { Console.WriteLine("Under weight"); }
            if (BMIValue >= 18.5 && BMIValue <= 25)
            { Console.WriteLine("Normal"); }
            if (BMIValue < 25)
            { Console.WriteLine("Over weight"); }
        }
    }
}
