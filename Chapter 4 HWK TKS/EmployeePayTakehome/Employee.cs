/***************************************************************************************************************************
 * Name: Twymun Safford
 * Date: 03/04/22 
 * 
 * Purpose: Write a program that includes an Employee class that can be used to calculate and print the take-home pay for 
 * a commissioned sales employee. All employees receive 7% of the total sales. Federal tax rate  is 18%. Retirement contribution 
 * is 10%. Social Security tax rate is 6%. Write instance methods to calculate the commission income, federal and social 
 * security tax withholding amounts and the amount withheld for retirement. Use appropriate constants, design an object-oriented 
 * solution, and write constructors. Include at least one mutator and one accessor method; provide properties for the other 
 * instance variables. Create a second class to test your design. Allow the user to enter values for the name of the employee 
 * and the sales amount for the week in the second class.
 * 
 * EMPLOYEE CLASS TO GET EMPLOYEE INFORMATION
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #4, Programming Exercise #8
****************************************************************************************************************************/
/**************************************
Import System Namespace
**************************************/
//import system namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeePayTakehome
{
    /**************************************
    Employee Class
    **************************************/
    class Employee
    {
        /**************************************
        Variables
        **************************************/
        private string name;


        /**************************************
        Variables - From Pay Class
        **************************************/
        //new pay object
        Pay Pay1 = new Pay();
        //sales made
        private decimal weekSales;
        //total sales
        private decimal totalSales;
        private decimal federalTax;
        private decimal securityTax;
        private decimal retirement;
        private decimal totalPay;

        /*************************************
        Default Constructor
       **************************************/
        public Employee()
        {

        }

        /**************************************
        Property Accessors - Name
        **************************************/
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        /**************************************
       Property Accessors - Week Sales
       **************************************/
        public decimal WeekSales
        {
            get
            {
                return weekSales;
            }
            set
            {
                weekSales = value;
            }
        }


        /**************************************
        Property Accessors - Total Sales
        **************************************/
        public decimal TotalSales
        {
            get
            {
                return totalSales;
            }
            set
            {
                totalSales = value;
            }
        }

        /**************************************
       Property Accessors - Federal Tax
       **************************************/
        public decimal FederalTax
        {
            get
            {
                return federalTax;
            }
            set
            {
                federalTax = value;
            }
        }

        /**************************************
       Property Accessors - Security Tax
       **************************************/
        public decimal SecurityTax
        {
            get
            {
                return securityTax;
            }
            set
            {
                securityTax = value;
            }
        }

        /**************************************
       Property Accessors - Retirement
       **************************************/
        public decimal Retirement
        {
            get
            {
                return retirement;
            }
            set
            {
                retirement = value;
            }
        }

        /**************************************
       Property Accessors - Total Pay
       **************************************/
        public decimal TotalPay
        {
            get
            {
                return totalPay;
            }
            set
            {
                totalPay = value;
            }
        }


        /***********************************************
        Parameterized Constructor - Access All Variables
       *************************************************/
        public Employee(string name, decimal weekSales, decimal totalSales, decimal federalTax, decimal securityTax, decimal retirement, decimal totalPay)
        {
            Name = name;
            WeekSales = weekSales;
            TotalSales = totalSales;
            FederalTax = federalTax;
            SecurityTax = securityTax;
            Retirement = retirement;
            TotalPay = totalPay;
        }

        /***********************************************
        Get User Input Here
       *************************************************/
        public void userInput()
        {
            //ask user to enter the employee's name
            Console.WriteLine("\nPlease enter the employee's name: ");
            name = Console.ReadLine();
            //get user input based on the user's weekly sales
            Console.WriteLine("\nNow, please enter the total weekly sales by the employee (cents permitted): ");
            weekSales = decimal.Parse(Console.ReadLine());
            while (weekSales < 0)
            {
                Console.WriteLine("\nPlease enter the total weekly sales by the employee as a value greater than zero: ");
                weekSales = decimal.Parse(Console.ReadLine());
            };
            Pay1.setweekSales(weekSales);
            //get the total sales
            totalSales = Pay1.getTotalSales();
            federalTax = Pay1.getFederalTax();
            securityTax = Pay1.getSecurityTax();
            retirement = Pay1.getRetirement();
            totalPay = Pay1.getTotalPay();
        }

        /***********************************************
        Method - Get Input
       *************************************************/

        /**************************************
        ToString Method()
        **************************************/
        public override string ToString()
        {
            //Return values for parameters
            return $"\n===============================\n" +
                   $"Employee Name:  {Name}\n" +
                   $"===============================\n" +
                   $"Sales Made:  {WeekSales, 11:C}\n" +
                   $"===============================\n" +
                   $"Commission:  {TotalSales,11:C}\n" +
                   $"===============================\n" +
                   $"Federal Taxes:  {FederalTax,11:C}\n" +
                   $"===============================\n" +
                   $"Social Security Tax: {SecurityTax,11:C}\n" +
                   $"===============================\n" +
                   $"Retirement: {Retirement,11:C}\n" +
                   $"===============================\n" +
                   $"Net Pay: {TotalPay,11:C}\n" +
                   $"===============================\n";

        }

    }
}
