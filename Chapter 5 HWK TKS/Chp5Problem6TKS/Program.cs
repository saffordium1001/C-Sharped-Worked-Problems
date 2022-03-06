/***********************************************************************************
 * Programmer: Twymun Safford
 * Date: 02/05/22
 * Purpose: "(Surface) Area Calculator" - Program that calculates the area/surface
 * area of various shapes as specified by a user
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #5, Programming Exercise #6
**********************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;

namespace Chp5Problem6TKS
{
    /**************************************
    Define class Program
    **************************************/
    class Program
    {
        /**************************************
       Method - Get Dimensions of Circle
       **************************************/
        public static double CircleInput()
        {
            //double to check if valid entry
            string rad;
            //check if the string entered passed
            bool checkNumber;
            //variable for radius
            double r;
            //prompt user for radius of circle
            Console.WriteLine("\nPlease enter radius of the circle : ");
            //check if the user entry is
            rad = Console.ReadLine();
            checkNumber = double.TryParse(rad, out r);
            //check if valid entry for radius
            while (checkNumber == false || r <= 0)
            {
                //prompt user for radius of circle
                Console.WriteLine("\nPlease enter a valid entry for the radius of the circle : ");
                //have user enter it again 
                rad = Console.ReadLine();
                checkNumber = double.TryParse(rad, out r);
                //convert to number
                r = Convert.ToDouble(rad);
            }
            //pass to method to calculate area of circle
            return CircleArea(r);
        }

        /**************************************
        Method - Calculate Area of Circle
        **************************************/
        public static double CircleArea(double r)
        {
            //area of a circle is pi * radius squared
            return Math.PI * Math.Pow(r, 2);
        }


        /**************************************
        Method - Get Dimensions of a Rectangle
        **************************************/
        public static double RectangleInput()
        {
            //strings for length and width
            string sideA, sideB;
            //check if the string entered passed
            bool checkNumber;
            //length
            double l;
            //width
            double w;
            //prompt user for the dimensions of the rectangle (length and width)
            Console.WriteLine("\nEnter length of the Rectangle : ");
            sideA = Console.ReadLine();
            //check if length is a valid number
            checkNumber = double.TryParse(sideA, out l);
            //while loop to get corect value
            while (checkNumber == false || l <= 0)
            {
                //have user enter it again 
                Console.WriteLine("\nPlease enter a valid number for the length of the rectangle: ");
                sideA = Console.ReadLine();
                checkNumber = double.TryParse(sideA, out l);
                l = Convert.ToDouble(sideA);
            }
            Console.WriteLine("\nEnter width of the Rectangle : ");
            sideB = Console.ReadLine();
            //check if width is a number
            checkNumber = double.TryParse(sideB, out w);
            //while loop to get correct value
            while (checkNumber == false || w <= 0)
            {
                //have user enter it again 
                Console.WriteLine("\nPlease enter a valid number for the width of the rectangle: ");
                sideB = Console.ReadLine();
                checkNumber = double.TryParse(sideB, out w);
                w = Convert.ToDouble(sideB);
            }
            //pass to method to calculate area of rectangle
            return RectangleArea(l, w);
        }

        /**************************************
       Method - Calculate Area of Rectangle
       **************************************/
        public static double RectangleArea(double l, double w)
        {
            //area of a rectangle is the length times the width
            return l * w;
        }

        /**************************************
      Method - Get Dimensions of Cylinder
      **************************************/
        public static double CylinderInput()
        {
            //strings to hold radius and height
            string radius, height;
            //check if the string entered passed
            bool checkNumber;
            //radius variable
            double r;
            //height variable
            double h;
            //prompt user to enter radius and height of cylinder
            Console.WriteLine("\nEnter radius of the cylinder : ");
            radius = Console.ReadLine();
            //check if length is a valid number
            checkNumber = double.TryParse(radius, out r);
            //while loop to get corect value
            while (checkNumber == false || r <= 0)
            {
                //have user enter it again 
                Console.WriteLine("\nPlease enter a valid number for the radius of the cylinder: ");
                radius = Console.ReadLine();
                checkNumber = double.TryParse(radius, out r);
                r = Convert.ToDouble(radius);
            }
            Console.WriteLine("\nEnter the height of the cylinder: ");
            height = Console.ReadLine();
            //check if width is a number
            checkNumber = double.TryParse(height, out h);
            //while loop to get correct value
            while (checkNumber == false || h <= 0)
            {
                //have user enter it again 
                Console.WriteLine("\nPlease enter a valid number for the height of the cylinder: ");
                height = Console.ReadLine();
                checkNumber = double.TryParse(height, out h);
                h = Convert.ToDouble(height);
            }
            //pass to method to calculate area of cylinder
            return CylinderArea(r, h);
        }

        /**************************************
      Method - Calculate Surface Area of Cylinder
      ******************************************/
        public static double CylinderArea(double r, double h)
        {
            //surface area of a cylinder is area of outside length plus
            //area of top and bottom
            return (2 * Math.PI * r * h) + (2 * Math.PI * Math.Pow(r, 2));
        }


        /**************************************
        Main Method
        **************************************/
        static void Main(string[] args)
        {
            /**************************************
           Program Welcome/Description
           **************************************/
            //introduce user to the program
            Console.WriteLine("**********************************************************************");
            //use a new line to separate the border line above from the program name below
            Console.WriteLine("*                                                                    *");
            //describe what the program does 
            Console.WriteLine("*                       'Area Calculator'                            *");
            Console.WriteLine("*                      By: Twymun Safford                            *");
            Console.WriteLine("*  This program calculates the area of a circle, rectangle, or       *");
            Console.WriteLine("*  cylinder based upon the user's selection.                         *");
            Console.WriteLine("*                                                                    *");
            //finish here by enclosing the initials inside another border 
            Console.WriteLine("**********************************************************************");

            //shape option - set at -1 until user selects otherwise
            int shapeChoice = -1;
            //double to hold area of shape - set to zero until selected
            double area;

            //ask user which shape they wish to calculate area for
            /**************************************
            Display Menu for Shapes to Pick
            **************************************/
            Console.WriteLine("\n\n");
            Console.WriteLine("************************************************");
            Console.WriteLine("* Please choose one of the following shapes to *");
            Console.WriteLine("* calculate an area for, or input (4) to exit: *");
            Console.WriteLine("*                                              *");
            Console.WriteLine("* (1) Circle                                   *");
            Console.WriteLine("* (2) Rectangle                                *");
            Console.WriteLine("* (3) Cylinder                                 *");
            Console.WriteLine("* (4) Exit                                     *");
            Console.WriteLine("*                                              *");
            Console.WriteLine("************************************************");

            //get user's choice
            shapeChoice = int.Parse(Console.ReadLine());
            //use switch case statement to assess the user's choice
            switch (shapeChoice)
            {
                /**************************************
                Calculate Area of Circle
                **************************************/
                case 1:
                    area = CircleInput();
                    //print to screen what the area of the rectangle
                    Console.WriteLine("\nThe area of the circle is {0:0.00}.", area);
                    break;
                /**************************************
                Calculate Area of Circle
                **************************************/
                case 2:
                    area = RectangleInput();
                    Console.WriteLine("\nThe area of the rectangle is {0:0.00}.", area);
                    break;
                /**************************************
                Calculate Area of Circle
                **************************************/
                case 3:
                    area = CylinderInput();
                    Console.WriteLine("\nThe area of the cylinder is {0:0.00}.", area);
                    break;
                /**************************************
                Exit the Program
                **************************************/
                case 4:
                    Console.WriteLine("\nExiting the program. Goodbye!");
                    //return - program needs to end
                    return;
                /**************************************
                Default Case - Invalid Selection
                **************************************/
                default:
                    Console.WriteLine("\nYou made an invalid selection. This program will close now. Goodbye!");
                    //return - program needs to end in the case of the default case
                    return;
            }
        }
    }
}
