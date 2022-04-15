/*************************************************************************************************************************************
 * Name: Twymun Safford
 * Date: 03/07/2022
 * Purpose: Write a program that draws rectangles in the console. The users should input a height and width of a rectangle. 
 * Create a class to represent the rectangle and set the height and width as constructor parameters. Create a void method called "draw" 
 * which uses the rectangle's height and width to draw an appropriately sized rectangle using the " - ", " | ", and " + " characters. 
 * After drawing the rectangle ask the user to enter the letter "Y" if they would like to draw another one or "N" to quit. Allow them 
 * to repeat this as many times as they like. Any value other than "Y" or "N" should also quit. Create a class to represent the rectangle 
 * and set the height and width as constructor parameters.

Create a class to represent the rectangle with a constructor that takes the height and width as parameters. The height and width should be read-only properties.
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Exam #2
*************************************************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
//for the sake of the exam, using namepspace DrawRectangle here
namespace DrawRectangle
{
    /**************************************
    Class Definition - Rectangle 
    **************************************/
    //represents the rectangle

    public class Rectangle
    {
        //member variables of rectangle need to be the height and width - only integers accepted
        //needs to be read only
        public readonly int height;
        public readonly int width;

        /**************************************
        Default Constructor for Rectangle        
        **************************************/
        public Rectangle(int h, int w)
        {
            height = h;
            width = w;
        }

        /**************************************
        Method - Draw the Rectangle 
        **************************************/
        public void DrawRectangle()
        {
            //rectangle needs to have at minimum
            //dimensions 1 for height or width

            //start by initializing i and j for height and width respectively
            int i, j;

            //display for the lines corresponding to horizontal aspect of rectangle - index needs to
            //start at zero to print symbol (+) at corners; the number of lines (rows) is equal to rectangles height
            for (i = 0; i <= (height + 1); i++)
            {
                //specify which characters need to be used
                char character = ' ';
                //write for the horizontal lines goes here
                //check first if the maximum height of rectangle has been reached - 1 min unit for height

                if (i == 0 || i == (height + 1))
                {
                    //start from leftmost index and print there
                    for (j = 0; j <= (width + 1); j++)
                    {
                        //print + symbols at corners
                        if (j == 0 || j == (width + 1))
                        {
                            character = '+';
                        }
                        //else, use dashes to represent one unit of width
                        else
                        {
                            character = '-';
                        }
                        //in either case write the result to line
                        Console.Write(character);
                    }
                }
                //case where value entered for height over minimum
                else
                {
                    for (j = 0; j <= (width + 1); j++)
                    {
                        if (j == 0 || j == (width + 1))
                        {
                            //use to represent one unit of height
                            character = '|';
                        }
                        else
                        {
                            character = ' ';
                        }
                        //in either case write the result to line
                        Console.Write(character);
                    }
                }
                //go to the next line and evaluate the writing process there
                Console.WriteLine();
            }

        }

    }
    /**************************************
    Main Class - Draws the Rectangle and Represents it
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
            Console.WriteLine("*                     'Draw the Rectangle!'                          *");
            Console.WriteLine("*                      By: Twymun Safford                            *");
            Console.WriteLine("*  This program draws a rectangle based on the height and width      *");
            Console.WriteLine("*  specified by the user. You can draw multiple rectangles           *");
            Console.WriteLine("*  this way! Just make sure to choose (Y)es for yes or               *");
            Console.WriteLine("*  (N)o/any other key for no.                                        *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");
            //variable to assess if user wants to print another rectangle - by default, it is yes until user specifies otherwise
            Boolean anotherRectangle = true;
            while (anotherRectangle == true)
            {
                //character value to assess if user wants to play again - defaults to 'Y' for yes
                char runAgain = 'Y';
                /**************************************
                Variables Here when Program Run
                **************************************/
                //assigned for rectangle but used for parsing
                string heights;
                string widths;
                //integer values will be parsed and set here once it is assessed that the values are correct
                int heightRectangle, widthRectangle;
                Console.WriteLine("Hello and welcome! Please enter the height of the rectangle you want to draw: ");
                //implement a check to assess if the user has entered an invalid entry
                heights = Console.ReadLine();
                /**************************************
                Height Check
                **************************************/
                //implement a check to assess if the user has entered an invalid entry for height
                while (!int.TryParse(heights, out heightRectangle) || (heightRectangle < 1))
                {
                    Console.Write("\nYou entered an invalid entry. The height of the rectangle needs to be at least 1 unit. Please try again: ");
                    heights = Console.ReadLine();
                    //if statement - convert to number
                    if (int.TryParse(heights, out heightRectangle))
                    {
                        heightRectangle = int.Parse(heights);
                    }
                }
                //ask for width now
                Console.WriteLine("\nGreat, thanks! Now, please enter the width of the rectangle you want to draw: ");
                widths = Console.ReadLine();
                /**************************************
                Width Check
                **************************************/
                //implement a check to assess if the user has entered an invalid entry for height
                while (!int.TryParse(widths, out widthRectangle) || (widthRectangle < 1))
                {
                    Console.Write("\nYou entered an invalid entry. The width of the rectangle needs to be at least 1 unit. Please try again: ");
                    widths = Console.ReadLine();
                    //if statement - convert to number
                    if (int.TryParse(widths, out widthRectangle))
                    {
                        widthRectangle = int.Parse(widths);
                    }
                }
                /**************************************
                Draw the Rectangle
                **************************************/
                //create new object to draw the rectangle
                Rectangle newRect = new Rectangle(heightRectangle, widthRectangle);
                //use newline to separate rectangle from rest of program
                Console.WriteLine("\n");
                //draw the rectangle
                newRect.DrawRectangle();
                /**************************************
                Prompt User to Draw Another Rectangle
                **************************************/
                //ask the user if they would like to print another rectangle
                Console.WriteLine("\nWould you like to print another rectangle? Select (Y) for Yes, (N) for No/any other key to quit: ");

                //prompt user for character
                runAgain = char.Parse(Console.ReadLine());

                //capitalize the letter to 'Y'
                runAgain = char.ToUpper(runAgain);

                //run a check to see if the value is 'Y' for true or other for false
                if (runAgain == 'Y')
                {
                    //evaluate to true
                    anotherRectangle = true;
                    Console.WriteLine("\n");
                }
                //these two statements can be redundant; commented out this middle one but left it just in case for reference

                //otherwise, evaluate to false
                //else if (runAgain == 'N')
                //{
                //    anotherRectangle = false;
                //}

                //still evaluate to false for any other character
                else
                {
                    anotherRectangle = false;
                }
            }

        }
    }
}
