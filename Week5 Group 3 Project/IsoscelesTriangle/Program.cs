/***************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley, Justin Tanner 
 * Date: 02/08/22 
 * Purpose: "Isosceles Triangle" - program that prints an isosceles triangle to screen
 * based on user input symbol. Size of triangle should be no more than 10 - defaults to three
 * otherwise.
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #6, Programming Exercise #9 (Week 5 Group Project) 
**************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//include all needed libraries
using System;


/**************************************
Namespace Isoceles Triangle
**************************************/
namespace IsoscelesTriangle
{
    class Program
    {
        /**************************************
        Main Method
        **************************************/
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
            Console.WriteLine("*                   'Isosceles Triangle                              *");
            Console.WriteLine("*                      By: Group 3                                   *");
            Console.WriteLine("*  This program creates an isosceles triangle based on the size      *");
            Console.WriteLine("*  of the triangle combined with the character specified by the      *");
            Console.WriteLine("*  user. The maximum size of the triangle needs to be 10 while       *");
            Console.WriteLine("*  the minimum size of the triangle needs to be three.               *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");

            //variable to assess if user wants to print another triangle - by default, it is yes until user specifies otherwise
            Boolean anotherTriangle = true;
            while (anotherTriangle == true)
            {
                //character value to assess if user wants to play again - defaults to 'Y' for yes
                char runAgain = 'Y';

                //The size of the triangle should not be larger than 10. for now, variable starts at 0 to give it a value
                int size = 0;
                Console.Write("\nEnter the size of the triangle (3-10 numeric please): ");

                //implement a check to assess if the user has entered an invalid entry
                if (!int.TryParse(Console.ReadLine(), out size) || size > 10 || size < 3)
                {
                    Console.Write("\nYou entered an invalid number for size. The size of the triangle will default to 3.");
                    size = 3;
                }

                //have user enter the character to build the triangle
                Console.Write("\nEnter the character of the triangle: ");
                string character = Console.ReadLine();

                //implement a check on the user symbol - if character not entered, default to asterisk
                if (character.Length > 1 || Char.IsDigit(character[0]))
                {
                    character = "*";
                }

                //for loop - inner loop writes the character, outer loop is counter until max size is reached (this only prints the upper half of the triangle)
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(character);
                    }
                    Console.WriteLine();
                }

                //this section prints the lower half of the triangle
                for (int i = size - 1; i >= 1; i--)
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write(character);
                    }
                    Console.WriteLine();
                }

                //ask the user if they would like to print another triangle
                Console.WriteLine("\nWould you like to print another triangle? Select (Y) for 'Yes, otherwise enter another key to quit: ");

                //prompt user for character
                runAgain = char.Parse(Console.ReadLine());

                //capitalize the letter to 'Y'
                runAgain = char.ToUpper(runAgain);

                //run a check to see if the value is 'Y' for true or other for false
                if (runAgain == 'Y')
                {
                    //evaluate to true
                    anotherTriangle = true;
                }
                //otherwise, evaluate to false
                else
                {
                    anotherTriangle = false;
                }

            }
        }
    }
}
