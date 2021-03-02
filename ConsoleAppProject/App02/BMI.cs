using System;

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
            SelectUnits();
            InputMetricDetails();
            CalculateIndex();
            OutputHealthMessage();
            OutputBameMessage();

        }

        public void SelectUnits()
        {
          
        }

        public void InputMetricDetails()
        {

        }

        public void InputImperialDetails()
        {

        }

        public void CalculateIndex()
        {

        }

        public void OutputHealthMessage()
        {

        }

        public void OutputBameMessage()
        {

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
