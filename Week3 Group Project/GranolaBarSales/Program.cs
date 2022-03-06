/***************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley, Justin Tanner 
 * Date: 01/28/22 
 * Purpose: "Granola Bar Sales" - program that calculates the profit the computer club has made
 * from selling granola bars to fund the computer club 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #3, Programming Exercise #8 (Week 3 Group Project) 
**************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;

namespace GranolaBarSales
{
    class Program
    {
        /**************************************
        Constants
        **************************************/
        //student government fees - 10 percent of gross sales
        const double STU_GOV_FEES = .10;
        //prices per case that needs to be purchased from vendor ($5.00/case)
        const double CASE_PRICE = 5.00;
        //number of candy bars per case
        const int NUMBER_BARS = 12;

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
            Console.WriteLine("*            'Profits from Granola Bar Sales'                        *");
            Console.WriteLine("*                      By: Group 3                                   *");
            Console.WriteLine("*  This program calculates and displays the amount of money          *");
            Console.WriteLine("*  the computer club will receive from the proceeds of selling       *");
            Console.WriteLine("*  cases of granola bars. A case contains 12 bars, each case         *");
            Console.WriteLine("*  gets brought for $5.00 a case (from the local vendor), and the    *");
            Console.WriteLine("*  club is required to provide the student government                *");
            Console.WriteLine("*  association 10% of their earnings.                                *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");

            /**************************************
            Variables declared here
            **************************************/
            // Declare the variables to store the values for the cases sold
            int casesSold;
            //price per bar
            double pricePerBar;
            //gross profits made
            double profits;
            //fees owed to the student government association
            double governmentFees;
            //the net income after student fees are deducted
            double grossIncome;

            /**************************************
            Methods
            **************************************/
            //returns number of cases sold
            casesSold = GetCasesSold();
            //returns the prices per granola bar
            pricePerBar = GetPricePerCase();
            //calculates initial profits for the granola bars
            profits = GetGrossProfit(casesSold, pricePerBar, CASE_PRICE, NUMBER_BARS);
            //calculates the student government fees that will be deducted
            governmentFees = GetFees(profits, STU_GOV_FEES);
            //calculates the gross income after SGA fees deducted
            grossIncome = GetNetProfit(governmentFees, profits);
            //prints the results to screen
            Console.WriteLine("\n");
            PrintResults(casesSold, pricePerBar, profits, governmentFees, grossIncome);
        }

        /**************************************
        Method - Number of Cases Sold
        **************************************/
        // Method that gets number of cases sold from user
        static int GetCasesSold()
        {
            int inventorySold;
            Console.WriteLine("Enter the number of cases sold: ");
            inventorySold = int.Parse(Console.ReadLine());
            return inventorySold;
        }

        // Method that gets the price per case from user
        static double GetPricePerCase()
        {
            double perBar;
            Console.WriteLine("\nEnter the price charged per bar: ");
            perBar = double.Parse(Console.ReadLine());
            return perBar;
        }

        // Method that calculates the gross profits from sold cases
        static double GetGrossProfit(int casesSold, double pricePerBar, double CASE_PRICE, int NUMBER_BARS)
        {
            double profitMade;
            profitMade = ((pricePerBar * NUMBER_BARS) - CASE_PRICE) * casesSold;
            return profitMade;
        }

        // Method that calculates the student government association fees owed
        static double GetFees(double profits, double STU_GOV_FEES)
        {
            //return as 10% of gross profits
            return (profits * STU_GOV_FEES);
        }

        //method that calculates the net profit from the granola bar sales 
        static double GetNetProfit(double proceeds, double profits)
        {
            //return net profit as profits - government fees
            return (profits - proceeds);
        }

        //method that prints the results of the sales
        static void PrintResults(int cases, double price, double profits, double government, double gross)
        {
            Console.WriteLine("The amount of cases sold were: " + cases);
            Console.WriteLine("The price per bar was: {0:C}", price);
            Console.WriteLine("The gross income was: {0:C}", profits);
            Console.WriteLine("The student government fees that had to be paid were: {0:C}", government);
            Console.WriteLine("Net profits were: {0:C}", gross);
        }


    }
}
