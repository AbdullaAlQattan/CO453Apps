using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;

using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Abdulla AlQattan 14/12/2020
    /// </summary>
    public static class Program
    {
        private static DistanceConverter converter = new DistanceConverter();

        private static BMI calculator = new BMI();

        private static StudentGrades grades = new StudentGrades();

        private static NewsFeed newsFeed = new NewsFeed();

        public static BMI BMI
        {
            get => default;
        }

        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

            string[] choice = { "Distance Converter", "BMI Calculator",
                                "Student Marks", "Social Network"};
            /// new
            ///

            //int choiceNo = ConsoleHelper.SelectChoices(choices);

            //if (choiceNo ==1)
            //{
                //converter.ConvertDistance();
            //}
            //else if (choiceNo == 2)
            //{
                //calculator.CalculateIndex();
            //}
            //else if (choiceNo == 3)
            //{
                //calculator.CalculateIndex();
            //}

            ///old
            ///

            //DistanceConverter converter = new DistanceConverter();
            //converter.Run();

            //BMI calculator = new BMI();
            //calculator.Run();

            //StudentGrades studentGrades = new StudentGrades();
            //studentGrades.Run();

            MessagePost message = new MessagePost("Abdulla","hi");
            message.Run();
        }
    }
}