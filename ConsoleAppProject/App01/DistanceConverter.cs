using System;
using ConsoleAppProject.Helpers;
using ConsoleAppProject.App01;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in miles, feet and meters and it will calculate and
    /// output the equivalent distance in the other units specified by the user.
    ///
    /// Need to upgarde the choosing of units
    /// docutmation
    /// testing 
    /// </summary>
    /// <author>
    /// Abdulla AlQattan version 0.3 
    /// </author>
    public class DistanceConverter
    {
        public const int FEET_IN_MILES = 5280;
        public const double METERS_IN_MILES = 1609.34;
        public const double FEET_IN_METERS = 3.28084;

        private double miles;
        private double feet;
        private double meters;

        public void Run()
        {
            string[] choices = new string[]
            {
                "miles to feet",
                "feet to miles",
                "miles to meters",
            };
            int choice = ConsoleHelper.SelectChoice(choices);

            switch(choice)
            {
                case 1:

                    MilesToFeet();
                    break;

                case 2:

                    FeetToMiles();
                    break;

                case 3:

                    MilesToMeters();
                    break;

                default:
                    Console.Write("Invalid Choice Selected ");
                    break;

            }

        }

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
            CalculateMeters();
            OutputMeters();
        }

        /// <summary>
        ///  Prompt the user to enter the distance in miles
        ///  Input the miles as a double number.
        /// </summary>


        private void OutputHeading(String title)
        {
            Console.WriteLine("\n-------------------------------------");
            Console.WriteLine($"         {title}                     ");
            Console.WriteLine("         by Abdulla AlQattan         ");
            Console.WriteLine("-------------------------------------\n");

            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        ///  This method outputs the heading showing the title and name of the
        ///  author.
        /// </summary>


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
        /// This method shows the input of the units and 
        /// </summary>

        private void CalculateFeet()
        {
            feet = miles * FEET_IN_MILES;
        }

        /// <summary>
        /// This method is converting from miles to feet
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet / FEET_IN_MILES;
        }

        /// <summary>
        /// This method is converting from feet to miles
        /// </summary>
        private void CalculateMeters()
        {
            meters = miles * METERS_IN_MILES;
        }

        /// <summary>
        /// This method is converting from miles to meteres
        /// </summary>
        private void OutputFeet()
        {
            Console.WriteLine( feet + " feet! ");
        }

        /// <summary>
        /// This method is displaying output in feet
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine(miles + " miles ");
        }

        /// <summary>
        /// This method is displaying output in miles
        /// </summary>
        private void OutputMeters()
        {
            Console.WriteLine( meters + " meters!");
        }
        /// <summary>
        ///This method is displaying output in meters
        /// 
        /// </summary>


    }
}
