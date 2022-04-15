/*************************************************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell
 * Date: 03/28/2022
 * 
 * Purpose: "Customer Code Application" - Write a two-class application that creates a customer code to be placed 
 * on a mailing label for a magazine. Allow the user to input their full name with the first name entered first. Prompt them to separate
 * their first and last name with a space. Ask for their birthdate in the format of mm/dd/yyyy. Ask for the month (number) they purchased 
 * a subscription and ask for their zip code. Your mailing label should contain the last name, followed by their year of birth, the number 
 * of characters in the full name, the first three characters of the month they purchased the subscription, and the last two digits of 
 * their zip. The code for Bob Clocksom born 01/22/1993, who purchased his subscription during the 10th month of the year and lists 32226 as 
 * his zip code would be Clocksom9312Oct26
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660) - Customer Class
 * Assignment: Chapter #8, Programming Exercise #4 (Week 9 Group Project) 
*****************************************************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;


namespace CustomerCode
{
    /**************************************
    Customer Class
   **************************************/
    class CustomerClass
	{
        /**************************************
        Variables
        **************************************/
        //client's full name
        private string fullName;
        //client's birth date (day, month)
        private string birthDate;
        //subscription month
        private int subscribeMonth;
        //client's first name
        private string firstName;
        //client's last name
        private string lastName;
        //client motnh of birth
        private int cMonth;
        //client month of birth as string
        private string clientMonth;
        //client day of bith
        private int cDay;
        //client year of birth
        private int cBirthYear;
        //number of characters in user's name
        private int countName;
        //client purchase month
        private string cPurchaseMonth;

        /**************************************
        Full Name Accessor
        **************************************/
        public string pFullName
        {

            //Getter
            get
            {
                //Return the customer name
                return fullName;
            }

            //Setter.
            set
            {
                //Set the customer name
                fullName = value;
            }
        }

        /**************************************
        Birthdate Accessor
        **************************************/
        public string pBirthdate
        {

            //Getter
            get
            {
                //Return the customer birth date
                return birthDate;
            }

            //Setter
            set
            {
                //Set the customer birth date
                birthDate = value;
            }
        }

        /**************************************
         Month Number
         **************************************/
        public int pMonthNumber
        {

            //Getter.
            get
            {
                //Return the customer month number
                return subscribeMonth;
            }

            //Setter.
            set
            {
                //Set the customer month number
                subscribeMonth = value;
            }
        }

        /**************************************
        Last Name (read only)
        **************************************/
        public string pLastName
        {

            //Getter.
            get
            {
                NameParser(fullName);

                //Return the customer last name
                return lastName;
            }
        }

        /**************************************
        First Name (read only)
        **************************************/
        public string pFirstName
        {

            //Getter.
            get
            {
                NameParser(fullName);

                //Return the customer last name
                return firstName;
            }
        }

        /**************************************
       Birth Month
       **************************************/
        public int pBirthMonth
        {

            //Getter.
            get
            {
                BirthdateParser(birthDate);

                //Return the customer birth year
                return cMonth;
            }
        }

        /**************************************
       Birth Date
       **************************************/
        public int pBirthDay
        {

            //Getter.
            get
            {
                BirthdateParser(birthDate);

                //Return the customer birth year
                return cDay;
            }
        }

        /**************************************
        Birth Year
        **************************************/
        public int pBirthYear
        {

            //Getter.
            get
            {
                BirthdateParser(birthDate);

                //Return the customer birth year
                return cBirthYear;
            }
        }

        /**************************************
        Count of Characters
        **************************************/
        //accesses number of characters in user's name
        public int pCount
        {
            //Getter.
            get
            {
                CharacterParser(fullName);

                //Return the count of number of characters in client's name
                return countName;
            }
        }


        /**************************************
        Purchase Month
        **************************************/
        public string pPurchaseMonth
        {

            //Getter.
            get
            {
                MonthParser(subscribeMonth);

                //Return the customer purchase month
                return cPurchaseMonth;
            }
        }

        /**************************************
        Default Constructor
        **************************************/
        public CustomerClass() 
        {
        }

        /**************************************
        Parameterized Constructor
        **************************************/
        public CustomerClass(string f, string b, int m)
        {
            fullName = f;
            pBirthdate = b;
            subscribeMonth = m;
        }

        /**************************************
        Name Parsing Method
        **************************************/
        //used to get the full name of the user
        public void NameParser(string f)
        {

            //Split the full name and place in array
            string[] partition = f.Split(' ');
            //Assign partition[0] as first name.
            firstName = partition[0];
            //Assign partition[1] as last name.
            lastName = partition[1];
        }

        /********************************************
        Count Method - Parses Number of Characters
        ********************************************/
        //get number of characters in user's/client's name
        public void CharacterParser(string s)
        {
            //integer to count the characters
            //including spaces in user's name
            countName = s.Length;
        }

        /********************************************
        Birthdate Parser - Parse Year from Birthdate
        ********************************************/
        //To get the birthdate from year
        public void BirthdateParser(string b)
        {

            //Split the year
            string[] partition = b.Split('/');
            //Assign partition[0] as birth month
            cMonth = Convert.ToInt32(partition[0]);
            //Assign partition[1] as birth day
            cDay = Convert.ToInt32(partition[1]);
            //Assign partition[2] as birth year
            cBirthYear = Convert.ToInt32(partition[2]);
        }

        /**************************************
        Determines Month Name from Month Number
        **************************************/
        //To determine the month name from the month number
        public void MonthParser(int m)
        {

            //Array for Name Of Months
            string[] NameOfMonths =
            { "Jan", "Feb", "Mar",
            "Apr", "May", "Jun",
            "Jul", "Aug", "Sep",
            "Oct", "Nov", "Dec" };

            NameOfMonths[0] = NameOfMonths[0].TrimStart('0');
            //Assign birthmonth three digit as birth month
            //Assign NameOfMonths[m - 1] as purchase month
            cPurchaseMonth = NameOfMonths[m - 1];
        }
    }
}

