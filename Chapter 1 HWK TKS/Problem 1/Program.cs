/***********************************************************************************
 * Programmer: Twymun Safford
 * Date: 01/16/22
 * Purpose: "Hello World" - short program that displays traditional 'Hello World'
 * message along with the user's name
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #1, Programming Exercise #1
**********************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
//Define namespace for the exercises
namespace Problem1TKSCIPT180
{
 /**************************************
Define class Program
**************************************/
    class Program
    {
        //define the main method
        static void Main(string[] args)
        {
            //set the console background to a color of white
            Console.BackgroundColor = ConsoleColor.White;
            //set the foreground of the console to black
            Console.ForegroundColor = ConsoleColor.Black;
            //Display string consisting of 'Hellow World' and my name
            Console.WriteLine("Hello World! My name " + "is Twymun Safford!");
            //For additional challenge, display the message in Spanish
            Console.WriteLine("In Spanish, this message is: ");
            //display message in Spanish
            Console.WriteLine("Hola Mundo! Mi nombre " + "es Twymun Safford!");
            //hold message on console
            Console.Read();
            //tell user to press enter
            Console.WriteLine("Press enter to close this window.");
        }
    }
}
