using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Application
{
    public class Program
    {
        public static void Main(string[] args)
        {
            float heightValue = PersonDataLib.PersonDataType.GetHeight();
            float weightValue = PersonDataLib.PersonDataType.GetWeight();

            float bmiValue = BMICalculatorLib.BMICalculatorType.Calculator(weightValue, heightValue);

            string consoleMessage = BMIValidatorLib.BMIValidatorType.Validate(bmiValue);

            ConsoleDisplayLib.ConsoleDisplayType.Display(consoleMessage);
        }
    }
}