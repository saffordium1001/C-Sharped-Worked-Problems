/***************************************************************************************************************************
 * Name: Twymun Safford
 * Date: 03/19/2022 
 * 
 * Purpose: Write a program that will produce a report showing the current and maximum enrollments for a number of classes. 
 * Your applications should be designed with two classes. The first class should include data members for the name of the course, 
 * current enrollment, and maximum enrollment. Include an instance method that returns the number of students that can still 
 * enroll in the course. The ToString( ) method should return the name of the course, current enrollment, and the number of 
 * open slots. In the implementation class, declare parallel arrays and do  a compile-time initialization for the name of the 
 * course, current enrollment, and maximum enrollment. Also declare an array of class objects in your implementation class.
 * 
 * In the main class, use arrays, not ArrayList to store multiple class names, current and maximum enrollment. Use these arrays to 
 * initialize the fields of each created Course object. Store the created Course objects in another array of type Course, that is 
 * an array of objects. Because you're using arrays, that means you will need to set the size from the beginning. For example, 
 * you can ask the user how many courses to enter and use that to set the array size
 * 
 * PROGRAM CLASS
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #7, Programming Exercise #10
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

namespace CourseEnrollment
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
            Console.WriteLine("*                   'Course Schedule Display'                        *");
            Console.WriteLine("*                      By: Twymun Safford                            *");
            Console.WriteLine("*  This program displays the current and maximum enrollments for     *");
            Console.WriteLine("*  a number of courses along with the number of remaining seats      *");
            Console.WriteLine("*  for a course. This is based upon the user entering course name,   *");
            Console.WriteLine("*  number of course enrollments, and maximum course capacity.        *");
            Console.WriteLine("*  The number of remaining seats will be calculated.                 *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");

            //string x - used for input for user entering number of courses
            string x = "";
            //int variable numCourse - evaluate if the number 
            int numCourse;
            Console.WriteLine("Please enter the number of courses: ");
            //use string to hold number of courses
            x = Console.ReadLine();
            //implement a check to determine if the number of courses is a valid entry
            while (!int.TryParse(x, out numCourse) || (numCourse < 1))
            {
                Console.Write("\nYou entered an invalid entry. You have to enter information for at least 1 course. Please try again: ");
                x = Console.ReadLine();
                //if statement - convert to number
                if (int.TryParse(x, out numCourse))
                {
                    numCourse = int.Parse(x);
                }
            }
            /************************************************
            Arrays - Depend on Number of Courses (User Input)
           **************************************************/
            //course array - array of arrays
            Course[] courses = new Course[numCourse];
            ////array containing all course names
            string[] names = new string[numCourse];
            ////array containing current enrollment for courses
            int[] currentEnrollment = new int[numCourse];
            ////array containing the maximum enrollment for the courses
            int[] maxEnrollment = new int[numCourse];
            ////array containing the number of leftover seats in the course
            //int[] leftSeats = new int[numCourse];
            //string for course name
            string nameIn;
            //string to check if current enrollment is a numbner
            string checkEnrollment;
            //integer for current enrollment
            int enrollmentIn;
            //string to check if maximum enrollment is valid
            string checkMax;
            //integer for maximum enrollment
            int maxIn;
            //use for loop to process user input and establish course name, currentenrollment, maximum enrollment, and number of seats left - needs to be based on the number 
            for (int i = 0; i < numCourse; i++)
            {
                //ask user for the name of the course
                Console.WriteLine("\nPlease enter the name for course number {0}: ", i + 1);
                nameIn = Console.ReadLine();
                //assign nameIn to the array index i
                names[i] = nameIn;

                //spacing here for the next values - number of enrollees
                Console.WriteLine("\nPlease enter the number of currently enrolled students for course {0}: ", i + 1);
                checkEnrollment = Console.ReadLine();
                //implement a check to determine if the maximum number of enrollees is sensible
                while (!int.TryParse(checkEnrollment, out enrollmentIn) || (enrollmentIn < 0))
                {
                    Console.Write("\nYou entered an invalid entry. You can't have less than 0 enrolled students or a non-numeric value. Please try again: ");
                    checkEnrollment = Console.ReadLine();
                    //if statement - convert to number
                    if (int.TryParse(checkEnrollment, out enrollmentIn))
                    {
                        enrollmentIn = int.Parse(checkEnrollment);
                        //then write to arrray
                    }
                }
                currentEnrollment[i] = enrollmentIn;
                //spacing here for the next values - maximum enrollment
                Console.WriteLine("\nPlease enter the maximum number of seats allowed for course {0}: ", i + 1);
                checkMax = Console.ReadLine();
                //implement a check to determine if the maximum number of enrollees is sensible
                while (!int.TryParse(checkMax, out maxIn) || (maxIn < 1))
                {
                    Console.Write("\nYou entered an invalid entry. You have to enter a maximum course enrollment of at least 1; you also can't have a non-numeric value for the course capacity. Please try again: ");
                    checkMax = Console.ReadLine();
                    //if statement - convert to number
                    if (int.TryParse(checkMax, out maxIn))
                    {
                        maxIn = int.Parse(checkMax);
                        //then write to arrray
                    }
                }
                maxEnrollment[i] = maxIn;

                courses[i] = new Course(names[i], currentEnrollment[i], maxEnrollment[i]);
                courses[i].SeatsLeft();

                ////new array - contains course objects

            }
            //newline for spacing
            Console.WriteLine("\n");
            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine("Course entry number {0}", (i + 1));
                Console.WriteLine(courses[i].ToString());
            }
            //wait for user to exit
            Console.WriteLine("Press any key to exit program...");
            Console.ReadKey();

        }

    }
}
