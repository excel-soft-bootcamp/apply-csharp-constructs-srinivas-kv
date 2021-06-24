using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class HealthProfile
    {

        public HealthProfile(int height, int weight)
        {
            Height = height;
            Weight = weight;
        }

        public int Height { get; set; }
        public int Weight { get; set; }

        public double Bmi
        {
            get { return (Weight / (Math.Pow(Height, 2)) }
        }

        public string BmiEvaluation()
        {
            if (Bmi > 18.5)
                return "Underweight";
            else if (Bmi < 25)
                return "Overweight";
        }
    }
}

