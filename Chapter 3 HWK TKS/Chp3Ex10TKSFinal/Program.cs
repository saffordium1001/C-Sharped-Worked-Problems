/***********************************************************************************
 * Programmer: Twymun Safford
 * Date: 02/05/22
 * Purpose: "Property Tax Calculator" - Program that calculates the property tax
 * for an owner for the year based on their home's assessed value and annual
 * mileage.
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #3, Programming Exercise #10
**********************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
/**************************************
Define class Program
**************************************/
namespace Chp3Problem10TKS
{
    class Program
    {
        /**************************************
         Constant values for calculations here
        **************************************/
        //mileage rate for year per 1000 dollars
        const decimal ANNUAL_MILEAGE_RATE = 10.03M;
        //homeowner exemption - subtract from assessed value prior to taxes
        const int HOME_OWNER_EXEMPTION = 25000;
        //increase on prperties assessed values
        const decimal PERCENT_INCREASE = 0.027M;

        /**************************************
        Main Method
        **************************************/
        static void Main(string[] args)
        {
            /**************************************
            Program Welcome/Description
            **************************************/
            //introduce user to the program
            Console.WriteLine("**********************************************************************");
            //use a new line to separate the border line above from the program name below
            Console.WriteLine("*                                                                    *");
            //describe what the program does 
            Console.WriteLine("*                    'Property Tax Calculator'                       *");
            Console.WriteLine("*                      By: Twymun Safford                            *");
            Console.WriteLine("*  This program calculates the property tax for a homewoner          *");
            Console.WriteLine("*  based on the reassessed value of their home in a particular       *");
            Console.WriteLine("*  township. This is based on mileage rate, exemptions,              *");
            Console.WriteLine("*  and additional percentage charges.                                *");
            Console.WriteLine("*                                                                    *");
            //finish here by enclosing the initials inside another border 
            Console.WriteLine("**********************************************************************");
            /**************************************
            Variables declared here/inputs received
            **************************************/
            //get the address
            string getAddress;
            //get the previous assessed value
            decimal previousValue;
            //reassessed value
            decimal reAssessedValue;
            //taxable value
            decimal taxable;
            //hold computation for taxes
            decimal newTax;
            //prompt user for address
            Console.WriteLine("\nPlease input your address: ");
            getAddress = Console.ReadLine();
            //prompt user for their home's previous value
            Console.WriteLine("\nPlease enter your home's previously assessed value (cents permitted): ");
            //convert input to decimal and store to previousValue
            previousValue = decimal.Parse(Console.ReadLine());
            //call method here to calculate new assessed value
            reAssessedValue = NewAssessedValue(PERCENT_INCREASE, previousValue);
            //calculate taxable value
            taxable = reAssessedValue - HOME_OWNER_EXEMPTION;
            //call method here to compute taxes owed
            newTax = TaxesOwed(ANNUAL_MILEAGE_RATE, taxable);
            //use print method to print the results
            PrintResults(HOME_OWNER_EXEMPTION, ANNUAL_MILEAGE_RATE, PERCENT_INCREASE, getAddress, previousValue, reAssessedValue, taxable, newTax);
            Console.ReadKey();
        }

        /**************************************
        New Assessed Value
        **************************************/
        //calcuates the new assessed value of home
        static decimal NewAssessedValue(decimal percent, decimal currentValue)
        {
            //return as current value times 1 + percent change
            return (currentValue * (1 + percent));
        }

        /**************************************
        Calculate Taxes Owed
        **************************************/
        //method to calculate the taxes a user owes on their property - needs to consider if user is a homeowner
        static decimal TaxesOwed(decimal mileageRate, decimal taxed)
        {
            //return as assessed value minus the exemption times (10.03/1000)
            return (taxed / 1000) * mileageRate;
        }


        /**************************************
        Print Results
        **************************************/
        //method to print the results to screen
        static void PrintResults(int exempt, decimal mileRate, decimal rateIncrease, string address, decimal lastAssessed, decimal currentAssessed, decimal taxing, decimal taxesDue)
        {
            //sort with street address, last assessed home value, and increase in percentage value
            Console.WriteLine($"\n===============================");
            Console.WriteLine($"Street Address: {address}");
            Console.WriteLine($"Last Year Assessed Value:    {lastAssessed:C}");
            Console.WriteLine($"Increase in Value: {rateIncrease:P}");
            Console.WriteLine($"===============================");
            //calculate reassessed value and tax exemption
            Console.WriteLine($"Current Assessed Value:     {currentAssessed:C}");
            Console.WriteLine($"Exemption:         {exempt:C}");
            Console.WriteLine($"===============================");
            //show taxable value and mileage rate per $1000
            Console.WriteLine($"Taxable Value:     {taxing:C}");
            Console.WriteLine($"Mileage Rate(per $1000)          {mileRate:C}");
            Console.WriteLine($"===============================");
            //print the taxes user owes
            Console.WriteLine($"Taxes Owed:         {taxesDue:C}");
        }
    }
}
