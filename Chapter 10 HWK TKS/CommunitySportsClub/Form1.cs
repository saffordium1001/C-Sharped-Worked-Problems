/************************************************************************************************************
 * Name: Twymun Safford
 * Date: 05/04/2022 
 * 
 * Purpose: "Community Sports Day!" - Create a graphical user interface that can be used by a 
 * community group  to enable youths to sign up for different sporting events. Include radio 
 * buttons with a minimum of five sports. Wire a single event-handler method to each of the radio buttons. 
 * Program the method to display a different message for each different sport. For example, if one of the 
 * sports is skiing, the message might say, “Bring warm clothes!”  Also include a PictureBox object on the form 
 * to display a different picture based on which sporting event was selected. One approach would be to layer 
 * multiple picture box objects in the same location. When the particular sport is selected, make the associated 
 * PictureBox visible. You can find free graphics on the Internet to use in your application. Hint: One way to 
 * associate a file to the PictureBox control is to Import an image from the Image property.
 * 
 * MAIN PROGRAM DRIVER
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #10, Programming Exercise #4
************************************************************************************************************/

/**************************************
Import System Namespace
**************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CommunitySportsClub
{
    public partial class sportEvent : Form
    {
        public sportEvent()
        {
            InitializeComponent();
            /**************************************
            Hide Images
            **************************************/

            //This portions needs to start first by hiding each of
            //the possible picturebox selections until the user
            //selects a sport

            skiingPictureBox.Hide();
            baseballPictureBox.Hide();
            basketballPictureBox.Hide();
            boxingPictureBox.Hide();
            capoeiraPictureBox.Hide();
            cyclingPictureBox.Hide();
            footballPictureBox.Hide();
            golfPictureBox.Hide();
            hockeyPictureBox.Hide();
            muaythaiPictureBox.Hide();
            rugbyPictureBox.Hide();
            swimmingPictureBox.Hide();
            soccerPictureBox.Hide();
            tennisPictureBox.Hide();
            trackfieldPictureBox.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            //first, establish a regular expression for characters
            Regex r = new Regex("^[a-zA-Z ]+$");
            //check to see if user name is accurate
            if (string.IsNullOrEmpty(nameTextBox.Text) || !r.IsMatch(nameTextBox.Text))
            {
                string message = "Please enter a valid name.";
                string title = "Error!";
                //inform user to enter a valid name
                MessageBox.Show(message, title);
            }
            //now, we need to handle each case where someone decides to sign up for
            //each event
            else
            {
                string titles = "Ready to Go!";
                /**************************************
                Radio Button Trigger-Skiing
                **************************************/
                if (skiingRadioButton.Checked == true)
                {
                    
                    MessageBox.Show(nameTextBox.Text + ", make sure to bring warm clothes and appropriate gear!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Baseball
                **************************************/
                if (baseballRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", make sure to bring your bat, glove, and helmet!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Basketball
                **************************************/
                if (radioBasketballButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", come on and SLAM!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Boxing
                **************************************/
                if (boxingRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", get ready to put them up!", titles);
                    Application.Exit();
                }
                /************************************** 
               Radio Button Trigger-Capoeira
               **************************************/
                if (capoeiraRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", get ready to flip, kick, and play!", titles);
                    Application.Exit();
                }
                /**************************************
               Radio Button Trigger-Cycling
               **************************************/
                if (cyclingRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", make sure your bicycle is well-oiled and operational!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Football
                **************************************/
                if (footballRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", are you ready for some MONDAY NIGHT FOOTBALL?!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Golf
                **************************************/
                if (golfRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", hope you hit a hole in one!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Hockey
                **************************************/
                if (hockeyRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", time to put this on ice!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Muay Thai
                **************************************/
                if (muaythaiRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", it's the eye of the tiger!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Rugby
                **************************************/
                if (rugbyRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", let's have a good hullabalooh!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Swimming
                **************************************/
                if (swimmingRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", time to make a splash!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Soccer
                **************************************/
                if (soccerRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", let's play some futbol!", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Tennis
                **************************************/
                if (tennisRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", let's make it smashing", titles);
                    Application.Exit();
                }
                /**************************************
                Radio Button Trigger-Track and Field
                **************************************/
                if (trackfieldRadioButton.Checked == true)
                {
                    MessageBox.Show(nameTextBox.Text + ", the race is given to the swift and strong in this case!", titles);
                    Application.Exit();
                }
            }
        }


        /**************************************
         Image Triggers - Show Images for 
        Radio Button Clicks
        **************************************/


        //For each corresponding radio button that is clicked,
        //the appropriate stock image needs to show for them.
        
        /**************************************
         Skiing
        **************************************/
        private void skiingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (skiingRadioButton.Checked == true)
            {
                skiingPictureBox.Show();
            }
        }

        /**************************************
         Baseball
        **************************************/
        private void baseballRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (baseballRadioButton.Checked==true)
            {
                baseballPictureBox.Show();
            }
        }

        /**************************************
         Basketball
        **************************************/
        private void radioBasketballButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBasketballButton.Checked==true)
            {
                basketballPictureBox.Show();
            }
        }

        /**************************************
         Boxing
        **************************************/
        private void boxingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (boxingRadioButton.Checked==true)
            {
                boxingPictureBox.Show();
            }
        }

        /**************************************
         Capoeira
        **************************************/
        private void capoeiraRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (capoeiraRadioButton.Checked == true)
            {
                capoeiraPictureBox.Show();
            }
        }

        /**************************************
         Cycling
        **************************************/
        private void cyclingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cyclingRadioButton.Checked == true)
            {
                cyclingPictureBox.Show();
            }
        }

        /**************************************
         Football
        **************************************/
        private void footballRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (footballRadioButton.Checked == true)
            {
                footballPictureBox.Show();
            }
        }

        /**************************************
         Golf
        **************************************/
        private void golfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (golfRadioButton.Checked == true)
            {
                golfPictureBox.Show();
            }
        }

        /**************************************
         Hockey
        **************************************/
        private void hockeyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (hockeyRadioButton.Checked == true)
            {
                hockeyPictureBox.Show();
            }
        }

        /**************************************
         Muay Thai
        **************************************/
        private void muaythaiRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (muaythaiRadioButton.Checked == true)
            {
                muaythaiPictureBox.Show();
            }
        }

        /**************************************
         Rugby
        **************************************/
        private void rugbyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rugbyRadioButton.Checked == true)
            {
                rugbyPictureBox.Show();
            }
        }

        /**************************************
         Swimming
        **************************************/
        private void swimmingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (swimmingRadioButton.Checked == true)
            {
                swimmingPictureBox.Show();
            }
        }

        /**************************************
         Soccer
        **************************************/
        private void soccerRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (soccerRadioButton.Checked == true)
            {
                soccerPictureBox.Show();
            }
        }

        /**************************************
         Tennis
        **************************************/
        private void tennisRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (tennisRadioButton.Checked == true)
            {
                tennisPictureBox.Show();
            }
        }

        /**************************************
         Track and Field
        **************************************/
        private void trackfieldRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (trackfieldRadioButton.Checked==true)
            {
                trackfieldPictureBox.Show();
            }
        }
    }
}
