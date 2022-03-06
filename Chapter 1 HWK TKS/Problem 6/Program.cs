/***********************************************************************************
 * Programmer: Twymun Safford
 * Date: 01/16/22
 * Purpose: "Application for Phrases" - short program that displays three different outputs
 * using the same phrase (select for the phrase)
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #1, Programming Exercise #6
**********************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
//Define namespace for the exercises
namespace Problem6TKSCIPT180
{
    /**************************************
   Define class Program
   **************************************/
    class phraseProgram
    {
        //the default phrase needs to be "Laugh often, Dream big, reach for the stars!".
        static void Main(string[] args)
        {
            //Set the background for the console to white
            Console.BackgroundColor = ConsoleColor.White;
            //Set the foreground color to black
            Console.ForegroundColor = ConsoleColor.Black;
            //Display the first output format - with all three parts of the phrase on the same line
            Console.Write("First output: \n");
            Console.Write("Laugh often, " + "Dream big, Reach for" + " the stars!\n\n");
            //For second output, print phrase on three separate lines
            Console.Write("Second output: \n");
            Console.Write("Laugh often,\n");
            Console.Write("Dream big,\n");
            Console.Write("Reach for the"+"stars!\n\n");
            //For the third output, display each word of the phrase on its own line
            Console.Write("Third output: \n");
            Console.Write("Laugh\n");
            Console.Write("Often,\n");
            Console.Write("Dream\n");
            Console.Write("big\n");
            Console.Write("Reach\n");
            Console.Write("For\n");
            Console.Write("the\n");
            Console.Write("stars!\n");
            //HOLD THE OUTPUT ON SCREEN (not sure if necessary)
            Console.Read();
            //tell user to press enter
            Console.Write("Press enter to close this window.");
        }
    }
}