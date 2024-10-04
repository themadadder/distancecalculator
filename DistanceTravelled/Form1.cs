using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanceTravelled
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void speedInput_TextChanged(object sender, EventArgs e)
        {
           





        }

        private void fiveHourButton_Click(object sender, EventArgs e)
        {
            // Converts the user input to an integer
            int speed = int.Parse(speedInput.Text);

            // Declaring pre-set time frame variable
            int time = 5;

            // Preforming the distance calculation as a seperate variable
            int distance = speed * time;

            /* Displaying the travel time text to the user after converting the 
               value back to a string and using concatenation for presentation.
            */ 
            outputTextBox.Text = distance.ToString() + " miles";
            

        }

        private void eightHourButton_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(speedInput.Text);
            int time = 8;
            int distance = speed * time;

            outputTextBox.Text = distance.ToString() + " miles";
        }

        private void twelveHourButton_Click(object sender, EventArgs e)
        {
            int speed = int.Parse(speedInput.Text);
            int time = 12;
            int distance = speed * time;

            outputTextBox.Text = distance.ToString() + " miles";

        }
    }
}
