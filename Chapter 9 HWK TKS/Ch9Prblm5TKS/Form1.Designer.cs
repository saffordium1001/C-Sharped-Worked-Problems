
namespace Ch9Prblm5TKS
{
    partial class GasMileage
    {
        // <summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GasMileage));
            this.lblDestination = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.tbMiles = new System.Windows.Forms.TextBox();
            this.lblMiles = new System.Windows.Forms.Label();
            this.tbGas = new System.Windows.Forms.TextBox();
            this.lblGas = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMPG = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(64, 50);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(94, 13);
            this.lblDestination.TabIndex = 1;
            this.lblDestination.Text = "Enter Destination: ";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(164, 47);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(215, 20);
            this.tbDestination.TabIndex = 2;
            // 
            // tbMiles
            // 
            this.tbMiles.Location = new System.Drawing.Point(164, 89);
            this.tbMiles.Name = "tbMiles";
            this.tbMiles.Size = new System.Drawing.Size(215, 20);
            this.tbMiles.TabIndex = 4;
            // 
            // lblMiles
            // 
            this.lblMiles.AutoSize = true;
            this.lblMiles.Location = new System.Drawing.Point(76, 92);
            this.lblMiles.Name = "lblMiles";
            this.lblMiles.Size = new System.Drawing.Size(82, 13);
            this.lblMiles.TabIndex = 3;
            this.lblMiles.Text = "Miles Traveled: ";
            // 
            // tbGas
            // 
            this.tbGas.Location = new System.Drawing.Point(164, 127);
            this.tbGas.Name = "tbGas";
            this.tbGas.Size = new System.Drawing.Size(215, 20);
            this.tbGas.TabIndex = 6;
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Location = new System.Drawing.Point(24, 130);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(134, 13);
            this.lblGas.TabIndex = 5;
            this.lblGas.Text = "Gallons of Gas consumed: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(105, 165);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(294, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMPG
            // 
            this.lblMPG.AutoSize = true;
            this.lblMPG.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPG.Location = new System.Drawing.Point(24, 238);
            this.lblMPG.Name = "lblMPG";
            this.lblMPG.Size = new System.Drawing.Size(0, 21);
            this.lblMPG.TabIndex = 9;
            // 
            // GasMileage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 317);
            this.Controls.Add(this.lblMPG);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbGas);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.tbMiles);
            this.Controls.Add(this.lblMiles);
            this.Controls.Add(this.tbDestination);
            this.Controls.Add(this.lblDestination);
            this.Name = "GasMileage";
            this.Text = "Gas Trip Calculator";
            this.Load += new System.EventHandler(this.GasMileage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.TextBox tbMiles;
        private System.Windows.Forms.Label lblMiles;
        private System.Windows.Forms.TextBox tbGas;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMPG;
    }
}

