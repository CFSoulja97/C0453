﻿using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// The purpose of this app is convert distance.
    /// </summary>
    /// <author>
    /// Liam Lopez
    /// </author>
    public class DistanceConverter
    {
        private double miles;

        private double feet;

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }
        /// <summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles  >   ");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }
        
        private void CalculateFeet()
        {

        }
        
        private void OutputFeet()
        {

        }
    }
}
