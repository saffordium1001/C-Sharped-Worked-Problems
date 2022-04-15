/*************************************************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley*
 * Date: 03/09/2022
 * 
 * Purpose: "Array Multiplication" - Create three arrays of type double. Do a compile-time initialization and 
 * place different values in two of the arrays. Write a program to store the product of the two arrays in the third array.
 * 
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #7, Programming Exercise #3 (Week 8 Group Project) 
*****************************************************************************************************************************************/


/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
using static System.Console;
//Array calculator
namespace ArrayMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
         /**************************************
         Program Welcome/Description-Main
         **************************************/
            //introduce user to the program
            WriteLine("**********************************************************************");
            //use a new line to separate the border line above from the program name below
            WriteLine("*                                                                    *");
            //describe what the program does 
            WriteLine("*                     'Array Multiplication'                         *");
            WriteLine("*                        By: Group 3                                 *");
            WriteLine("*  This program takes two arrays (double type), multiplies the       *");
            WriteLine("*  corresponding array elements by each other, and produces          *");
            WriteLine("*  a third array of type double with the same size.                  *");
            //finish here by enclosing the program description inside another border 
            WriteLine("*                                                                    *");
            WriteLine("**********************************************************************");
            WriteLine("\n");
            //declared and initialized
            double[] firstNums = new double[10];
            //declared and initialized
            double[] secondNums = new double[10];   
            //filled with calculated values
            double[] finalNums = new double[10];
            //use string variables to reference if they are integers
            string inValue = "";
            string secondValue="";
            ///first loop gets user input for 1st element and sets that array element
            //to user specified value; if the value is not of type double/
            //can be cast to doubele, error thrown
            for (int i = 0; i < firstNums.Length; i++)
            {
                WriteLine("Enter a value {0}: ", i + 1);
                inValue = ReadLine();
                if (double.TryParse(inValue, out firstNums[i]) == false)
                {
                    WriteLine("Invalid number.  0 stored in array");
                }
            }
            //for spacing
            WriteLine("\n\n");
            ///second loop gets user input for 2nd loop and sets that array element
            //to user specified value; if the value is not of type double/
            //can be cast to doubele, error thrown
            for (int j = 0; j < secondNums.Length; j++)
            {
                WriteLine("Enter value for second array {0}: ", j + 1);
                secondValue = ReadLine();
                if (double.TryParse(secondValue, out secondNums[j]) == false)
                {
                    WriteLine("Invalid number.  0 stored in array");
                }
            }
            //calculate the values in the final array
            for (int i = 0; i < finalNums.Length; i++)
            {
                finalNums[i] = firstNums[i] * secondNums[i];
            }
            WriteLine("\n");
            //print each line
            WriteLine("The results of matrix multiplication are: ");
            WriteLine("*==========================================================*");
            WriteLine("| 1st Array" + "\t|\t" + "2nd Array" + "\t|\t" + "3rd Array  |");
            WriteLine("*==========================================================*");
            for (int i =0; i <finalNums.Length; i++)
            {
                WriteLine( "| " + firstNums[i]  + "\t\t|\t"  + secondNums[i] + "\t\t|\t"  +finalNums[i] + "          |");
                WriteLine("------------------------------------------------------------");
            }
            ReadKey();
        }
    }
}

