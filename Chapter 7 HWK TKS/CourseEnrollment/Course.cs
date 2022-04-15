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
 * COURSE CLASS
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
/**************************************
Course Class
**************************************/
    internal class Course
    {
        /**************************************
        Variables
        **************************************/
        //name of the course(s)
        private string name;
        //current enrollment in the courses
        private int enrollment;
        //maximum enrollment permitted for the course
        private int maxEnrollment;

        /*************************************
        Default Constructor 
       **************************************/
        public Course()
        {
            //default constructor
        }

        /****************************************************
        Parameterized Constructor - Access All Course Aspects
       *****************************************************/
        public Course(string name, int enrollment, int maxEnrollment)
        {
            NameCourse = name;
            CurrentEnrollment = enrollment;
            MaxEnroll = maxEnrollment;
        }

        /*************************************
       Course Name
      **************************************/
        public string NameCourse
        {
            get { return name; }
            set { name = value; }
        }

        /*************************************
       Number of Course Enrollments
      **************************************/
        public int CurrentEnrollment
        {
            get { return enrollment; }
            set { enrollment = value; }
        }

        /*************************************
       Course Maximum Enrollment Size
      **************************************/
        public int MaxEnroll
        {
            get { return maxEnrollment; }
            set { maxEnrollment = value; }
        }

        /*************************************
        Determine Number of Seats Left in Course
        **************************************/
        //instance method
        public int SeatsLeft()
        {
            //use checks to determine how many seats are left
            if(maxEnrollment > enrollment)
            {
                return maxEnrollment - enrollment;
            }
            //otherwise, if attempted enrollment is equal to or greater than maximum enrollment, set to zero
            else
            {
                return 0;
            }
        }


        /**************************************
       ToString Method()
       **************************************/
        public override string ToString()
        {
            return "+----------------------------------------------------------------------------------+" +
                    $"\n{"Class Name",15} {"Current Enrollment",20} {"Maximum Enrollment",25} {"Available",15}" +
                    $"\n{NameCourse,11} {CurrentEnrollment,15} {MaxEnroll,26} {SeatsLeft().ToString(),19}" +
                    "\n+----------------------------------------------------------------------------------+" +
                    "\n";
        }
    }
}