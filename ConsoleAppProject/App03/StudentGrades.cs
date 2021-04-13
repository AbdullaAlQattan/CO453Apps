using System;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    /// <summary>
    /// 
    /// </summary>
    public class StudentGrades
    {
        public string[] Students { get; set; }

        public int[] Marks { get; set; }

        public int[] GradeProfile { get; set; }

        public double Mean { get; set; }

        public int Minimum { get; set; }

        public int Maximum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public StudentGrades()
        {
            Students = new string[]
            {
                "Abdulla", "Isa", "Mohammed",
                "Hamad", "Khalifa", "Fahad",
                "Khalid", "Salman", "Sultan",
                "Nawaf"
            };

            GradeProfile = new int[(int)Grades.A + 1];
            Marks = new int[Students.Length];
            Minimum = 0;
            Maximum = 0;
            Mean = 0;
            

        }
        public void Run()
        {
            ConsoleHelper.OutputHeading("App03 Student Grades");
            InputMarks();
            OutputMarks();
            MarksRanges();
        }

        public Grades ConvertToGrade(int mark)
        {
            if (mark <40)
            {
                return Grades.F;
            }

            else
                if (mark < 50)
            {
                return Grades.D;
            }

            else
                if (mark < 60)
            {
                return Grades.C;
            }

            else
                if (mark < 70)
            {
                return Grades.B;
            }

            else
                if (mark <= 100)
            {
                return Grades.A;
            }
             
            return Grades.X;
            
        }

        public void MarksRanges()
        {
            int index = 0;
            int total = 0;
            int lowest = Marks[0];
            int highest = Marks[0];
             



            foreach (string student in Students)
            {
                if (lowest > Marks[index])
                {
                    lowest = Marks[index];
                }

                if (highest < Marks[index])
                {
                    highest = Marks[index];
                }

                total =total+Marks[index];
                
                index++;
            }
            Console.WriteLine("\nMean of Marks is");
            Mean = total / 10;
            Console.WriteLine(Mean);
            Minimum = lowest;
            Console.WriteLine("\nMinimum Mark is");
            Console.WriteLine(Minimum);
            Maximum = highest;
            Console.WriteLine("\nMaximum Mark is");
            Console.WriteLine(Maximum);
        }
            
            

            public void InputMarks()
        {
            ConsoleHelper.OutputTitle("Inputting Student Marks");
            int index = 0;
           foreach(string student in Students)
            {
                Marks[index] = (int)ConsoleHelper.InputNumber
                    ($"Please enter a mark for {student} > ", 0, 100);
                index++;

            }

        }
        public void OutputMarks()
        {
            ConsoleHelper.OutputTitle("Outputting Student Marks");
            int index = 0;
            foreach (string student in Students)
            {
                Grades grade = ConvertToGrade(Marks[index]);
                Console.WriteLine($"Mark for {student} {Marks[index]}" + $" { grade }");
                index++;
            }
        }


    }
}
