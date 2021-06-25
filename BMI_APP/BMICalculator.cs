using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_APP
{
    class BMICalculator
    {
        BMIValidator valueValidator = new BMIValidator();
        public void calculateBMI(int height, int weight)
        {
            int BMIValue = (weight / height);
            valueValidator.validateBMI(BMIValue);
        }
    }
}
