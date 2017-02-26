using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorldWH
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.Location = new Point();
            //this.Size = new Size(Width, Height);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // have the clear button clear the input from the codeInput field
        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the text
            codeInputText.Clear();
        }

        // have this button change the color of the background of the GUI
        private void colorChangeButton_Click(object sender, EventArgs e)
        {
            //randomly change the background color of the GUI

            //create a random number generator
            Random rgen = new Random();

            //create an int to store the random number created
            int randomColor = rgen.Next(1, 7);

            //create a switch statement to change the color
            switch (randomColor)
            {
                case 1:
                    this.BackColor = System.Drawing.Color.Red;
                    break;
                case 2:
                    this.BackColor = System.Drawing.Color.Orange;
                    break;
                case 3:
                    this.BackColor = System.Drawing.Color.Yellow;
                    break;
                case 4:
                    this.BackColor = System.Drawing.Color.Green;
                    break;
                case 5:
                    this.BackColor = System.Drawing.Color.Blue;
                    break;
                case 6:
                    this.BackColor = System.Drawing.Color.Indigo;
                    break;
                default:
                    this.BackColor = System.Drawing.Color.White;
                    break;
            }
        }

        //have the user manually change the text on the screen
        private void codeInputText_TextChanged(object sender, EventArgs e)
        {
            //insert the real code in here :)
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //if the text is null
            if (string.IsNullOrEmpty(codeInputText.Text))
            {
                codeInputText.Text = "Changing the text required!";
            }
            //if the text is invalid
            else if (codeInputText.Text != " Our real code insert here")
            {
                codeInputText.Text = "I'm sorry that wasn't correct!";
            }
            //have it set to null
            else
            {
                codeInputText.Text = " ";
            }
        }
    }
}
