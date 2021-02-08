﻿using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// 
    /// This Project has been modified by:Abdulla AlQattan
    /// Abdulla AlQattan 14/12/2020
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Black;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine("Abdulla AlQattan");
            Console.WriteLine();

            Console.WriteLine(MyEnum.FirstValue.EnumValue());
            Console.WriteLine(MyEnum.FirstValue);
           
            
            // Console.WriteLine(MyEnum.SecondValue.GetDescription());


        }
    }
}
