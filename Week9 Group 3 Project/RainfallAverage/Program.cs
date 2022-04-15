/*************************************************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley*
 * Date: 03/09/2022
 * 
 * Purpose: "Rainfall Average Calculator" - Write an application that allows the user to input monthly rainfall 
 * amounts for one year storing the values in an array. Create a second 
 * array that holds the names of the month. Produce a report showing the 
 * month name along with the rainfall amount and its variance from the 
 * mean. Calculate and display the average rainfall for the year.
 * 
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #7, Programming Exercise #1 (Week 9 Group Project) 
*****************************************************************************************************************************************/


/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;

namespace RainfallAverage
{
    class Program
    {

        /**************************************
        Method - Get Rainfall from user
        **************************************/
        static void getData(string[] months, double[] rainFall)
        {
            //string - rainfall
            string recordRain;
            //integer check - for rain
            double rain;
            //Iterating over each month and reading values
            for (int i = 0; i < 12; i++)
            {
                Console.Write("\n Enter rainfall of " + months[i] + ": ");
                recordRain = Console.ReadLine();
                while (!double.TryParse(recordRain, out rain) || (rain < 0.0))
                {
                    Console.Write("\nYou entered an invalid entry. The rainfall needs to be a numeric value greater than or equal to 0. Please try again: ");
                    recordRain = Console.ReadLine();
                    //if statement - convert to number
                    if (double.TryParse(recordRain, out rain))
                    {
                        rain = double.Parse(recordRain);
                    }
                }
                rainFall[i] = rain;
            }
        }

        /**************************************
        Method - Calculate Mean
        **************************************/
        static double calculateMean(double[] rainFall)
        {
            double total = 0;

            //Iterating over array
            for (int i = 0; i < 12; i++)
            {
                //Accumulating rainfall
                total += rainFall[i];
            }

            return (total / 12.0);
        }
        /**************************************
        Method - Calculate Variance
        **************************************/
        static double calcVariance(double[] rainFall)
        {
            if (rainFall.Length > 1)
            {

                // Get the average of the value
                double avg = calculateMean(rainFall);
                double sumOfSquares = 0.0;
                foreach (int num in rainFall)

                {
                    sumOfSquares += Math.Pow((num - avg), 2.0);
                }
                return sumOfSquares / (double)(rainFall.Length - 1);
            }
            else { return 0.0; }
        }

        /**************************************
        Method - Print Results
        **************************************/
        static void showReport(string[] months, double[] rainFall, double mean, double variance)
        {
            //Printing header
            Console.WriteLine("\n Month Name ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Month Name | Rainfall | Difference from Mean");
            Console.WriteLine("-------------------------------");

            //Printing month wise data
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(String.Format("{0,-10} | {1,-10} | {2,5}", months[i], rainFall[i], Math.Abs(mean - rainFall[i])));
            }
            Console.WriteLine("-------------------------------");

            //Printing average rainfall
            Console.WriteLine("\n Average rainfall of the year: " + mean.ToString("0.00") + " \n");
            //Printing variance
            Console.WriteLine("\n Variance in rainfall for year: " + variance.ToString("0.00") + " \n");
        }

        //Main method
        static void Main(string[] args)
        {
         /**************************************
         Program Welcome/Description-Main
         **************************************/
            //introduce user to the program
            Console.WriteLine("**********************************************************************");
            //use a new line to separate the border line above from the program name below
            Console.WriteLine("*                                                                    *");
            //describe what the program does 
            Console.WriteLine("*                     'Rainfall Average Calculator'                  *");
            Console.WriteLine("*                        By: Group 3                                 *");
            Console.WriteLine("*  This program takes two arrays (double type), multiplies the       *");
            Console.WriteLine("*  corresponding array elements by each other, and produces          *");
            Console.WriteLine("*  a third array of type double with the same size.                  *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");
            //Array that holds month names
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            //Array that holds rain fall data
            double[] rainFall = new double[12];
            //Reading data
            getData(months, rainFall);
            //Finding mean
            double mean = calculateMean(rainFall);
            //find the variance
            double variance = calcVariance(rainFall);
            //Showing report
            showReport(months, rainFall, mean, variance);
            Console.Read();
        }
    }
}
