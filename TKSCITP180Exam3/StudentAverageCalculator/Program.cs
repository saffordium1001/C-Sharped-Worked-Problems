/*************************************************************************************************************************************
 * Name: Twymun Safford
 * Date: 04/11/2022
 * Purpose:Write a program which calculates student grades for multiple assignments as well as the per-assignment average. The user should 
 * first input the total number of assignments. Then, the user should enter the name of a student as well as a grade for each assignment. 
 * After entering the student the user should be asked to enter "Y" if there are more students to enter or "N" if there is not 
 * ("N" by default). The user should be able to enter as many students as they like this way. Create a student class which stores the 
 * student's name as well as an array of grades.  Use an ArrayList to track all of the students. The student class should have a 
 * "CalculateAverage" method which calculates their average grade for all of their assignments. After the user is done entering all of 
 * the students output the average grade for each student. Then, output the average grade for each assignment. All averages should be 
 * rounded to the nearest tenth.
 *
 * Create a student class which stores the student's name, an array of grades, and a constructor that takes the student's name and an array of grades as parameters. The name and the grades should be read-only properties. 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Exam #3
*************************************************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
using System.Collections;

namespace StudentAverageCalculator
{
    /**************************************
    Class Definition - Student
    **************************************/
    class Student
    {
        /**************************************
        Class Member Variables
        **************************************/
        private string name;//property for names of students
        public readonly double[] grades; //double array to hold grades of students
        private ArrayList students; //arraylist object for students

        /**************************************
        Default Constructor
        **************************************/
        public Student()
        {
            //default constructor
        }

        /**************************************
        Parameterized Constructor
        **************************************/
        //public RandomArray(int rows, int columns, int largeIndex, int[,] matrix)

        /**************************************
        Default Constructor - Name and Grades
        **************************************/
        public Student(string name, double[] grades, ArrayList students)
        {
            this.name = name;
            this.grades = grades;
            this.students = new ArrayList();
        }

        //ACCESSORS

        /**************************************
        Properties - Number of Rows
        **************************************/
        public string StuName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }


        /**************************************
      Properties - Array (Auto Implemented)
      **************************************/
        public double[] Grades
        {
            get; set;
        }

        /**************************************
       Method - Calculate Average of Grades 
       **************************************/
        public double CalculateAverage()
        {
            //used to calculate the average of grades
            //on an individual basis but also the
            //class average on assignments

            //get sum of grades - initialize as zero
            double sum = 0;
            //use a for loop
            for(int i = 0; i <grades.Length; i++)
            {
                sum += grades[i]; //update sum with new assignments input
            }
            //return the average
            return sum / (double)grades.Length;
        }

        /**************************************
     Method - Add Student Name to Array List
     **************************************/
        public void AddNames(ArrayList students, object student)
        {
            //adds student's names to the array list
            students.Add(student);
        }
    }


    /**************************************
    Main Class
    **************************************/
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
            Console.WriteLine("*                   'Average Grade Calculator '                      *");
            Console.WriteLine("*                      By: Twymun Safford                            *");
            Console.WriteLine("*  This program calculates the individual and class grade averages.  *"); 
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");

            /**************************************
            Variables
            **************************************/
            string name; //name of student
            int totalNumberAssignments; //variable for the total number of assignments
            ArrayList students = new ArrayList(); //arraylist to hold student objects
            char anotherStudent = 'N'; //string to decide to add another student record
            /**************************************
            Ask for Number of Assignments
            **************************************/
            totalNumberAssignments = TotalNumAssignments();
            /**************************************
            Do-While Loop
            **************************************/
            do
            {
                /**************************************
                Ask for Student's Name
                **************************************/
                name = StudentNames();
                /**************************************
                Create Array
                **************************************/
                double[] grades = new double[totalNumberAssignments];
                //for loop - to enter the grade for each assignment
                for(int i =0; i<totalNumberAssignments; i++)
                {
                    Console.WriteLine("\nNow, please enter the student's grade for assignment number " + (i + 1) + " (doubles accepted): ");
                    grades[i] = Convert.ToDouble(Console.ReadLine()); //convert all grades to doubles
                }
                /**************************************
                Student Object Creation
                **************************************/
                Student student = new Student(name, grades, students);
                /**************************************
               Add Student Objects
               **************************************/
                student.AddNames(students, student);
                /**************************************
               Prompt User If they need to enter more students
               **************************************/
                Console.Write("\nAre there any other students you want to enter? Type 'Y' and press enter or any other key to stop entry: ");
                //prompt user for character
                anotherStudent = char.ToUpper(char.Parse(Console.ReadLine()));
            } while (anotherStudent == 'Y');

            Console.WriteLine();
            /**************************************
            Print Each Object
            **************************************/
            foreach (Student student in students)
            {
                Console.WriteLine("\nThe average grade for " + student.StuName + " is " + Math.Round(student.CalculateAverage(), 1)); //print avergae grade for every student
            }

            Console.WriteLine();
            /**************************************
            Calculate the Class Average
            **************************************/
            for(int i=0; i<totalNumberAssignments; i++)
            {
                double classSum = 0;
                foreach(Student student in students)
                {
                    //sum of all assignment grades
                    classSum += student.grades[i];
                }
                double classAverage = classSum / (double)students.Count;
                Console.WriteLine("The average grade on assignment " + (i + 1) + " is : " + Math.Round(classAverage, 1));
            }
        }

        /**************************************
      Method - Total Number of Assignments 
      **************************************/
        static int TotalNumAssignments()
        {
            int numAssignments;
            Console.WriteLine("Enter the total number of assignments: ");
            numAssignments = Convert.ToInt32(Console.ReadLine());
            return numAssignments;
        }

        /**************************************
      Method - Get Names of Students
      **************************************/
        static string StudentNames()
        {
            string name;
            Console.WriteLine("\nEnter the name of the student: ");
            name = Console.ReadLine(); //get name
            return name;
        }
    }
}
