/***********************************************************************************
 * Programmer: Twymun Safford
 * Date: 01/16/22
 * Purpose: "Change Combinations" - program that prints the minimum number of quarters, 
 * dimes, nicklets, and pennies a customer gets back as change.
 * Prints the original amount and prints the combination with minimum number of coins.
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #2, Programming Exercise #4
**********************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
/**************************************
Define class Program
**************************************/
namespace chp2Problem4TKS
{
    class Program
    {
        //main method gets defined here
        static void Main(string[] args)
        {
            /**************************************
            Constant values for coin amounts here
            **************************************/
            //constant value for quarters
            const int QUARTER_VALUE = 25;
            //const value for dimes
            const int DIME_VALUE = 10;
            //const value for nickels
            const int NICKEL_VALUE = 5;
            //const value for pennies - did not find it necessary to use
            //const int PENNY_VALUE = 1;


            /**************************************
            Program Welcome/Description
            **************************************/
            //introduce user to the program
            Console.WriteLine("**********************************************************************");
            //use a new line to separate the border line above from the program name below
            Console.WriteLine("*                                                                    *");
            //describe what the program does 
            Console.WriteLine("*                    'Minimum Coins from Change'                     *");
            Console.WriteLine("*                    By: Twymun Safford                              *");
            Console.WriteLine("*  This program calculates the minimum number of quarters,           *");
            Console.WriteLine("*  dimes, nickels, and pennies from a given amount of change         *");
            Console.WriteLine("*  (0-100 coins).                                                    *");
            Console.WriteLine("*                                                                    *");
            //finish here by enclosing the initials inside another border 
            Console.WriteLine("**********************************************************************");

            /**************************************
          Variables declared here
          **************************************/
            //declare variable for change - tested with 27 and 92
            int cents = 92;
            //int cents = 92;
            //declare variables for quarters, dimes, nickels, and pennies
            int quarters, dimes, nickels, pennies;
            //integers - for the remainders in order to calculate change in fewest number of coins
            int modQuarters, modDimes, modNickels;
            //now, calculate the number of quarters - at worst, no quarters can be created from change (calculate min)
            quarters = (cents / QUARTER_VALUE);
            //now that numbers of quarters calculated, calculate the mode of those quarters
            modQuarters = cents % QUARTER_VALUE;
            //now, check how many dimes can be created
            dimes = (modQuarters / DIME_VALUE);
            //determine the modulus of the number of dimes that can be created
            modDimes = modQuarters % DIME_VALUE;
            //now, check how many nickels can be created
            nickels = (modDimes / NICKEL_VALUE);
            //check modulus of nickels - leaves us with number of pennies
            modNickels = modDimes % NICKEL_VALUE;
            //finally, set number of pennies equal to modNickels
            pennies = modNickels;
            //print statements
            Console.WriteLine("You specified that the amount of change you had was: {0:0.00} cents.", cents);
            Console.WriteLine("(This is: {0:C} dollars.)", (cents*0.01));
            Console.WriteLine("In the least amount of coins for each, your change can be given back as:  \n");
            Console.WriteLine("{0} quarter(s).", quarters);
            Console.WriteLine("{0} dime(s).", dimes); 
            Console.WriteLine("{0} nickel(s).", nickels); 
            Console.WriteLine("{0} penny(ies).", pennies);
            //waits for the final keypress so we can acknowledge the user read the lines
            Console.ReadLine();
        }
    }
}

