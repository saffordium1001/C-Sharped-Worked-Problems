/***************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley, Justin Tanner 
 * Date: 02/08/22 
 * 
 * Purpose: Create a Motorway class that can be used as extra documentation with 
 * directions. Include data members such as name of the highway, type 
 * of street (i.e., Road, Street, Avenue, Blvd., Lane, etc.), direction (i.e., E, 
 * W, N, or S), surface (i.e., blacktop, gravel, sand, and concrete), number 
 * of lanes, toll or no toll, and the party that maintains it. Write instance 
 * methods that return the full name of the motorway, full name of the 
 * motorway and whether it is toll or not, and full name of the motorway and the number of lanes. 
 * Also include a ToString( ) method that 
 * returns all data members with appropriate labels. Include enough constructors to make the class flexible, 
 * and experiment with using the class 
 * diagram to create the property members. In a second class tests the 
 * constructors, instance methods, and properties defined in the Motorway class.
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #4, Programming Exercise #3 (Week 4 Group Project) 
**************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;

namespace MotorwayClass
{
    /**************************************
   Class Definition - Motorway Class
   **************************************/
    public class Motorway
    {
        /**************************************
        Instance Variables
       **************************************/
        //name of motorway
        private string name;
        //motorway type
        private string streetType;
        //direction (n,w,s,or e)
        private char direction;
        //surface
        private string surface;
        //number of lanes
        private int lanes;
        //does the motorway have tolls?
        private bool toll;
        //who maintains it?
        private string maintainenceParty;

        /**************************************
        Default Constructor
       **************************************/
        public Motorway()
        {
            //initialize to empty / null / zero until user input received
            name = "";
            streetType = "";
            direction = '\0';
            surface = "";
            lanes = 1; //roadway needs at least one lane
            toll = false;
            maintainenceParty = "";

        }

        /**************************************
        Property Accessors - Auto-Implemented
       **************************************/
        public string Name { get; set; }
        public string MotorwayType { get; set; }
        public char Direction { get; set; }
        public string SurfaceType { get; set; }
        public int NumberOfLanes { get; set; }
        public bool Toll { get; set; }
        public string MaintenanceAgency { get; set; }

        /***********************************************
        Parameterized Constructor - Access All Variables
       *************************************************/
        public Motorway(string name, string streetType, char direction, string surface, int numberLanes, bool toll, string maintenanceAgency)
        {
            //name
            Name = name;
            //motorway type
            MotorwayType = streetType;
            //direction
            Direction = direction;
            //surface type
            SurfaceType = surface;
            //number of lanes
            NumberOfLanes = numberLanes;
            //boolean - does it have tolls
            Toll = toll;
            //who maintains it
            MaintenanceAgency = maintenanceAgency;
        }

        /**************************************
        Constructors Written Here for 
        Flexibility/Functionality
         * 
         * Purpose: Object classes could be created
         * for the following based on only name,
         * name, toll, name/number of lanes, etc.
         *
       **************************************/
        //motorway constructor - name
        public Motorway(string name)
        {
            Name = name;
        }
        //motorway construcotr for name and boolean tolls
        public Motorway(string name, bool toll)
        {
            Name = name;
            Toll = toll;
        }
        //motorway constructor - name and number of lanes
        public Motorway(string name, int numberLanes)
        {
            Name = name;
            NumberOfLanes = numberLanes;
        }

        //ToString method
        public override string ToString()
        {
            //Return values for parameters
            return $"Motorway Name:  {Name}\n" +
                   $"Type of Motorway:  {MotorwayType}\n" +
                   $"Direction(Cardinal):  {Direction}\n" +
                   $"Surface Type: {SurfaceType}\n" +
                   $"Number Of Lanes: {NumberOfLanes}\n" +
                   $"Toll?: {Toll}\n" +
                   $"Maintenance Agency: {MaintenanceAgency}\n";
        }
    }
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
            Console.WriteLine("*                   'Motorway Program'                               *");
            Console.WriteLine("*                      By: Group 3                                   *");
            Console.WriteLine("*  This program creates an organized list detailing the specific     *");
            Console.WriteLine("*  characterisitics of an motorway. The list is organized            *");
            Console.WriteLine("*  based on highway name, highway type, direction (cardinal - N,W,S  *");
            Console.WriteLine("*  or E), surface type, number of lanes, whether it has a toll,      *");
            Console.WriteLine("*  and the number of lanes.                                          *");
            //finish here by enclosing the program description inside another border 
            Console.WriteLine("*                                                                    *");
            Console.WriteLine("**********************************************************************");
            Console.WriteLine("\n");
            //variable to assess if user wants to enter another motorway instance
            Boolean anotherTime = true;
            while (anotherTime == true)
            {
                //character value to assess if user wants to play again - defaults to 'Y' for yes
                char runAgain = 'Y';
                //name of motorway - user entry
                string nameMotorway;
                //type of streetMotorwayType
                string streetMotorwayType;
                //character for direction
                char motorwayDirection;
                //string to hold surface type
                string surfaceType;
                //string to check number of lanes
                string numLanes;
                //number of lanes
                int totalLanes;
                //char - are there tolls
                char isTolls;
                //boolean - tolls
                bool tolls;
                //string - input maintenance team/agency
                string maintainenceTeam;
                //boolean for assessing true/false for error checking or variable format
                bool result;
                //prompt user for name of motorway
                Console.WriteLine("\nPlease enter the name of the motorway: ");
                nameMotorway = Console.ReadLine();
                //prompt user for type of Motorway
                Console.WriteLine("\nPlease enter the type of motorway: ");
                streetMotorwayType = Console.ReadLine();
                Console.WriteLine("\nPlease enter whether the motorway's direction is (N)orth, (W)est, (S)outh, or (E)ast.");
                Console.WriteLine(" Only enter the first character of the direction and press enter: ");
                motorwayDirection = Char.Parse(Console.ReadLine());
                //check if the user enter a character and if they entered a correct character
                result = Char.IsLetter(motorwayDirection);
                //check if result is invalid and prompt user for input again
                while (result == false)
                {
                    //prompt user again for input
                    Console.WriteLine("\nInvalid entry. Please only enter N,W,S,or E: ");
                    motorwayDirection = Char.Parse(Console.ReadLine());
                    //check if the user enter a character and if they entered a correct character
                    result = Char.IsLetter(motorwayDirection);
                }
                //convert entry to capital letter
                motorwayDirection = Char.ToUpper(motorwayDirection);
                //check if letter entered was not N,W,S, or E and tell user to make different selection
                while ((motorwayDirection != 'N') && (motorwayDirection != 'W') && (motorwayDirection != 'S') && (motorwayDirection != 'E'))
                {
                    Console.WriteLine("\nInvalid entry. Only N,W,S,or E are accepted for entries. Enter another choice: ");
                    motorwayDirection = Char.Parse(Console.ReadLine());
                    //check if the user enter a character and if they entered a correct character
                    motorwayDirection = Char.ToUpper(motorwayDirection);
                }
                //prompt user for surface type
                Console.WriteLine("\nPlease enter the surface type of the motorway: ");
                surfaceType = Console.ReadLine();
                //prompt user for number of lanes
                Console.WriteLine("\nPlease enter the number of lanes for the motorway: ");
                numLanes = Console.ReadLine();
                //check if user entry valid
                //implement a check to assess if the user has entered an invalid entry
                while (!int.TryParse(numLanes, out totalLanes) || (totalLanes < 1))
                {
                    Console.Write("\nYou entered an invalid entry. The number of lanes has to be an integer and has to be greater than zero. Please enter the number of lanes: ");
                    numLanes = Console.ReadLine();
                    //if statement - convert to number
                    if (int.TryParse(numLanes, out totalLanes))
                    {
                        totalLanes = int.Parse(numLanes);
                    }
                }
                //prompt user if there are tolls
                Console.WriteLine("\nAre there any tolls on the motorway? Enter Y for Yes or N for No: ");
                isTolls = Char.Parse(Console.ReadLine());
                //check if the user enter a character and if they entered a correct character
                result = Char.IsLetter(isTolls);
                //check if result is invalid and prompt user for input again
                while (result == false)
                {
                    //prompt user again for input
                    Console.WriteLine("\nInvalid entry. Please only enter Y for Yes or N for No: ");
                    isTolls = Char.Parse(Console.ReadLine());
                    //check if the user enter a character and if they entered a correct character
                    result = Char.IsLetter(isTolls);
                }
                //convert entry to capital letter
                isTolls = Char.ToUpper(isTolls);
                //if statements - convert to true if yes, no if false
                if (isTolls == 'Y')
                {
                    tolls = true;
                }
                else
                {
                    tolls = false;
                }
                //ask user for who maintains the motorway
                Console.WriteLine("\nPlease enter which agency/company maintains the motorway: ");
                maintainenceTeam = Console.ReadLine();
                //Create instances here
                Console.WriteLine("\n===MotorWay 1 (Instance)===");
                Motorway way1 = new Motorway(nameMotorway, streetMotorwayType, motorwayDirection, surfaceType, totalLanes, tolls, maintainenceTeam);
                Console.WriteLine(way1.ToString + "\n");

                Console.WriteLine("\n===MotorWay 2 (Instance)===");
                Motorway way2 = new Motorway(nameMotorway);
                Console.WriteLine(way2 + "\n");

                Console.WriteLine("\n===MotorWay 3 (Instance)===");
                Motorway way3 = new Motorway(nameMotorway, tolls);
                Console.WriteLine(way3 + "\n");

                Console.WriteLine("\n===MotorWay 4 (Instance)===");
                Motorway way4 = new Motorway(nameMotorway, totalLanes);
                Console.WriteLine(way4 + "\n");


                Console.Write("\n\n");

                //ask user if they would like to enter another motorway

                Console.WriteLine("\nWould you like to enter another motorway? Select (Y) for 'Yes, otherwise enter another key to quit: ");

                //prompt user for character
                runAgain = char.Parse(Console.ReadLine());

                //capitalize the letter to 'Y'
                runAgain = char.ToUpper(runAgain);

                //run a check to see if the value is 'Y' for true or other for false
                if (runAgain == 'Y')
                {
                    //evaluate to true
                    anotherTime = true;
                }
                //otherwise, evaluate to false
                else
                {
                    anotherTime = false;
                }
            }
        }
    }
}

