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

namespace SortedNamesArrayList
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
            if (int.TryParse(inValues, out numberOfNames) == false || numberOfNames <=0)
            {
                Console.WriteLine("Invalid data entered! Please enter a whole number: ");
                inValues = Console.ReadLine();
            }
            //otherwise, write to numberOfNames
            else
            {
                numberOfNames = int.Parse(inValues);
            }

            //Define the arrays of string type
            //to store the  first name and last name
            String[] firstName = new String[numberOfNames];
            String[] lastName = new String[numberOfNames];
            //We also need an arraylist as well to store the first and last name arrays
            ArrayList arrayNames = new ArrayList();


            //Declare the required variables.
            int i = 0;
            //for loop for user to enter the names
            for (i = 0; i < numberOfNames; i++)
            {
                //Run the loop to get the names.

                //Prompt the user to enter the name.
                Console.WriteLine("Enter name {0} in the format 'FirstName LastName' (i.e. John Smith - separate first name from last name with a space): ", (i + 1));

                //temporary variable to read and store the input
                String temp = Console.ReadLine();
                //extra line for spacing
                Console.WriteLine("\n");
                //Remove the spaces
                temp = temp.Trim();

                //If the user didn't enter anything, the name will be blank - continue to allow user to enter input
                if (temp == "")
                {
                    Console.WriteLine("You entered an empty name. ");
                }

                else
                {
                    //Find the index of the
                    //first " " character.
                    int name_break = temp.LastIndexOf(" ");

                    //If the user entered the last name only.
                    if (name_break == -1)
                    {
                        lastName[i] = temp;
                        firstName[i] = "";
                    }

                    //otherwise, if a user entered both a first name and last name
                    else
                    {
                        //Seperate the name into
                        //first name and last name.
                        lastName[i] = temp.Substring((name_break + 1));
                        firstName[i] = temp.Substring(0, name_break);
                    }
                }


            }
            //Declare the required variables.
            int numberNames = i - 1;
            int ele_trav = 0;
            int swap_flag = 0;

            //Run the loop to order
            //the names as per the last names.
            while ((ele_trav < numberNames) && (swap_flag == 0))
            {
                swap_flag = 1;
                for (i = 0; i < (numberNames - ele_trav); i++)
                {
                    if (lastName[i].CompareTo(lastName[i + 1].ToLower()) > 0)
                    {
                        String temp = lastName[i];
                        lastName[i] = lastName[i + 1];
                        lastName[i + 1] = temp;
                        temp = firstName[i];
                        firstName[i] = firstName[i + 1];
                        firstName[i + 1] = temp;
                        swap_flag = 0;
                    }
                }
                ele_trav++;
            }

            //Run the loop to add both arrays to the arraylist arrayNames
            for (i = 0; i <= numberNames; i++)
            {
                //add the last name first to make it easier to keep things sorted
                arrayNames.Add(lastName[i]);
                //then add the first name to make it easier to keep things sorted
                arrayNames.Add(firstName[i]);
                ////display to console the last name first
                ////Display the last name.
                //Console.Write((i + 1) + ". " + arrayNames[i]);

                ////Check if their is a
                ////first name to be displayed.
                //if (arrayNames[i+1] != "")
                //{
                //    //Display the first name.
                //    Console.Write("," + arrayNames[i+1] + " ");
                //}
                ////Move to the next line.
                //Console.WriteLine("");
            }

            //Run the loop to display the names.
            for (i = 0; i <= numberNames; i++)
            {
                //Display the last name.
                Console.Write((i + 1) + ". " + lastName[i]);

                //Check if there is a
                //first name to be displayed.
                if (firstName[i] != "")
                {
                    //Display the first name.
                    Console.Write("," + firstName[i] + " ");
                }
                //Move to the next line.
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
