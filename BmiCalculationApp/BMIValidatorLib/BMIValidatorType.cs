using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMIValidatorLib
{
    public static class BMIValidatorType
    {
        public static string Validate(float bmiValue)
        {
            if (bmiValue < 18.5)
            {
                return "UnderWeight";
            }
            else if (bmiValue >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal";
            }
        }
    }
}
