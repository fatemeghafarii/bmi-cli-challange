using System;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Collections;
namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {  
            /* for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Index : {i}, Value : {args[i]}");
            } */
            ProgramRunKey(args);
        } 
        static void ProgramRunKey(string[] args)
        {
            if(args.Length == 2 && args[0] == "bmi")
            {
                switch(args[1])
                {
                    case "--helps":
                        ProgramShowHelp();
                        break;
                    case "--versions":
                        ProgramShowVersion();
                        break;    
                }
            }
            else if(args.Length == 5 && args[0] == "bmi")
            {
               InputWieghtAndHeight(args);
            }
            else
            {
                Console.WriteLine("Invalid command :(\nUse --helps switch to show help");
            }
        }    
        static void ProgramShowHelp()
        {
            Console.Write($"Use these switch to run program:\n--height");
            Console.Write(" ".PadRight(8));
            Console.Write("Your height (centimeters)\n--weight");
            Console.Write(" ".PadRight(8));
            Console.Write("Your weight (kilograms)\n--version");
            Console.Write(" ".PadRight(8));
            Console.Write("Show current version\n--help");
            Console.Write(" ".PadRight(8));
            Console.Write("Show command list");
        }
        static void ProgramShowVersion()
        {
            Console.WriteLine("Current version is: 1.0");
        }
        static void BmiCalc(double height, int weight)
        {
            weight = Convert.ToInt32(Console.ReadLine());
            height = Convert.ToDouble(Console.ReadLine());

            double powHeight = Math.Pow(height, 2);
            double bmi = weight / powHeight;
            double roundBmi = Convert.ToDouble(Math.Round(bmi));
            Console.WriteLine("Your BMI Score is:");
            Console.WriteLine(roundBmi);

            if(bmi <= 18.4)
            Console.WriteLine("Your Status is: Underweight");
            else if(18.5 <= bmi ||  bmi <= 24.9)
            Console.WriteLine("Your Status is: Normal");
            else if(25.0 <= bmi || bmi <= 39.9)
            Console.WriteLine("Your Status is: Overweight");
            else if(bmi >= 40.0)
            Console.WriteLine("Your Status is: Obese");
        }
        static void InputWieghtAndHeight(string[] args)
        {
            if(args[1] == "--height" && args[3] == "--weight")
            {
                var height = Convert.ToDouble(args[2]);
                var weight = Convert.ToInt32(args[4]);
                BmiCalc(height, weight);
            }
            else if(args[1] == "--weight" && args[3] == "--height")
            {   
                var weight = Convert.ToInt32(args[2]);
                var height = Convert.ToDouble(args[4]);
                BmiCalc(height, weight);
            }
        }
    }    
}

