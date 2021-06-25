using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_APP
{
    public class InputValues
    {
        BMICalculator calculate = new BMICalculator();
        private int height, weight;
        public void ReadInput ()
        {
            #region User Input
            Console.WriteLine("Height in meters : ");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Weight in kilograms : ");
            int weight = int.Parse(Console.ReadLine());
            #endregion 
            calculate.calculateBMI(this.height, this.weight);
        }
        
        #region Set Values
        public int Height
        {
            set { height = value; }
        }
        public int Weight
        {
            set { weight = value; }
        }
        #endregion

    }
}
