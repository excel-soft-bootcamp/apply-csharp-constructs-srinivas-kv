using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("What is your height in meters ");
            var height = Convert.ToInt32(Console.ReadLine());
            Console.Write("What is your weight in weight kg ");
            var weight = Convert.ToInt32(Console.ReadLine());
            var healthProfile = new HealthProfile(height, weight);
            Console.WriteLine("Height: {0}\". Weight {1}", healthProfile.Height, healthProfile.Weight);
            Console.WriteLine("BMI: {0:##.##}%, which means you are {1}", healthProfile.Bmi, healthProfile.BmiEvaluation());
            Console.ReadKey();
        }
    }
}
