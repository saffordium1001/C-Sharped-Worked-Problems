/*************************************************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell
 * Date: 03/28/2022
 * 
 * Purpose: "Customer Code Application" - Write a two-class application that creates a customer code to be placed 
 * on a mailing label for a magazine. Allow the user to input their full name with the first name entered first. Prompt them to separate
 * their first and last name with a space. Ask for their birthdate in the format of mm/dd/yyyy. Ask for the month (number) they purchased 
 * a subscription and ask for their zip code. Your mailing label should contain the last name, followed by their year of birth, the number 
 * of characters in the full name, the first three characters of the month they purchased the subscription, and the last two digits of 
 * their zip. The code for Bob Clocksom born 01/22/1993, who purchased his subscription during the 10th month of the year and lists 32226 as 
 * his zip code would be Clocksom9312Oct26
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660) - Main Class/Driver
 * Assignment: Chapter #8, Programming Exercise #4 (Week 9 Group Project) 
*****************************************************************************************************************************************/


/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;

namespace CustomerCode
{
    class Program
    {
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
            Console.WriteLine("*                   'Customer Code Application'                      *");
            Console.WriteLine("*                        By: Group 3                                 *");
            Console.WriteLine("*  This program prints a customer code to be placed on a mailing     *");
            Console.WriteLine("*  label for a magazine based on the first and last name,            *");
            Console.WriteLine("*  birthdate, zip code, and purchase date of subscription.           *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");
            //Declare the needed variables.
            string fName;
            string bDate;
            int mNumber;
            int zCode;
            string inVal;
            char runAgain = 'N';

            //Do While loop().
            do
            {
                //Function call to GetDetails().
                GetDetails(out fName, out bDate, out mNumber, out zCode);
                //Creating new instance.
                CustomerClass customer = new CustomerClass(fName, bDate, mNumber);
                //Output.
                Console.WriteLine("\nThe customer code (variant 1) is : {0}{1}{2}{3}{4}", customer.pLastName, customer.pBirthYear % 100, customer.pCount, customer.pPurchaseMonth, zCode % 100);
                Console.WriteLine("\nThe customer code (variant 2) is : {0}{1}{2}{3}", customer.pLastName, customer.pBirthYear % 100, customer.pPurchaseMonth, zCode % 100);
                Console.WriteLine("\nThe customer code (variant 3) is : {0}{1}{2}{3}", customer.pFirstName, mNumber, zCode %10, customer.pBirthYear % 100);
                Console.WriteLine("\nThe customer code (variant 4) is : {0}{1}{2}", zCode/100, customer.pLastName, customer.pBirthDay);
                //Print a new line.
                Console.WriteLine();
                //Prompt the user.
                Console.WriteLine("\nWould you like to enter another customer code Enter [Y/y] for Yes or any other key to end.");
                //Get the input.
                inVal = Console.ReadLine();
                //Convert input.
                runAgain = Convert.ToChar(inVal);
                Console.Read();
            }

            //End of Do While loop().
            while ((runAgain == 'Y') || (runAgain == 'y'));
        }


        /**************************************
        Method - Get Customer Details
        **************************************/
        public static void GetDetails(out string fName, out string bDate, out int mNumber, out int zCode)
        {
            //Prompt the user for full name
            Console.Write("\nPlease enter the customer's name in the format 'FirstName LastName' (include a space between them): ");
            //Get the input
            fName = Console.ReadLine();
            //Prompt the user for Birth date
            Console.Write("\nPlease enter the customer's birthdate in the format (mm/dd/yyyy): ");
            //Get the input
            bDate = Console.ReadLine();
            //Prompt the user for Month subscription
            Console.Write("\nPlease enter the month the customer purchased the subscription in (Month Number - i.e., January is 1): ");
            //Get the input
            mNumber = int.Parse(Console.ReadLine());
            //check to see if user input a correct month
            if(mNumber > 12 || mNumber <0 )
            {
                Console.Write("\nInvalid entry. Please enter the month the customer purchased the subscription in (i.e., January is 1): ");
                mNumber = int.Parse(Console.ReadLine());
            }
            //Prompt the user for ZIP
            Console.Write("\nPlease enter the customer's ZIP code in format '12345': ");
            //Get the input
            zCode = int.Parse(Console.ReadLine());
        }
    }
}
