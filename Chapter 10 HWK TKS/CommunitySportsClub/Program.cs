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

namespace CommunitySportsClub
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new sportEvent());
        }
    }
}
