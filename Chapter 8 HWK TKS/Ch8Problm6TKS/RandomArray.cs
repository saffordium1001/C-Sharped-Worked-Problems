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
 * ARRAY CLASS
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
    class RandomArray
    {
        /**************************************
        Private Variables
        **************************************/
        //maximum number of rows
        private int numRows;
        //maximum number of columns
        private int numColumns;
        ////largest index value
        //private int largestIndexValue;
        //new matrix value needs to go here
        private int[,] matrixRandom;


        /**************************************
        Default Constructor
        **************************************/
        public RandomArray()
        {
            //default constructor
        }

        /**************************************
        Parameterized Constructor
        **************************************/
        //public RandomArray(int rows, int columns, int largeIndex, int[,] matrix)
        public RandomArray(int rows, int columns, int[,] matrix)
        {
            //default constructor
            numRows = rows;
            numColumns = columns;
            //largestIndexValue = largeIndex;
            matrixRandom = matrix;
        }

        //ACCESSORS

        /**************************************
        Properties - Number of Rows
        **************************************/
        public int NumberRows
        {
            get
            {
                return numRows;
            }
            set
            {
                numRows = value;
            }
        }

        /**************************************
        Properties - Number of Columns
        **************************************/
        public int NumberColumns
        {
            get
            {
                return numColumns;
            }
            set
            {
                numColumns = value;
            }
        }


        /**************************************
      Properties - Array (Auto Implemented)
      **************************************/
        public int[,] matrixSize
        {
            get;
            set;
        }

        /**************************************
      Method - Set Array Size Using Constructor
      **************************************/
        public void GetSize(int rows, int columns)
        {
            matrixSize = new int[rows, columns];
        }

        /**************************************
      Method - Fill Array With Random Values
      **************************************/
        public void FillArray(int[,] randomArray)
        {
            //create a new random seed
            Random fillRandom = new Random();
            //based on the number of rows user specified
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                //based on the number of columns user specified
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    //fill each index with a random value between 0 and 100
                    randomArray[i, j] = fillRandom.Next(0, 100);
                }

            }
        }

        /**************************************
        Method - Display the Array Table
        **************************************/
        public void DisplayTable(int[,] randomArray)
        {
            //can just use size of array for both of these values
            Console.WriteLine("\nYour randomly generated array with {0} rows and {1} columns is as follows: ", randomArray.GetLength(0), randomArray.GetLength(1));
            Console.WriteLine("\n\n");
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                Console.Write("\n|Row" + (i + 1) + "|:  ");
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    Console.Write(randomArray[i, j] + " ");
                }
                Console.WriteLine();

            }

        }

        /**************************************
        Method - Display Where the Largest Values Occur
        **************************************/
        public void ShowLargestValue(int[,] randomArray)
        {
            //arraylist to store the indices
            ArrayList indices = new ArrayList();
            //start here and assume that the first index is the "largest" value
            int maximum = randomArray[0, 0];
            //start here and for the sake of variables assign maximum (for now)
            //to values outside of the range of random numbers
            int maximumRow = 0;
            int maximumColumn = 0;
            //use a loop to check for, retrieve largest value - for loop will check
            //until it finds the largest value (not the most efficient method - need
            //improve using a better search option
            for (int i = 0; i < randomArray.GetLength(0); i++)
            {
                for (int j = 0; j < randomArray.GetLength(1); j++)
                {
                    //if the next value is greater than the current maximum, clear the list
                    if (randomArray[i, j] > maximum)
                    {
                        maximum = randomArray[i, j];
                        //clear the count of indices
                        indices.Clear();
                    }
                    //otherwise, if an element is equal to the current greatest, then add that indices to the array
                    if(randomArray[i,j] == maximum)
                    {
                        string location = (i+1) + "," + (j+1);
                        indices.Add(location);
                    }
                }
            }
            //once satisfied, write where the largest value is and where it occurs
            Console.WriteLine("\nIn your array, your largest value is " + maximum + "! This occurs at indices: ");
            for(int i=0; i < indices.Count; i++)
            {
                Console.WriteLine("["+indices[i]+"], ");
                //increment i by one 
                i++;
            }

        }
    }
}
