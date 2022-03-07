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
 * PAY CLASS TO CALCULATE EMPLOYEE PAY
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
    Pay Class
    **************************************/
    class Pay
    {
        /**************************************
         Constant values for calculations here
        **************************************/
        //federal tax rate on total sales
        const decimal FEDERAL_TAX_RATE = 0.18M;
        //retirement contribution from sales
        const decimal RETIREMENT_CONTRIBUTION = 0.10M;
        //social security rate
        const decimal SOCIAL_SECURITY = 0.06M;
        //total percentages deducted from sales
        const decimal TOTAL_DEDUCT = 0.34M;
        //employee income from percentage of total sales
        const decimal EMPLOYEE_KEEPS = 0.07M;


        /**************************************
        Variables
        **************************************/
        //sales made by employee during the week
        private decimal weekSales;
        //total commission employees have made from sales
        private decimal totalSales;

        /**************************************
        Method - Set Number of Sales for the week
        **************************************/
        public void setweekSales(decimal sales)
        {
            weekSales = sales;
        }

        /**************************************************
        Method - Get total sales commisssion (for employee)
        ***************************************************/
        public decimal getTotalSales()
        {
            return weekSales * EMPLOYEE_KEEPS;
        }

        /**************************************************
       Method - Return the Federal Taxes Employee Has to Pay
       ***************************************************/
        public decimal getFederalTax()
        {
            return (weekSales * EMPLOYEE_KEEPS) * FEDERAL_TAX_RATE;
        }

        /**************************************************
       Method - Return what Employee Owes on SS
       ***************************************************/
        public decimal getSecurityTax()
        {
            return (weekSales * EMPLOYEE_KEEPS) * SOCIAL_SECURITY;
        }

        /**************************************************
       Method - Return what Employee Pays for Retirement
       ***************************************************/
        public decimal getRetirement()
        {
            return (weekSales * EMPLOYEE_KEEPS) * RETIREMENT_CONTRIBUTION;
        }

        /**************************************************
       Method - Return Employee Final Pay
       ***************************************************/
        public decimal getTotalPay()
        {
            totalSales = weekSales * EMPLOYEE_KEEPS;
            return totalSales - (totalSales * TOTAL_DEDUCT);
        }
    }
}
