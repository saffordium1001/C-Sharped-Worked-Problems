using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch9Prblm5TKS
{
    public partial class GasMileage : Form
    {
        public GasMileage()
        {
            InitializeComponent();
        }
        //Calculate button click event handler
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double milesTraveled = 0.0;
            double gallonsUsed = 0.0;
            //check if the user has not entered a destination
            if (String.IsNullOrEmpty(tbDestination.Text))
            {
                //tell user they are missing the destination
                MessageBox.Show("Please enter a destination!");
                tbDestination.Focus();
            }
            //but, what is the user didn't enter a valid value for the miles traveled
            else if (!double.TryParse(tbMiles.Text, out milesTraveled) || milesTraveled <= 0)
            {
                //tell user and reset miles traveled
                MessageBox.Show("Please enter a distance greater than 0!");
                tbMiles.Text = "";
                tbMiles.Focus();
            }
            //check for gas mileage to see if it is valid
            else if (!double.TryParse(tbMiles.Text, out milesTraveled) || milesTraveled <= 0)
            {
                //tell user and reset miles traveled
                MessageBox.Show("Please enter a distance greater than 0!");
                tbMiles.Text = "";
                tbMiles.Focus();
            }
            else if (!double.TryParse(tbGas.Text, out gallonsUsed) || gallonsUsed <= 0)
            {
                //tell user and reset miles traveled
                MessageBox.Show("In an ideal world, you wouldn't need gallons to travel..\nplease enter a value of gas consumed greater than 0!");
                tbGas.Text = "";
                tbGas.Focus();
            }
            else
            {
                //Reading number of miles traveled
                milesTraveled = Convert.ToDouble(tbMiles.Text);

                //Reading gallons of gas consumed
                gallonsUsed = Convert.ToDouble(tbGas.Text);

                //Calculating Miles Per Gallon
                double MPG = milesTraveled / gallonsUsed;

                //Writing result back to form
                lblMPG.Text = " Your vehicle's miles per gallon is:\n " + Math.Round(MPG, 2).ToString() + " mpg.";
            }
        }

        //Clear button click event handler
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Values start off as zero/null
            tbDestination.Text = "";
            tbGas.Text = "0.0";
            tbMiles.Text = "0.0";
            //Clearing textbox values
            tbGas.Clear();
            tbMiles.Clear();
            tbDestination.Clear();
        }

        private void GasMileage_Load(object sender, EventArgs e)
        {

        }
    }
}
