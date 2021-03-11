using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Abdulla AlQattan version 0.1
    /// </author>
    public class BMI
    {
        public enum Units { Metric,Imperial }
        public const int InchesInFeet = 12;
        public const int PoundsInStones = 14;

        public double Kilograms;
        public int Centimeters;

        public int Feet;
        public int Inch;
        public int Pounds;
        public int Stones;

        public void Run()
        {
            OutputHeading("BMI Calculator");
            /*SelectUnits();
            InputMetricDetails();
            InputImperialDetails();
            CalculateIndex();
            OutputHealthMessage();
            OutputBameMessage();*/


            string[] choices = new string[]
            {
                "Metric Units",
                "Imperial Units",
            };

            int choice = ConsoleHelper.SelectChoice(choices);
            SelectUnits(choice);

        }

        public void SelectUnits(int choice)
        {
            if(choice==1)
            {
                InputMetricDetails();
            }
            if(choice==2)
            {
                InputImperialDetails();

            }
        }

        public void InputMetricDetails()
        {

            Console.Write("Enter your height to the nearest meters\n\n\n");
            Console.Write("Enter your height in meters > ");
            string meter_value = Console.ReadLine();
            int height = Convert.ToInt16(meter_value);

           

            

            Console.Write("Enter your weight to the nearest Kilograms\n\n\n");
            Console.Write("Enter your weight in Kilograms > ");
            string kilograms_value = Console.ReadLine();
            double weight  = Convert.ToDouble(kilograms_value);


            

            CalculateIndex(height, weight, 1);
        }

        public void InputImperialDetails()
        {
            Console.Write("Enter your height to the nearest feet and inches\n\n\n");
            Console.Write("Enter your height in feet > ");
            string feet_value = Console.ReadLine();
            int height_feet = Convert.ToInt16(feet_value);

            //converting height from feet to inches
            double height_feet_inches = height_feet * 12.000;

            Console.Write("Enter your height in inches > ");
            string inches_value = Console.ReadLine();
            double height_inches = Convert.ToDouble(inches_value);

            double height = height_feet_inches + height_inches;


            Console.Write("Enter your weight to the nearest stones and pounds\n\n\n");
            Console.Write("Enter your weight in stones > ");
            string stones_value = Console.ReadLine();
            double weight_stones = Convert.ToDouble(stones_value);


            //converting weight from stones to pounds
            double weight_stones_pounds = weight_stones * 14;

            Console.Write("Enter your weight in pounds > ");
            string pounds_value = Console.ReadLine();
            double weight_pounds = Convert.ToDouble(pounds_value);

            double weight = weight_stones_pounds + weight_pounds;

            CalculateIndex(height,weight,2);
        }

        public void CalculateIndex(double height,double weight,int units)
        {
            if(units == 1 )
            {
                double bmi = (weight) / (height * height);

                OutputHealthMessage(bmi);
            }
            if (units == 2)
            {
                double bmi = (weight * 703) / (height * height);

                OutputHealthMessage(bmi);

            }
        }

        public void OutputHealthMessage(double bmi)
        {

            Console.Write("Your BMI is " + bmi);
            OutputBameMessage(bmi);
        }

        public void OutputBameMessage(double bmi)
        {
            if (bmi < 18.50)
            {
                Console.WriteLine("You are in Underweight range");
            }
            if (bmi > 18.5 && bmi < 24.9)
            {
                Console.WriteLine("You are in Normal range");
            }
            if (bmi > 25.0 && bmi < 29.9)
            {
                Console.WriteLine("You are in Overweight range");
            }
            if (bmi > 30.0 && bmi < 34.9)
            {
                Console.WriteLine("You are in Obese Class I range");
            }
            if (bmi > 35.0 && bmi < 39.9)
            {
                Console.WriteLine("You are in Obese Class II range");
            }
            if (bmi >= 40.0)
            {
                Console.WriteLine("You are in Obese Class III range");
            }

            Console.WriteLine("\n\n If you are black, Asian or other minority \n Ethnic groups, you have a higher risk");
            Console.WriteLine("\n\n Adult 23.0 or more are at increased risk \n Adults 27.5 or more are at high risk");
        }

        private void OutputHeading(string title)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine($"         {title}                     ");
            Console.WriteLine("         by Abdulla AlQattan         ");
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
