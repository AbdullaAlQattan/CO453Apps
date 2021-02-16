using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in miles and it will calculate and
    /// output the equivalent distance in feet.
    /// </summary>
    /// <author>
    /// Abdulla AlQattan version 0.3 
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;

        public const double METERS_IN_MILES = 1609.34;

        private double miles;

        private double feet;

        private double meters;

        /// <summary>
        ///  This meathod will input the distance measured in miles
        ///  calculate it the same distance in feet, and output the distance
        ///  in feet.
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        public void MilesToMeters()
        {
            OutputHeading("Converting Miles to Meters");

            InputMiles();
            CalculateMiles();
            OutputMeters();
        }

        /// <summary>
        ///  Prompt the user to enter the distance in miles
        ///  Input the miles as a double number.
        /// </summary>


        private void OutputHeading(string title)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine($"         {title}                     ");
            Console.WriteLine("         by Abdulla AlQattan         ");
            Console.WriteLine("-------------------------------------\n");
        }

        private double InputMiles()
        {
            Console.Write("Please enter the number of miles > ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
            return miles;
        }

        private void InputMeters()
        {
            Console.Write("Please enter the number of meters > ");
            string value = Console.ReadLine();
            meters = Convert.ToDouble(value);
        }

        private void InputFeet()
        {
            Console.Write("Please enter the number of feet > ");
            string value = Console.ReadLine();
            feet = Convert.ToDouble(value);
        }

        /// <summary>
        /// 
        /// </summary>

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void CalculateMeters()
        {
            meters = miles * METERS_IN_MILES;
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + " feet! ");
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine(miles + " miles is " + " feet!");
        }

        /// <summary>
        /// 
        /// </summary>
        private void OutputMeters()
        {
            Console.WriteLine(miles + " miles is " + " feet!");
        }

    }
}
