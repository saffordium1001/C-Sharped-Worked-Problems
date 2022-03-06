/***************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley, Justin Tanner 
 * Date: 02/08/22 
 * Purpose: "BMI Calculator" - program that calculates the BMI of client based on both metric and
 * imperial units
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #5, Programming Exercise #3 (Week 4 Group Project) 
**************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;

/**************************************
Namespace BMI Calculator
**************************************/
namespace BMICalculator
{
    /**************************************
    Namespace BMI Calculator
    **************************************/
    class BMI
    {
        double weight;
        double height;
        int userChoice;
        //default constructor
        public BMI()
        {
            this.weight = 0.00;
            this.height = 0.00;
            this.userChoice = 0;
        }
        //parameterized constructor
        public BMI(double wt, double ht, int choice)
        {
            this.weight = wt;
            this.height = ht;
            this.userChoice = choice;
        }
        //method to input user choice
        public void input()
        {
            //first, utilize a switch case statement to determine if the user
            //wants to use metric or imperial units
            Console.WriteLine("**********************************");
            //use a new line to separate the border line above from the program name below
            Console.WriteLine("* For Metric units, enter (1).   *");
            Console.WriteLine("* For Imperial units, enter (2). *");
            //describe what the program does 
            Console.WriteLine("**********************************");
            Console.WriteLine("\n");
            userChoice = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter weight in kilograms: ");
            //weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Enter height in meters: ");
            //height = Convert.ToDouble(Console.ReadLine());
        }

        //function to input height and weight, calculate BMI, and display
        public void BMIstatus()
        {
            double bmi;
            //use switch case statements to determine if the user 
            switch (userChoice)
            {
                //user selected to use metric units
                case 1:
                    {
                        Console.WriteLine("\nEnter weight in kilograms: ");
                        weight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nEnter height in meters: ");
                        height = Convert.ToDouble(Console.ReadLine());
                        //metric BMI is calculated as weight (in kg) divided by height squared
                        bmi = weight / Math.Pow(height, 2);
                        break;
                    }
                //user selected to use imperial units
                case 2:
                    {
                        Console.WriteLine("\nEnter weight in pounds: ");
                        weight = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("\nEnter height in inches: ");
                        height = Convert.ToDouble(Console.ReadLine());
                        //metric BMI is calculated as weight (in kg) divided by height squared
                        bmi = (weight / Math.Pow(height, 2)) * 703;
                        break;
                    }
                //user entered an invalid selection
                default:
                    {
                        Console.WriteLine("\nInvalid selection! Terminating program now.");
                        //quit the program now
                        return;
                    }
            }
            //print the individual's BMI:
            Console.WriteLine("\nThis user's BMI is: {0:0.00} ", bmi);
            if (bmi < 18.5)
            {
                Console.WriteLine("\nThis person is underweight!");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine("\nThis person's weight is normal.");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine("\nThis person is overweight.");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine("\nThis person is Obese!");
            }
        }
    }
    class Program
    {
        /**************************************
        Main
        **************************************/
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
            Console.WriteLine("*                   'BMI Calculator'                                 *");
            Console.WriteLine("*                      By: Group 3                                   *");
            Console.WriteLine("*  This program calculates the BMI of an individual based upon       *");
            Console.WriteLine("*  either the metric system or the imperial system (user choice).    *");
            Console.WriteLine("*  The user's BMI is based on their weight and height.               *");
            Console.WriteLine("*  For metric, it is the user's weight divided by their height       *");
            Console.WriteLine("*  squared. For imperial, it is the user's weight divided by         *");
            Console.WriteLine("*  their height squared times 703.                                   *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");

            /**************************************
            Remind User of BMI Values
            **************************************/
            Console.WriteLine("A reminder that for the BMI scale:\n");

            Console.WriteLine("======================================");
            Console.WriteLine("|   BMI          |  Weight Status    |");
            Console.WriteLine("======================================");
            Console.WriteLine("|   < 18.5       |  Underweight      |");
            Console.WriteLine("======================================");
            Console.WriteLine("|   18.5-24.9    |  Normal           |");
            Console.WriteLine("======================================");
            Console.WriteLine("|   25.0-29.9    |  Overweight       |");
            Console.WriteLine("======================================");
            Console.WriteLine("|   >=30.0       |  Obese            |");
            Console.WriteLine("======================================");

            /**************************************
            Method Calls
            **************************************/
            //create a new user profile
            BMI person1 = new BMI();
            //call input method to get weight and height
            person1.input();
            //calculate and output to screen user's BMI
            person1.BMIstatus();
        }
    }
}
