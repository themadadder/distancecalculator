namespace DistanceTravelled
{
    partial class Form1
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
            this.exitButton = new System.Windows.Forms.Button();
            this.distanceDeclareText = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.Label();
            this.speedInput = new System.Windows.Forms.TextBox();
            this.speedLabel = new System.Windows.Forms.Label();
            this.fiveHourButton = new System.Windows.Forms.Button();
            this.eightHourButton = new System.Windows.Forms.Button();
            this.twelveHourButton = new System.Windows.Forms.Button();
            this.travelTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(93, 123);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // distanceDeclareText
            // 
            this.distanceDeclareText.AutoSize = true;
            this.distanceDeclareText.Location = new System.Drawing.Point(13, 83);
            this.distanceDeclareText.Name = "distanceDeclareText";
            this.distanceDeclareText.Size = new System.Drawing.Size(167, 13);
            this.distanceDeclareText.TabIndex = 11;
            this.distanceDeclareText.Text = "The distance the car will travel is: ";
            // 
            // outputTextBox
            // 
            this.outputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputTextBox.Location = new System.Drawing.Point(15, 97);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(233, 23);
            this.outputTextBox.TabIndex = 12;
            this.outputTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedInput
            // 
            this.speedInput.Location = new System.Drawing.Point(115, 13);
            this.speedInput.Name = "speedInput";
            this.speedInput.Size = new System.Drawing.Size(82, 20);
            this.speedInput.TabIndex = 13;
            this.speedInput.TextChanged += new System.EventHandler(this.speedInput_TextChanged);
            // 
            // speedLabel
            // 
            this.speedLabel.AutoSize = true;
            this.speedLabel.Location = new System.Drawing.Point(12, 16);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(101, 13);
            this.speedLabel.TabIndex = 14;
            this.speedLabel.Text = "Enter speed in mph:";
            // 
            // fiveHourButton
            // 
            this.fiveHourButton.Location = new System.Drawing.Point(12, 57);
            this.fiveHourButton.Name = "fiveHourButton";
            this.fiveHourButton.Size = new System.Drawing.Size(75, 23);
            this.fiveHourButton.TabIndex = 15;
            this.fiveHourButton.Text = "5 Hours";
            this.fiveHourButton.UseVisualStyleBackColor = true;
            this.fiveHourButton.Click += new System.EventHandler(this.fiveHourButton_Click);
            // 
            // eightHourButton
            // 
            this.eightHourButton.Location = new System.Drawing.Point(93, 57);
            this.eightHourButton.Name = "eightHourButton";
            this.eightHourButton.Size = new System.Drawing.Size(75, 23);
            this.eightHourButton.TabIndex = 16;
            this.eightHourButton.Text = "8 Hours";
            this.eightHourButton.UseVisualStyleBackColor = true;
            this.eightHourButton.Click += new System.EventHandler(this.eightHourButton_Click);
            // 
            // twelveHourButton
            // 
            this.twelveHourButton.Location = new System.Drawing.Point(173, 57);
            this.twelveHourButton.Name = "twelveHourButton";
            this.twelveHourButton.Size = new System.Drawing.Size(75, 23);
            this.twelveHourButton.TabIndex = 17;
            this.twelveHourButton.Text = "12 Hours";
            this.twelveHourButton.UseVisualStyleBackColor = true;
            this.twelveHourButton.Click += new System.EventHandler(this.twelveHourButton_Click);
            // 
            // travelTimeLabel
            // 
            this.travelTimeLabel.AutoSize = true;
            this.travelTimeLabel.Location = new System.Drawing.Point(13, 41);
            this.travelTimeLabel.Name = "travelTimeLabel";
            this.travelTimeLabel.Size = new System.Drawing.Size(97, 13);
            this.travelTimeLabel.TabIndex = 18;
            this.travelTimeLabel.Text = "Choose travel time:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 154);
            this.Controls.Add(this.travelTimeLabel);
            this.Controls.Add(this.twelveHourButton);
            this.Controls.Add(this.eightHourButton);
            this.Controls.Add(this.fiveHourButton);
            this.Controls.Add(this.speedLabel);
            this.Controls.Add(this.speedInput);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.distanceDeclareText);
            this.Controls.Add(this.exitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label distanceDeclareText;
        private System.Windows.Forms.Label outputTextBox;
        private System.Windows.Forms.TextBox speedInput;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.Button fiveHourButton;
        private System.Windows.Forms.Button eightHourButton;
        private System.Windows.Forms.Button twelveHourButton;
        private System.Windows.Forms.Label travelTimeLabel;
    }
}

