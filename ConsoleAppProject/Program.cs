using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
using ConsoleAppProject.Helpers;
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

        private static NetworkApp app04 = new NetworkApp();
        
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
                                "Student Marks","Social Network"};


            int choiceNo = ConsoleHelper.SelectChoices(choice);

            if (choiceNo == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (choiceNo == 2)
            {
                BMI calculator = new BMI();
                calculator.Run();
            }
            else if (choiceNo == 3)
            {
                StudentGrades studentGrades = new StudentGrades();
                studentGrades.Run();
            }
            else if (choiceNo == 4)
            {
                MessagePost message = new MessagePost("Abdulla","hi");
                message.Run();
            }
        }
    }
}
