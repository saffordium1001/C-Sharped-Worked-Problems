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
 * DESIGNER
 * 
 * Class: CITP 180 (Spring '22 - CRN: 80660)
 * Assignment: Chapter #10, Programming Exercise #4
************************************************************************************************************/
namespace CommunitySportsClub
{
    partial class sportEvent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sportEvent));
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.communitySportsLabel = new System.Windows.Forms.Label();
            this.sportsLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.skiingRadioButton = new System.Windows.Forms.RadioButton();
            this.baseballRadioButton = new System.Windows.Forms.RadioButton();
            this.radioBasketballButton = new System.Windows.Forms.RadioButton();
            this.boxingRadioButton = new System.Windows.Forms.RadioButton();
            this.capoeiraRadioButton = new System.Windows.Forms.RadioButton();
            this.cyclingRadioButton = new System.Windows.Forms.RadioButton();
            this.footballRadioButton = new System.Windows.Forms.RadioButton();
            this.golfRadioButton = new System.Windows.Forms.RadioButton();
            this.hockeyRadioButton = new System.Windows.Forms.RadioButton();
            this.muaythaiRadioButton = new System.Windows.Forms.RadioButton();
            this.rugbyRadioButton = new System.Windows.Forms.RadioButton();
            this.swimmingRadioButton = new System.Windows.Forms.RadioButton();
            this.soccerRadioButton = new System.Windows.Forms.RadioButton();
            this.tennisRadioButton = new System.Windows.Forms.RadioButton();
            this.trackfieldRadioButton = new System.Windows.Forms.RadioButton();
            this.skiingPictureBox = new System.Windows.Forms.PictureBox();
            this.baseballPictureBox = new System.Windows.Forms.PictureBox();
            this.basketballPictureBox = new System.Windows.Forms.PictureBox();
            this.boxingPictureBox = new System.Windows.Forms.PictureBox();
            this.capoeiraPictureBox = new System.Windows.Forms.PictureBox();
            this.cyclingPictureBox = new System.Windows.Forms.PictureBox();
            this.footballPictureBox = new System.Windows.Forms.PictureBox();
            this.golfPictureBox = new System.Windows.Forms.PictureBox();
            this.hockeyPictureBox = new System.Windows.Forms.PictureBox();
            this.muaythaiPictureBox = new System.Windows.Forms.PictureBox();
            this.rugbyPictureBox = new System.Windows.Forms.PictureBox();
            this.swimmingPictureBox = new System.Windows.Forms.PictureBox();
            this.soccerPictureBox = new System.Windows.Forms.PictureBox();
            this.tennisPictureBox = new System.Windows.Forms.PictureBox();
            this.trackfieldPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.skiingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketballPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.capoeiraPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaythaiPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rugbyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennisPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackfieldPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(58, 69);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(240, 37);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Enter your Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(353, 83);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(688, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // communitySportsLabel
            // 
            this.communitySportsLabel.AutoSize = true;
            this.communitySportsLabel.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.communitySportsLabel.Location = new System.Drawing.Point(345, 9);
            this.communitySportsLabel.Name = "communitySportsLabel";
            this.communitySportsLabel.Size = new System.Drawing.Size(554, 47);
            this.communitySportsLabel.TabIndex = 2;
            this.communitySportsLabel.Text = "Community Sports Day Sign Up!";
            // 
            // sportsLabel
            // 
            this.sportsLabel.AutoSize = true;
            this.sportsLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sportsLabel.Location = new System.Drawing.Point(56, 127);
            this.sportsLabel.Name = "sportsLabel";
            this.sportsLabel.Size = new System.Drawing.Size(245, 37);
            this.sportsLabel.TabIndex = 3;
            this.sportsLabel.Text = "Select Your Sport:";
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(473, 460);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(201, 57);
            this.signUpButton.TabIndex = 4;
            this.signUpButton.Text = "Sign Up!!";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // skiingRadioButton
            // 
            this.skiingRadioButton.AutoSize = true;
            this.skiingRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skiingRadioButton.Location = new System.Drawing.Point(63, 167);
            this.skiingRadioButton.Name = "skiingRadioButton";
            this.skiingRadioButton.Size = new System.Drawing.Size(98, 36);
            this.skiingRadioButton.TabIndex = 5;
            this.skiingRadioButton.TabStop = true;
            this.skiingRadioButton.Text = "Skiing";
            this.skiingRadioButton.UseVisualStyleBackColor = true;
            this.skiingRadioButton.CheckedChanged += new System.EventHandler(this.skiingRadioButton_CheckedChanged);
            // 
            // baseballRadioButton
            // 
            this.baseballRadioButton.AutoSize = true;
            this.baseballRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseballRadioButton.Location = new System.Drawing.Point(63, 218);
            this.baseballRadioButton.Name = "baseballRadioButton";
            this.baseballRadioButton.Size = new System.Drawing.Size(120, 36);
            this.baseballRadioButton.TabIndex = 6;
            this.baseballRadioButton.TabStop = true;
            this.baseballRadioButton.Text = "Baseball";
            this.baseballRadioButton.UseVisualStyleBackColor = true;
            this.baseballRadioButton.CheckedChanged += new System.EventHandler(this.baseballRadioButton_CheckedChanged);
            // 
            // radioBasketballButton
            // 
            this.radioBasketballButton.AutoSize = true;
            this.radioBasketballButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBasketballButton.Location = new System.Drawing.Point(63, 273);
            this.radioBasketballButton.Name = "radioBasketballButton";
            this.radioBasketballButton.Size = new System.Drawing.Size(140, 36);
            this.radioBasketballButton.TabIndex = 7;
            this.radioBasketballButton.TabStop = true;
            this.radioBasketballButton.Text = "Basketball";
            this.radioBasketballButton.UseVisualStyleBackColor = true;
            this.radioBasketballButton.CheckedChanged += new System.EventHandler(this.radioBasketballButton_CheckedChanged);
            // 
            // boxingRadioButton
            // 
            this.boxingRadioButton.AutoSize = true;
            this.boxingRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxingRadioButton.Location = new System.Drawing.Point(63, 329);
            this.boxingRadioButton.Name = "boxingRadioButton";
            this.boxingRadioButton.Size = new System.Drawing.Size(106, 36);
            this.boxingRadioButton.TabIndex = 8;
            this.boxingRadioButton.TabStop = true;
            this.boxingRadioButton.Text = "Boxing";
            this.boxingRadioButton.UseVisualStyleBackColor = true;
            this.boxingRadioButton.CheckedChanged += new System.EventHandler(this.boxingRadioButton_CheckedChanged);
            // 
            // capoeiraRadioButton
            // 
            this.capoeiraRadioButton.AutoSize = true;
            this.capoeiraRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capoeiraRadioButton.Location = new System.Drawing.Point(63, 387);
            this.capoeiraRadioButton.Name = "capoeiraRadioButton";
            this.capoeiraRadioButton.Size = new System.Drawing.Size(127, 36);
            this.capoeiraRadioButton.TabIndex = 9;
            this.capoeiraRadioButton.TabStop = true;
            this.capoeiraRadioButton.Text = "Capoeira";
            this.capoeiraRadioButton.UseVisualStyleBackColor = true;
            this.capoeiraRadioButton.CheckedChanged += new System.EventHandler(this.capoeiraRadioButton_CheckedChanged);
            // 
            // cyclingRadioButton
            // 
            this.cyclingRadioButton.AutoSize = true;
            this.cyclingRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cyclingRadioButton.Location = new System.Drawing.Point(235, 167);
            this.cyclingRadioButton.Name = "cyclingRadioButton";
            this.cyclingRadioButton.Size = new System.Drawing.Size(111, 36);
            this.cyclingRadioButton.TabIndex = 10;
            this.cyclingRadioButton.TabStop = true;
            this.cyclingRadioButton.Text = "Cycling";
            this.cyclingRadioButton.UseVisualStyleBackColor = true;
            this.cyclingRadioButton.CheckedChanged += new System.EventHandler(this.cyclingRadioButton_CheckedChanged);
            // 
            // footballRadioButton
            // 
            this.footballRadioButton.AutoSize = true;
            this.footballRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footballRadioButton.Location = new System.Drawing.Point(235, 218);
            this.footballRadioButton.Name = "footballRadioButton";
            this.footballRadioButton.Size = new System.Drawing.Size(119, 36);
            this.footballRadioButton.TabIndex = 11;
            this.footballRadioButton.TabStop = true;
            this.footballRadioButton.Text = "Football";
            this.footballRadioButton.UseVisualStyleBackColor = true;
            this.footballRadioButton.CheckedChanged += new System.EventHandler(this.footballRadioButton_CheckedChanged);
            // 
            // golfRadioButton
            // 
            this.golfRadioButton.AutoSize = true;
            this.golfRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.golfRadioButton.Location = new System.Drawing.Point(235, 273);
            this.golfRadioButton.Name = "golfRadioButton";
            this.golfRadioButton.Size = new System.Drawing.Size(77, 36);
            this.golfRadioButton.TabIndex = 12;
            this.golfRadioButton.TabStop = true;
            this.golfRadioButton.Text = "Golf";
            this.golfRadioButton.UseVisualStyleBackColor = true;
            this.golfRadioButton.CheckedChanged += new System.EventHandler(this.golfRadioButton_CheckedChanged);
            // 
            // hockeyRadioButton
            // 
            this.hockeyRadioButton.AutoSize = true;
            this.hockeyRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hockeyRadioButton.Location = new System.Drawing.Point(235, 329);
            this.hockeyRadioButton.Name = "hockeyRadioButton";
            this.hockeyRadioButton.Size = new System.Drawing.Size(112, 36);
            this.hockeyRadioButton.TabIndex = 13;
            this.hockeyRadioButton.TabStop = true;
            this.hockeyRadioButton.Text = "Hockey";
            this.hockeyRadioButton.UseVisualStyleBackColor = true;
            this.hockeyRadioButton.CheckedChanged += new System.EventHandler(this.hockeyRadioButton_CheckedChanged);
            // 
            // muaythaiRadioButton
            // 
            this.muaythaiRadioButton.AutoSize = true;
            this.muaythaiRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muaythaiRadioButton.Location = new System.Drawing.Point(235, 387);
            this.muaythaiRadioButton.Name = "muaythaiRadioButton";
            this.muaythaiRadioButton.Size = new System.Drawing.Size(145, 36);
            this.muaythaiRadioButton.TabIndex = 14;
            this.muaythaiRadioButton.TabStop = true;
            this.muaythaiRadioButton.Text = "Muay Thai";
            this.muaythaiRadioButton.UseVisualStyleBackColor = true;
            this.muaythaiRadioButton.CheckedChanged += new System.EventHandler(this.muaythaiRadioButton_CheckedChanged);
            // 
            // rugbyRadioButton
            // 
            this.rugbyRadioButton.AutoSize = true;
            this.rugbyRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rugbyRadioButton.Location = new System.Drawing.Point(406, 167);
            this.rugbyRadioButton.Name = "rugbyRadioButton";
            this.rugbyRadioButton.Size = new System.Drawing.Size(101, 36);
            this.rugbyRadioButton.TabIndex = 15;
            this.rugbyRadioButton.TabStop = true;
            this.rugbyRadioButton.Text = "Rugby";
            this.rugbyRadioButton.UseVisualStyleBackColor = true;
            this.rugbyRadioButton.CheckedChanged += new System.EventHandler(this.rugbyRadioButton_CheckedChanged);
            // 
            // swimmingRadioButton
            // 
            this.swimmingRadioButton.AutoSize = true;
            this.swimmingRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmingRadioButton.Location = new System.Drawing.Point(406, 218);
            this.swimmingRadioButton.Name = "swimmingRadioButton";
            this.swimmingRadioButton.Size = new System.Drawing.Size(145, 36);
            this.swimmingRadioButton.TabIndex = 16;
            this.swimmingRadioButton.TabStop = true;
            this.swimmingRadioButton.Text = "Swimming";
            this.swimmingRadioButton.UseVisualStyleBackColor = true;
            this.swimmingRadioButton.CheckedChanged += new System.EventHandler(this.swimmingRadioButton_CheckedChanged);
            // 
            // soccerRadioButton
            // 
            this.soccerRadioButton.AutoSize = true;
            this.soccerRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soccerRadioButton.Location = new System.Drawing.Point(406, 273);
            this.soccerRadioButton.Name = "soccerRadioButton";
            this.soccerRadioButton.Size = new System.Drawing.Size(103, 36);
            this.soccerRadioButton.TabIndex = 22;
            this.soccerRadioButton.TabStop = true;
            this.soccerRadioButton.Text = "Soccer";
            this.soccerRadioButton.UseVisualStyleBackColor = true;
            this.soccerRadioButton.CheckedChanged += new System.EventHandler(this.soccerRadioButton_CheckedChanged);
            // 
            // tennisRadioButton
            // 
            this.tennisRadioButton.AutoSize = true;
            this.tennisRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tennisRadioButton.Location = new System.Drawing.Point(406, 329);
            this.tennisRadioButton.Name = "tennisRadioButton";
            this.tennisRadioButton.Size = new System.Drawing.Size(101, 36);
            this.tennisRadioButton.TabIndex = 23;
            this.tennisRadioButton.TabStop = true;
            this.tennisRadioButton.Text = "Tennis";
            this.tennisRadioButton.UseVisualStyleBackColor = true;
            this.tennisRadioButton.CheckedChanged += new System.EventHandler(this.tennisRadioButton_CheckedChanged);
            // 
            // trackfieldRadioButton
            // 
            this.trackfieldRadioButton.AutoSize = true;
            this.trackfieldRadioButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackfieldRadioButton.Location = new System.Drawing.Point(406, 387);
            this.trackfieldRadioButton.Name = "trackfieldRadioButton";
            this.trackfieldRadioButton.Size = new System.Drawing.Size(192, 36);
            this.trackfieldRadioButton.TabIndex = 24;
            this.trackfieldRadioButton.TabStop = true;
            this.trackfieldRadioButton.Text = "Track and Field";
            this.trackfieldRadioButton.UseVisualStyleBackColor = true;
            this.trackfieldRadioButton.CheckedChanged += new System.EventHandler(this.trackfieldRadioButton_CheckedChanged);
            // 
            // skiingPictureBox
            // 
            this.skiingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("skiingPictureBox.Image")));
            this.skiingPictureBox.Location = new System.Drawing.Point(640, 112);
            this.skiingPictureBox.Name = "skiingPictureBox";
            this.skiingPictureBox.Size = new System.Drawing.Size(533, 342);
            this.skiingPictureBox.TabIndex = 25;
            this.skiingPictureBox.TabStop = false;
            // 
            // baseballPictureBox
            // 
            this.baseballPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("baseballPictureBox.Image")));
            this.baseballPictureBox.Location = new System.Drawing.Point(640, 112);
            this.baseballPictureBox.Name = "baseballPictureBox";
            this.baseballPictureBox.Size = new System.Drawing.Size(533, 342);
            this.baseballPictureBox.TabIndex = 26;
            this.baseballPictureBox.TabStop = false;
            // 
            // basketballPictureBox
            // 
            this.basketballPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("basketballPictureBox.Image")));
            this.basketballPictureBox.Location = new System.Drawing.Point(640, 112);
            this.basketballPictureBox.Name = "basketballPictureBox";
            this.basketballPictureBox.Size = new System.Drawing.Size(533, 342);
            this.basketballPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.basketballPictureBox.TabIndex = 27;
            this.basketballPictureBox.TabStop = false;
            // 
            // boxingPictureBox
            // 
            this.boxingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("boxingPictureBox.Image")));
            this.boxingPictureBox.Location = new System.Drawing.Point(640, 112);
            this.boxingPictureBox.Name = "boxingPictureBox";
            this.boxingPictureBox.Size = new System.Drawing.Size(533, 342);
            this.boxingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.boxingPictureBox.TabIndex = 28;
            this.boxingPictureBox.TabStop = false;
            // 
            // capoeiraPictureBox
            // 
            this.capoeiraPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("capoeiraPictureBox.Image")));
            this.capoeiraPictureBox.Location = new System.Drawing.Point(640, 112);
            this.capoeiraPictureBox.Name = "capoeiraPictureBox";
            this.capoeiraPictureBox.Size = new System.Drawing.Size(533, 342);
            this.capoeiraPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capoeiraPictureBox.TabIndex = 29;
            this.capoeiraPictureBox.TabStop = false;
            // 
            // cyclingPictureBox
            // 
            this.cyclingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cyclingPictureBox.Image")));
            this.cyclingPictureBox.Location = new System.Drawing.Point(640, 112);
            this.cyclingPictureBox.Name = "cyclingPictureBox";
            this.cyclingPictureBox.Size = new System.Drawing.Size(533, 342);
            this.cyclingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cyclingPictureBox.TabIndex = 30;
            this.cyclingPictureBox.TabStop = false;
            // 
            // footballPictureBox
            // 
            this.footballPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("footballPictureBox.Image")));
            this.footballPictureBox.Location = new System.Drawing.Point(640, 112);
            this.footballPictureBox.Name = "footballPictureBox";
            this.footballPictureBox.Size = new System.Drawing.Size(533, 342);
            this.footballPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.footballPictureBox.TabIndex = 31;
            this.footballPictureBox.TabStop = false;
            // 
            // golfPictureBox
            // 
            this.golfPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("golfPictureBox.Image")));
            this.golfPictureBox.Location = new System.Drawing.Point(640, 112);
            this.golfPictureBox.Name = "golfPictureBox";
            this.golfPictureBox.Size = new System.Drawing.Size(533, 342);
            this.golfPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.golfPictureBox.TabIndex = 32;
            this.golfPictureBox.TabStop = false;
            // 
            // hockeyPictureBox
            // 
            this.hockeyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("hockeyPictureBox.Image")));
            this.hockeyPictureBox.Location = new System.Drawing.Point(640, 112);
            this.hockeyPictureBox.Name = "hockeyPictureBox";
            this.hockeyPictureBox.Size = new System.Drawing.Size(533, 342);
            this.hockeyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hockeyPictureBox.TabIndex = 33;
            this.hockeyPictureBox.TabStop = false;
            // 
            // muaythaiPictureBox
            // 
            this.muaythaiPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("muaythaiPictureBox.Image")));
            this.muaythaiPictureBox.Location = new System.Drawing.Point(640, 112);
            this.muaythaiPictureBox.Name = "muaythaiPictureBox";
            this.muaythaiPictureBox.Size = new System.Drawing.Size(533, 342);
            this.muaythaiPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.muaythaiPictureBox.TabIndex = 34;
            this.muaythaiPictureBox.TabStop = false;
            // 
            // rugbyPictureBox
            // 
            this.rugbyPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("rugbyPictureBox.Image")));
            this.rugbyPictureBox.Location = new System.Drawing.Point(640, 112);
            this.rugbyPictureBox.Name = "rugbyPictureBox";
            this.rugbyPictureBox.Size = new System.Drawing.Size(533, 342);
            this.rugbyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rugbyPictureBox.TabIndex = 35;
            this.rugbyPictureBox.TabStop = false;
            // 
            // swimmingPictureBox
            // 
            this.swimmingPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("swimmingPictureBox.Image")));
            this.swimmingPictureBox.Location = new System.Drawing.Point(640, 112);
            this.swimmingPictureBox.Name = "swimmingPictureBox";
            this.swimmingPictureBox.Size = new System.Drawing.Size(533, 342);
            this.swimmingPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.swimmingPictureBox.TabIndex = 36;
            this.swimmingPictureBox.TabStop = false;
            // 
            // soccerPictureBox
            // 
            this.soccerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("soccerPictureBox.Image")));
            this.soccerPictureBox.Location = new System.Drawing.Point(640, 112);
            this.soccerPictureBox.Name = "soccerPictureBox";
            this.soccerPictureBox.Size = new System.Drawing.Size(533, 342);
            this.soccerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.soccerPictureBox.TabIndex = 37;
            this.soccerPictureBox.TabStop = false;
            // 
            // tennisPictureBox
            // 
            this.tennisPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("tennisPictureBox.Image")));
            this.tennisPictureBox.Location = new System.Drawing.Point(640, 112);
            this.tennisPictureBox.Name = "tennisPictureBox";
            this.tennisPictureBox.Size = new System.Drawing.Size(533, 342);
            this.tennisPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tennisPictureBox.TabIndex = 38;
            this.tennisPictureBox.TabStop = false;
            // 
            // trackfieldPictureBox
            // 
            this.trackfieldPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("trackfieldPictureBox.Image")));
            this.trackfieldPictureBox.Location = new System.Drawing.Point(640, 112);
            this.trackfieldPictureBox.Name = "trackfieldPictureBox";
            this.trackfieldPictureBox.Size = new System.Drawing.Size(533, 342);
            this.trackfieldPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trackfieldPictureBox.TabIndex = 39;
            this.trackfieldPictureBox.TabStop = false;
            // 
            // sportEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 519);
            this.Controls.Add(this.trackfieldPictureBox);
            this.Controls.Add(this.tennisPictureBox);
            this.Controls.Add(this.soccerPictureBox);
            this.Controls.Add(this.swimmingPictureBox);
            this.Controls.Add(this.rugbyPictureBox);
            this.Controls.Add(this.muaythaiPictureBox);
            this.Controls.Add(this.hockeyPictureBox);
            this.Controls.Add(this.golfPictureBox);
            this.Controls.Add(this.footballPictureBox);
            this.Controls.Add(this.cyclingPictureBox);
            this.Controls.Add(this.capoeiraPictureBox);
            this.Controls.Add(this.boxingPictureBox);
            this.Controls.Add(this.basketballPictureBox);
            this.Controls.Add(this.baseballPictureBox);
            this.Controls.Add(this.skiingPictureBox);
            this.Controls.Add(this.trackfieldRadioButton);
            this.Controls.Add(this.tennisRadioButton);
            this.Controls.Add(this.soccerRadioButton);
            this.Controls.Add(this.swimmingRadioButton);
            this.Controls.Add(this.rugbyRadioButton);
            this.Controls.Add(this.muaythaiRadioButton);
            this.Controls.Add(this.hockeyRadioButton);
            this.Controls.Add(this.golfRadioButton);
            this.Controls.Add(this.footballRadioButton);
            this.Controls.Add(this.cyclingRadioButton);
            this.Controls.Add(this.capoeiraRadioButton);
            this.Controls.Add(this.boxingRadioButton);
            this.Controls.Add(this.radioBasketballButton);
            this.Controls.Add(this.baseballRadioButton);
            this.Controls.Add(this.skiingRadioButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.sportsLabel);
            this.Controls.Add(this.communitySportsLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "sportEvent";
            this.Text = "Sports Event Sign-Up";
            ((System.ComponentModel.ISupportInitialize)(this.skiingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseballPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basketballPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.capoeiraPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golfPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hockeyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.muaythaiPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rugbyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.swimmingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tennisPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackfieldPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label communitySportsLabel;
        private System.Windows.Forms.Label sportsLabel;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.RadioButton skiingRadioButton;
        private System.Windows.Forms.RadioButton baseballRadioButton;
        private System.Windows.Forms.RadioButton radioBasketballButton;
        private System.Windows.Forms.RadioButton boxingRadioButton;
        private System.Windows.Forms.RadioButton capoeiraRadioButton;
        private System.Windows.Forms.RadioButton cyclingRadioButton;
        private System.Windows.Forms.RadioButton footballRadioButton;
        private System.Windows.Forms.RadioButton golfRadioButton;
        private System.Windows.Forms.RadioButton hockeyRadioButton;
        private System.Windows.Forms.RadioButton muaythaiRadioButton;
        private System.Windows.Forms.RadioButton rugbyRadioButton;
        private System.Windows.Forms.RadioButton swimmingRadioButton;
        private System.Windows.Forms.RadioButton soccerRadioButton;
        private System.Windows.Forms.RadioButton tennisRadioButton;
        private System.Windows.Forms.RadioButton trackfieldRadioButton;
        private System.Windows.Forms.PictureBox skiingPictureBox;
        private System.Windows.Forms.PictureBox baseballPictureBox;
        private System.Windows.Forms.PictureBox basketballPictureBox;
        private System.Windows.Forms.PictureBox boxingPictureBox;
        private System.Windows.Forms.PictureBox capoeiraPictureBox;
        private System.Windows.Forms.PictureBox cyclingPictureBox;
        private System.Windows.Forms.PictureBox footballPictureBox;
        private System.Windows.Forms.PictureBox golfPictureBox;
        private System.Windows.Forms.PictureBox hockeyPictureBox;
        private System.Windows.Forms.PictureBox muaythaiPictureBox;
        private System.Windows.Forms.PictureBox rugbyPictureBox;
        private System.Windows.Forms.PictureBox swimmingPictureBox;
        private System.Windows.Forms.PictureBox soccerPictureBox;
        private System.Windows.Forms.PictureBox tennisPictureBox;
        private System.Windows.Forms.PictureBox trackfieldPictureBox;
    }
}

