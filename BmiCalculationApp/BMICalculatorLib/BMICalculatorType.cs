using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorLib
{
    public static class BMICalculatorType
    {
        public static float Calculator(float weight, float height)
        {
            return (weight / height);
        }
    }
}
