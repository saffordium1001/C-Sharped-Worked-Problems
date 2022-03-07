/***************************************************************************************************************************
 * Name: Twymun Safford
 * Date: 03/04/22 
 * 
 * Purpose: Write a program that includes an Employee class that can be used to calculate and print the take-home pay for 
 * a commissioned sales employee. All employees receive 7% of the total sales. Federal tax rate  is 18%. Retirement contribution 
 * is 10%. Social Security tax rate is 6%. Write instance methods to calculate the commission income, federal and social 
 * security tax withholding amounts and the amount withheld for retirement. Use appropriate constants, design an object-oriented 
 * solution, and write constructors. Include at least one mutator and one accessor method; provide properties for the other 
 * instance variables. Create a second class to test your design. Allow the user to enter values for the name of the employee 
 * and the sales amount for the week in the second class.
 * 
 * MAIN CLASS
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #4, Programming Exercise #8
****************************************************************************************************************************/
/**************************************
Import System Namespace
**************************************/
//import system namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayTakehome
{
    class Program
    {
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
            Console.WriteLine("*                   'Employee Pay Calculator'                        *");
            Console.WriteLine("*                      By: Twymun Safford                            *");
            Console.WriteLine("*  This program calculates the net take home pay of an employee      *");
            Console.WriteLine("*  based on commissions. This is based on the following factors:     *");
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("*  1.) Employees receive gross pay of 7% of the total sales made.    *");
            Console.WriteLine("*  2.) Federal tax rate on earnings is 18%.                          *");
            Console.WriteLine("*  3.) Retirement contribution is 10%.                               *");
            Console.WriteLine("*  4.) Social security tax is 6%.                                    *");
            Console.WriteLine("*  5.) Employee net pay is 66% of gross pay after tax.                *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");
            //create a new employee class object
            Employee karne = new Employee();
            //prompt user for input usin object
            karne.userInput();
            //describe user to screen
            Console.WriteLine("\nFor the employee you described, this is their earnings profile: ");
            Console.WriteLine(karne);
        }
    }
}
