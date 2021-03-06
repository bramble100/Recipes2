﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            Console.WriteLine("Print how many hours is spent with coding in a semester by an attendee,");
            Console.WriteLine("if the attendee only codes on workdays.");
            Console.WriteLine("Sum of hours is {0} hours", 17 * 6 * 5);

            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            Console.WriteLine("Average is: {0}%", 30.0 / 52.0 * 100);

            Console.ReadKey();
        }
    }
}
