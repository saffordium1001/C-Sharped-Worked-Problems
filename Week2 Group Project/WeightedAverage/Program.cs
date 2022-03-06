/***********************************************************************************
 * Group: Group 3
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley, Justin Tanner
 * Date: 01/26/22
 * Purpose: "Weighted Average" - program that calculates the weighted average of a
 * student's grades based upon scores from exams, quizzes, and other assignments
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #2, Programming Exercise #8 (Week 2 Group Project) 
**********************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
/**************************************
Define class Program
**************************************/
namespace WeightedAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            /**************************************
            Constant values for assignment weights
            **************************************/
            const int HOMEWORK_WEIGHT_PERCENT = 10;
            const int PROJECTS_WEIGHT_PERCENT = 35;
            const int QUIZZES_WEIGHT_PERCENT = 10;
            const int EXAMS_WEIGHT_PERCENT = 30;
            const int FINAL_EXAM_WEIGHT_PERCENT = 15;

            /**************************************
            Program Welcome/Description
            **************************************/
            //introduce user to the program
            Console.WriteLine("**********************************************************************");
            //use a new line to separate the border line above from the program name below
            Console.WriteLine("*                                                                    *");
            //describe what the program does 
            Console.WriteLine("*                    'Weighted Average'                              *");
            Console.WriteLine("*                       By: Group 3                                  *");
            Console.WriteLine("*  This program calculates the weighted average of a student         *");
            Console.WriteLine("*  based upon their homework, project, quiz, and exam scores.        *");
            Console.WriteLine("*                                                                    *");
            //finish here by enclosing the initials inside another border 
            Console.WriteLine("**********************************************************************");

            /**************************************
            Variables declared here
            **************************************/
            // Declare the variables to store the values.
            int homework = 97;
            int projects = 82;
            int quizzes = 60;
            int exams = 75;
            int finalExam = 80;

            // other values
            /*
            int homework=78; 
            int projects=68; 
            int quizzes=83; 
            int exams= 91; 
            int finalExam=74;
            */

            // Calculate the total by multiplying the weight of each assignment score times the user's score
            double weightTotal = (HOMEWORK_WEIGHT_PERCENT * homework) +
                (PROJECTS_WEIGHT_PERCENT * projects) +
                (QUIZZES_WEIGHT_PERCENT * quizzes) +
                (EXAMS_WEIGHT_PERCENT * exams) +
                (FINAL_EXAM_WEIGHT_PERCENT * finalExam);

            // Calculate the average by dividing the user's total by the total weight 
            double weightedAverage = weightTotal / (HOMEWORK_WEIGHT_PERCENT + PROJECTS_WEIGHT_PERCENT +
                QUIZZES_WEIGHT_PERCENT + EXAMS_WEIGHT_PERCENT + FINAL_EXAM_WEIGHT_PERCENT);

            // Display the values and weights 
            Console.WriteLine("Homework value:\t{0}\tHomework Weight: {1}%", homework, HOMEWORK_WEIGHT_PERCENT);
            Console.WriteLine("Projects value:\t{0}\tProjects Weight: {1}%", projects, PROJECTS_WEIGHT_PERCENT);
            Console.WriteLine("Quizzes value:\t{0}\tQuizzes Weight:\t{1}%", quizzes, QUIZZES_WEIGHT_PERCENT);
            Console.WriteLine("Exams value:\t{0}\tExams Weight:\t{1}%", exams, EXAMS_WEIGHT_PERCENT);
            Console.WriteLine("FinalExam value: {0}\tFinal Exam Weight: {1}%", finalExam, FINAL_EXAM_WEIGHT_PERCENT);

            // Display the weighted average.
            Console.WriteLine("\nWeighted Average: {0:00.00}%", weightedAverage);

            Console.ReadLine();
        }
    }
}
