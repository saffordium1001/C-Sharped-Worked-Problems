/***************************************************************************************************
 * Name: Twymun Safford
 * Date: 02/07/22 
 * Purpose: "Human Perception - Dew Point" - program that determines how a person feels based on
 * dewpoint and temperature
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Exam #1
**************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;

namespace TKSCITP180Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            //user temperature
            double userTemperature;
            userTemperature = GetUserInput();
            //print results
            UserFeels(userTemperature);
        }

       /**************************************
       Method - User Input for Temperature
       **************************************/
        // Method that gets number of cases sold from user
        public static double GetUserInput()
        {
            //temperature
            string temp;
            double temperature;
            char tempScale;
            //check if number
            bool isNumber;
            Console.WriteLine("Enter the temperature outside: ");
            temp = Console.ReadLine();
            isNumber = double.TryParse(temp, out temperature);
            //check if user entry is numeric or non-numeric
            if(isNumber == true)
            {
                //convert to double
                temperature = Convert.ToDouble(temp);
            }
            else
            {
                //default to 20
                temperature = 20.0;
            }
            //have user enter the character for Fahrenheit or Celsius
            Console.WriteLine("Enter the temperature scale (F or C): ");
            tempScale = Char.Parse(Console.ReadLine());
            //check if entered character is correct
            if (tempScale != 'C' && tempScale != 'F')
            {
                //default to using Fahrenheit for the scale
                tempScale = 'F';
            }
            //check if user entered fahrenheit or celsius
            if (tempScale =='F')
            {
                return temperature;
            }
            //if in celsius
            else
            {
                //call to function
                return (ConvertFahrenheit(temperature));
            }
        }

        /**************************************
       Method - Calculate Fahrenheit
       **************************************/
        public static double ConvertFahrenheit(double userTemp)
        {
            //converts the tempeature to fahrenheit
            double convertTemp;
            //calculations - done only if temperature in Celsius
            convertTemp = userTemp * 1.8 + 32.0;
            return convertTemp;
        }

        /**************************************
       Method - User Feeling
       **************************************/
        public static void UserFeels(double temp)
        {
            //check what the temperature is and print message for each appropriate temperature
            if (temp < 49.0)
            {
                Console.WriteLine("At {0:0.00} F, it feels a bit dry...", temp);
            }
            else if (50.0 <= temp && temp <= 54.0)
            {
                Console.WriteLine("At {0:0.00} F, it feels very comfortable.", temp);
            }
            else if (55.0 <= temp && temp <= 59.0)
            {
                Console.WriteLine("At {0:0.00} F, it feels very comfortable.", temp);
            }
            else if (60.0 <= temp && temp <= 64.0)
            {
                Console.WriteLine("At {0:0.00} F, it feels OK.", temp);
            }
            else if (65.0 <= temp && temp <= 69.0)
            {
                Console.WriteLine("At {0:0.00} F, it feels somewhat uncomfortable.", temp);
            }
            else if (70.0 <= temp && temp <= 74.0)
            {
                Console.WriteLine("At {0:0.00} F, if feels very humid.", temp);
            }
            else 
            {
                Console.WriteLine("At {0:0.00} F, it feels extremely uncomfortable!", temp);
            }
        }


    }
}
