/*************************************************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell
 * Date: 03/28/2022
 * 
 * Purpose: "Sorted Collection of Names" - Write a program that allows the user to enter any number of names. Your prompt can inform 
 * the user to input their first name followed by a space and last name. Order the names in ascending order and display the results with 
 * the last name listed first, followed by a comma and then the first name. If a middle initial is entered, it should follow the first name. 
 * This solution takes into account some users only enter their last name and the values need to be stored to an ArrayList.
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #8, Programming Exercise #5 (Week 11 Group Project) 
*****************************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedNamesAL
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
            Console.WriteLine("*                   'Sorted Collection of Names'                     *");
            Console.WriteLine("*                      By: Twymun Safford                            *");
            Console.WriteLine("*  This program prompts a user to enter a set number of names -      *");
            Console.WriteLine("*  based upon entering first name, a space, and then last name       *");
            Console.WriteLine("*  (middle initial/name optional). This program then sorts           *");
            Console.WriteLine("*  those names!                                                      *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");
            //string value for user input
            string inValues;
            //integer corresponding to the number of names the user can enter
            int numberOfNames;


            //prompt user for the number of names they want tp enter
            Console.WriteLine("How many names would you like to enter? Please enter a whole number (greater than zero): ");
            //gather user input
            inValues = Console.ReadLine();
            //check to see if values are valid
            if (int.TryParse(inValues, out numberOfNames) == false || numberOfNames == 0)
            {
                Console.WriteLine("Invalid data entered! Please enter a whole number: ");
                inValues = Console.ReadLine();
            }
            //otherwise, write to numberOfNames
            else
            {
                numberOfNames = int.Parse(inValues);
            }
            //arraylist to store the first and last name arrays
            ArrayList arrayNames = new ArrayList(numberOfNames);
            //delimeter to determine if a first name/last name has been entered
            char delimiter = ' ';
            //Declare the required variables.
            int i = 0;
            //for loop for user to enter the names
            for (i = 0; i < numberOfNames; i++)
            {
                //Run the loop to get the names.

                //Prompt the user to enter the name.
                Console.WriteLine("\nEnter name {0} in the format 'FirstName LastName' (i.e. John Smith - separate first name from last name with a space): ", (i + 1));

                //temporary variable to read and store the input
                String temp = Console.ReadLine();
                //extra line for spacing
                Console.WriteLine("\n");
                //Remove the extra spaces
                temp = temp.Trim();
                int countSpaces = temp.Split(delimiter).Length - 1;
                //If the user didn't enter anything, the name will be blank - force user to enter something at least!
                while (temp.Length < 1)
                {
                    Console.WriteLine("\nYou entered an empty name. Please enter name {0} in 'Firstname LastName' format:  ", (i + 1));
                    //temporary variable to read and store the input
                    temp = Console.ReadLine();
                }
                //for a valid name entry add the name into the array list
                arrayNames.Add(temp);
            }

            Console.ReadKey();

            //print the array list in its original configuration
            Console.WriteLine("\nOriginally, the arraylist contained the following names you entered: ");
            Console.WriteLine("*===================*");
            Console.WriteLine("| First Name" + "|" + "Last Name" + "|");
            Console.WriteLine("*===================*");
            PrintArrayList(arrayNames);

            //section to sort list goes here
            NameToString(arrayNames);
            //sort here
            arrayNames.Sort();

            //print to screen the new sorted list
            Console.WriteLine("\nThe sorted arraylist by surname is now: ");
            Console.WriteLine("*===================*");
            Console.WriteLine("| Last Name" + "|" + "First Name" + "|");
            Console.WriteLine("*===================*");
            PrintArrayList(arrayNames);

            Console.ReadKey();
        }


        /**************************************
        Method - Print Output of List
        **************************************/
        public static void PrintArrayList(IEnumerable thisList)
        {
            //counter variable that assists with labeling each object
            int i = 0;
            //iterate through each object
            foreach (Object obj in thisList)
            {
                Console.WriteLine((i+1) + ".)" + " {0}", obj);
                //increment i by one 
                i++;
            }
        }

        /**************************************
        Method - Convert Into Last Name/First Name
        **************************************/
        public static void NameToString(ArrayList arrays)
        {
            int i = 0;
            for (i = 0; i < arrays.Count; i++)
            {
                //first, nab the names by converting each object to a string
                string name = arrays[i].ToString();
                //determine if the last index for the string is a space
                int nameBreak = name.LastIndexOf(' ');
                if (nameBreak != -1)
                {
                    name = name.Substring(nameBreak + 1) + ", " + name.Substring(0, nameBreak);
                }
                arrays[i] = name;
            }
        }



    }
}
