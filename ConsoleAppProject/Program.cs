﻿using ConsoleAppProject.App01;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Liam Lopez 02/02/2024
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("BNU CO453 Applications Programming 2022-2023!");
            Console.WriteLine();
            Console.Beep();

            DistanceConverter converter = new DistanceConverter();
            converter.Run();
        }     
    }
}


