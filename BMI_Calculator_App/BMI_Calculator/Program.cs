using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
    public enum Options {
        CONSOLEINPUT= 1, FILEINPUT
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            
            do
            {
                string consoleMessage = $"Enter your choice \n{(int)Options.CONSOLEINPUT}->Console Input \n{(int)Options.FILEINPUT}->File Input";
                Console.WriteLine(consoleMessage);
                try
                {
                    int choice = Int32.Parse(Console.ReadLine());
                    
                    if (choice < 0 || choice > 2)
                    {
                        Console.WriteLine("Invalid input");
                    }
                    else
                    {
                        break;

                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Choice should be in number");
                }
                
            } while (true);

            Options _choice = (Options)int.Parse(Console.ReadLine());
            switch (_choice)
            {
                    case Options.CONSOLEINPUT : Console.WriteLine("Console Input");
                        float heightValue = PersonDetailsLib.PersonDetailsType.GetHeight();
                        float weightValue = PersonDetailsLib.PersonDetailsType.GetWeight();
                        float bmiValue = CalculatorLib.CalculatorType.Calculator(weightValue, heightValue);
                        string consoleMessage = ValidatorLib.ValidatorType.Validate(bmiValue);
                        ConsoleDisplayLib.ConsoleDisplayType.Display(consoleMessage);
                        Console.ReadLine();
                    break;
                    case Options.FILEINPUT: Console.WriteLine("File Input");

                        Console.WriteLine("Enter file path:");

                    Console.ReadLine();
                    
                    break;

               
            }
        }
    }
}
