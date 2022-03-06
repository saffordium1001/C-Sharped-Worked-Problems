
/***************************************************************************************************************************
 * Name: Twymun Safford
 * Date: 02/24/22 
 * 
 * Purpose: Write a program that allows the user to input any number of hexadecimal 
 * characters. Sum the values and display the sum as a hexadecimal value. 
 * Treat each single inputted character as a separate value. Within the 
 * loop, convert each character entered into its decimal equivalent. Display the original hex value 
 * and the corresponding decimal value. For example, if the user inputs F, 15 would be displayed as the decimal 
 * equivalent. Create a state-controlled loop structure. After all values are entered, display the sum of values 
 * entered in both hexadecimal and decimal notation.
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #6, Programming Exercise #6
****************************************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
using System.Text.RegularExpressions;

namespace HexadecimalConverter
{
    class Program
    {
        /**************************************
        Main Method
       **************************************/
        static void Main(string[] args)
        {
            //allows user(s) to enter the values 0-9 && A-F inclusive for hexadecimal - exclude special characters
            Regex regExpression = new Regex(@"^[0-9A-F]+$");
            //stores user input
            string input;
            //integer equivalents of user input
            int inputNumber;
            //store sum of values associated with user values added
            int sum = 0;
            //holds all input with addtional text
            string allInput = " ";
            /**************************************
            Program Welcome/Description-Main
            **************************************/
            //introduce user to the program
            Console.WriteLine("**********************************************************************");
            //use a new line to separate the border line above from the program name below
            Console.WriteLine("*                                                                    *");
            //describe what the program does 
            Console.WriteLine("*                     'Hexadecimal Converter'                        *");
            Console.WriteLine("*                        By: Twymun Safford                          *");
            Console.WriteLine("*  This program converts any integer number or entered letter        *");
            Console.WriteLine("*  (A-F) to their equivalents in both decimal and hexadecimal.       *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");
            //do-while loop - needs to assess that the user has not opted to quit with the character "Q"
            do
            {
                //prompt user to input an accepted character/integer for hexadecimal
                Console.WriteLine("Please enter a digit value 0-9 (inclusive) or A-F - press Q to stop entering values.");
                input = Console.ReadLine();
                //convert to decimal and hexadecimal only if the inputs are valid/user has not quit
                if (!input.ToUpper().Equals("Q") && ValidateEntry(input,regExpression))
                {
                    //calculate the sum from the input expression (convert to decimal if it hasn't been already)
                    sum += Convert.ToInt32(input, 16); //dealing with hexadecimal system
                    //if the number entered was 0-9
                    if (int.TryParse(input, out inputNumber))
                    {
                        allInput += "The decimal value " + input + " has the hexadecimal value " + inputNumber.ToString("X") + "\n";
                    }
                    //othwerwise, if characters A-F were entered, then convert them into decimal numbers
                    else
                    {
                        allInput += "The hexadecimal value " + input.ToString().ToUpper() + " has the decimal value of " + Convert.ToInt32(input, 16) + "\n";
                    }
                }
                Console.WriteLine("\n");
            } while (!input.ToUpper().Equals("Q"));//program will continue to accept input until user (Q)uits.
            Console.Write(allInput);//display allnumbers entered
            Console.WriteLine("\nThe Decimal Sum is: {0}", sum.ToString());
            //print the hexadecimal sum as well
            Console.WriteLine("The hexadecimal sum is: {0}", sum.ToString("X"));
        }

        /**************************************
        Boolean Method - Validate User Entry
       **************************************/
        private static bool ValidateEntry(string entry, Regex regEntry)
        {
            //check to see if only one character was entered; if so return false
            if (entry.Length > 1)
            {
                return false;

            }
            //make sure only valid numbers and letters could be entered and return false if otherwise
            else if (!regEntry.IsMatch(entry.ToUpper()))
            {
                return false; 
            }
            //return true in the case that criteria is met
            else
            {
                return true;
            }
        }
    }
}
