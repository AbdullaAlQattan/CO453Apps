using System;
using ConsoleAppProject.Helpers;
using ConsoleAppProject.App01;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This App will prompt the user to input a distance
    /// measured in miles, feet and Meters and it will calculate and
    /// output the equivalent distance in the other units specified by the user.
    /// Need to upgarde the choosing of units
    /// documentation
    /// testing 
    /// </summary>
    /// <author>
    /// Abdulla AlQattan version 0.3 
    /// </author>
    public class DistanceConverter
    {
        public const double FEET_IN_MILES = 0.000189394;
        public const int MILES_IN_FEET = 5280;

        public const double METERS_IN_MILES = 0.000621371;
        public const double MILES_IN_METERS = 1609.34;

        public const double FEET_IN_METERS = 0.3048;
        public const double METERS_IN_FEET = 3.28084;

        private double miles;
        private double feet;
        private double meters;

        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }



        /// <summary>
        ///  This meathod will input the distance measured in miles
        ///  calculate it the same distance in feet, and output the distance
        ///  in feet.
        /// </summary>


        public void Run()
        {
            string[] choices = new string[]
            {
                "Miles to Feet",
                "Feet to Miles",
                "Miles to Meters",
                "Meters to Miles",
                "Feet to Meters",
                "Meters to Feet"
            };
            int choice = ConsoleHelper.SelectChoice(choices);

            switch (choice)
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


                case 4:

                    MetersToMiles();
                    break;


                case 5:

                    FeetToMeters();
                    break;


                case 6:

                    MetersToFeet();
                    break;

                default:
                    Console.Write("Invalid Choice Selected ");
                    break;

            }

        }
        /// <summary>
        /// This Method is used to Read input in miles, calculate from miles to feet and then displays in output in feet
        /// </summary>
        public void MilesToFeet()
        {
            OutputHeading("Converting Miles to Feet");

            InputMiles();
            CalculateMilesToFeet();
            OutputFeet();
        }
        /// <summary>
        /// This Method is used to Read input in Feet, calculate from Feet to Miles and then displays output in Miles
        /// </summary>
        public void FeetToMiles()
        {
            OutputHeading("Converting Feet to Miles");

            InputFeet();
            CalculateFeetToMiles();
            OutputMiles();
        }
        /// <summary>
        /// This Method is used to Read input in Miles, calculate from Miles to Meters and then displays in output in Kilometers
        /// </summary>
        public void MilesToMeters()
        {
            OutputHeading("Converting Miles to Meters");

            InputMiles();
            CalculateMilesToMeters();
            OutputMeters();

        }

        /// <summary>
        /// This Method is used to Read input input in Meters, calculate from Meters to Miles and then displays output in Miles 
        /// </summary>
        public void MetersToMiles()
        {
            OutputHeading("Converting Meters to Miles");

            InputMeters();
            CalculateMetersToMiles();
            OutputMiles();
        }

        public void FeetToMeters()
        {
            OutputHeading("Converting Feet to Meters");

            InputFeet();
            CalculateFeetToMeters();
            OutputMeters();
        }

        public void MetersToFeet()
        {
            OutputHeading("Converting Meters to Feet");

            InputMeters();
            CalculateMetersToFeet();
            OutputFeet();
        }


        /// <summary>
        ///  This method outputs the heading showing the title and name of the
        ///  author.
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
        /// This Method is reading the input in Miles
        /// </summary>

        private double InputMiles()
        {
            miles = ConsoleHelper.InputNumber("Please enter the number of miles > ");
            return miles;
        }
        /// <summary>
        /// This Method is reading the Input in Meters
        /// </summary>
        private void InputMeters()
        {
            meters = ConsoleHelper.InputNumber("Please enter the number of meters > ");
        }
        /// <summary>
        /// This Method is reading the Input in Feet
        /// </summary>
        private void InputFeet()
        {
            feet = ConsoleHelper.InputNumber("Please enter the number of feet > ");
        }

        /// <summary>
        /// This method is converting from Miles to Feet
        /// </summary>

        private void CalculateMilesToFeet()
        {
            feet = miles * MILES_IN_FEET;
        }

        /// <summary>
        /// This method is converting from feet to miles
        /// </summary>
        private void CalculateFeetToMiles()
        {
            miles = feet * FEET_IN_MILES;
        }

        /// <summary>
        /// This method is converting from miles to Meters
        /// </summary>
        private void CalculateMilesToMeters()
        {
            meters = miles * MILES_IN_METERS;
        }





        /// <summary>
        /// This method is converting from meters to miles
        /// </summary>
        /// 
        private void CalculateMetersToMiles()
        {
            miles = meters * METERS_IN_MILES;
        }



        /// <summary>
        /// This method is converting from feet to Meters
        /// </summary>
        /// 
        private void CalculateFeetToMeters()
        {
            meters = feet * FEET_IN_METERS;
        }



        /// <summary>
        /// This method is converting from meters to feet
        /// </summary>
        /// 
        private void CalculateMetersToFeet()
        {
            feet = meters * METERS_IN_FEET;
        }

        /// <summary>
        /// This method is displaying output in feet
        /// </summary>


        private void OutputFeet()
        {
            Console.WriteLine(feet + " feet! ");
        }



        /// <summary>
        /// This method is displaying output in miles
        /// </summary>






        private void OutputMiles()
        {
            Console.WriteLine(miles.ToString("F1") + " miles ");
        }


        /// <summary>
        ///This method is displaying output in Meters
        /// 
        /// </summary>

        private void OutputMeters()
        {
            Console.WriteLine(meters.ToString("F1") + " meters!");
        }
        /// <summary>
        ///This method is displaying output in meters
        /// 
        /// </summary>


    }
}

