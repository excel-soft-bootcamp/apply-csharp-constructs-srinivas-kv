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
            float heightValue = PersonDataLib.PersonDataLib.SetHeight();
            float weightValue = PersonDataLib.PersonDataLib.SetWeight();
            float Bmi = BMICalculatorLib.BMICalculatorLib.BMI(weightValue, heightValue);
            string consoleMessage = BMIValidatorLib.BMIValidatorLib.Validate(Bmi);
            ConsoleDisplayLib.ConsoleDisplayLib.Display(consoleMessage);
        }
    }
}