/***********************************************************************************************
 * Name: Twymun Safford
 * Date: 04/05/2022 
 * 
 * Purpose: Write an application that creates a two-dimensional array. Allow the user
 * to input the size of the array (number of rows and number of columns).
 * Fill the array with random numbers between 0 and 100. Search the array
 * for the largest value. Display the array values, numbers aligned, and the
 * indexes where the largest value is stored.
 * 
 * PROGRAM CLASS
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #7, Programming Exercise #10
***********************************************************************************************/
/**************************************
Import System Namespace
**************************************/
//import system namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Ch8Problm6TKS
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
            Console.WriteLine("*                 'Random Array Generator'                           *");
            Console.WriteLine("*                    By: Twymun Safford                              *");
            Console.WriteLine("*  This program creates a two-dimensional array with n rows and m    *");
            Console.WriteLine("*  columns as specifed by the user. Once that is done, each array    *");
            Console.WriteLine("*  element is assigned a random value between 0 to 100. This         *");
            Console.WriteLine("*  program can even locate the maximum array value!                  *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");
            /**************************************
            Variable Declaration
            **************************************/
            //values for the max. rows, max. columns
            int row, column;
            //for the array
            int[,] twoDimensionalArray;
            //used to generate the 100 random numbers
            //Random rnd = new Random();

            /**************************************
            Use Methods to Get User Input
            **************************************/
            row = GetRows();
            column = GetColumns();
            twoDimensionalArray = new int[row, column];
            /**************************************
            Create New Object
            **************************************/
            RandomArray newArray = new RandomArray(row, column, twoDimensionalArray);
            /**************************************
            Inform User of Results and Display Matrix
            **************************************/
            //fill the array
            newArray.FillArray(twoDimensionalArray);
            //show matrix
            newArray.DisplayTable(twoDimensionalArray);
            Console.ReadKey();
            //show the largest value
            newArray.ShowLargestValue(twoDimensionalArray);
            Console.ReadKey();
        }
        /**************************************
        Method - Get Number of Rows from User
        **************************************/
        public static int GetRows()
        {
            string rows;
            int rowSize;
            Console.WriteLine("\nPlease enter the number of rows for this 2D array (integer only):");
            rows = Console.ReadLine();
            while (int.TryParse(rows, out rowSize) == false || rowSize == 0)
            {
                Console.WriteLine("Invalid data entered! Please enter an integer 1 or greater: ");
                rows = Console.ReadLine();
            }
            //otherwise write to rows
            rowSize = int.Parse(rows);
            return rowSize;
        }

        /**************************************
        Method - Get Number of Columns from User
        **************************************/
        public static int GetColumns()
        {
            string columns;
            int columnSize;
            Console.WriteLine("\nNow, please enter the number of rows for this 2D array (integer only):");
            columns = Console.ReadLine();
            while (int.TryParse(columns, out columnSize) == false || columnSize == 0)
            {
                Console.WriteLine("Invalid data entered! Please enter an integer 1 or greater: ");
                columns = Console.ReadLine();
            }
            //otherwise, write to columns

            columnSize = int.Parse(columns);
            return columnSize;
        }
    }
}
