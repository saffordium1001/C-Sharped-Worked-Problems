/*************************************************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley, Justin Tanner 
 * Date: 02/26/2022 
 * 
 * Purpose: "Park Tourism Record" - There are a number of national and state parks available to tourists. 
 * Create a Park class. Include data members such as name of park, location,  type of (i.e., national, state, and local)
 * facility, fee, number of employees, number of visitors recorded for the past 12 months, and annual budget. Write separate 
 * instance methods that (1) return a string representing name of the park, the location, and type of park; (2) 
 * return a string representing the name of the park, the location, and facilities available; (3) compute cost per visitor based on 
 * annual budget and the number of visitors during the last 12 months; and (4) compute revenue from fees for the past year based on number 
 * of visitors and fee. Also include a ToString( ) method that returns all data members with appropriate labels. Create a second class to 
 * test your Park class.
 * 
 * THIS IS THE MAIN CLASS
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #4, Programming Exercise #7 (Week 4 Group Project) 
*****************************************************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
using static System.Console;

namespace Chap_4_Ex7
{
    /**************************************
     Main Class
    **************************************/
    internal class Program
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
            Console.WriteLine("*                   'Park Tourism Record'                            *");
            Console.WriteLine("*                      By: Group 3                                   *");
            Console.WriteLine("*  This program creates an organized list for a park's/parks         *");
            Console.WriteLine("*  name, location, type (national/state/local), facility,            *");
            Console.WriteLine("*  fee, number of employees, number of visitors recorded for past    *");
            Console.WriteLine("*  12 months, and annual budget.                                     *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");

            //create a new park object
            Park np = new Park();

            //park name
            np.PName = "Sleeping Bear Dunes";
            //park type
            np.Type = "National";
            //park location
            np.Location = "Empire, MI";
            //park facility type
            np.Facility = "Lighthouse, Dunes";
            //enumber of employees
            np.Employees = 100;
            //number of visitors
            np.Visitors = 1000;
            //admissions
            np.Admission = 25;
            //budget
            np.ABudget = 100000;
            //write to console
            WriteLine(np);
            //read a key
            ReadKey();
        }
    }
}

