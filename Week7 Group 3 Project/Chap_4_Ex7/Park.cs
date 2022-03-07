/*************************************************************************************************************************************
 * Group: Group 3 
 * Programmers: Twymun Safford, Amber Sperry, Martin Southwell, Eric Wiley, Justin Tanner 
 * Date: 02/26/2022 
 * 
 * Purpose: "Park Tourism Record" - There are a number of national and state parks available to tourists. 
 * Create a Park class. Include data members such as name of park, location,  type of (i.e., national, state, and local)
 * facility, fee, number of employees, number of visitors recorded for the past 12 months, and annual budget. Write separate 
 * instance methods that (1) return a string representing name of the park, the location, and type of park; (2) 
 * return a string representing the name of the park, the location, and facilities available; (3) compute cost per visitor based on 
 * annual budget and the number of visitors during the last 12 months; and (4) compute revenue from fees for the past year based on number 
 * of visitors and fee. Also include a ToString( ) method that returns all data members with appropriate labels. Create a second class to 
 * test your Park class.
 * 
 * THIS IS THE PARK CLASS
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #4, Programming Exercise #7 (Week 4 Group Project) 
*****************************************************************************************************************************************/

/**************************************
Import System Namespace
**************************************/
//import system namespace
using System;
using static System.Console;


namespace Chap_4_Ex7
{
    /**************************************
    Park Class
    **************************************/
    class Park
    {
        //park name
        private string pName;
        //park type
        private string type;
        //park location
        private string location;
        //park facility
        private string facility;
        //number of employees
        private int employees;
        //number of visitors
        private int visitors;
        //price admission
        private double admission;
        //budget
        private double aBudget;

        public Park() //Constructor default
        {

        }

        //getter and setter Park name
        public string PName
        {
            get { return pName; }
            set { pName = value; }
        }
        //get and set type
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        //get and set location
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        //get and set facility
        public string Facility
        {
            get { return facility; }
            set { facility = value; }
        }
        //get and set employees
        public int Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        //get and set visitors
        public int Visitors
        {
            get { return visitors; }
            set { visitors = value; }
        }
        //get and set admission
        public double Admission
        {
            get { return admission; }
            set { admission = value; }
        }
        //get and set budget
        public double ABudget
        {
            get { return aBudget; }
            set { aBudget = value; }
        }

        //statement to display name of park, type, and location
        public string aSl()
        {
            return "Name: " + pName + "\nType: " + type + "\nLocation: " + location;
        }

        //statemnt to display name of park, location, anf facilities
        public string stuffToDo()
        {
            return "Name: " + pName + "\nLocation: " + location + "Facilities: " + facility;
        }

        //finding cost per visitor against the annual budget
        public double runtimeCost()
        {
            return aBudget / visitors;
        }

        //finding total revenue through admission
        public double moneyMade()
        {
            return visitors * admission;
        }

        //ToString to print the park information
        public override string ToString()
        {
            return "Park Details: \n" + aSl() + "\nPark Details and Facilities: \n" + stuffToDo() + "\nVisitors per Year: \n" + visitors + "\nPrice of Admission: \n" + admission +
                "\nCost per Visitor: \n" + runtimeCost() + "\nNumber of Employees: \n" + employees + "\nAnnual Budget: \n" + aBudget + "\nTotal Revenue: \n" + moneyMade();
        }
    }
}