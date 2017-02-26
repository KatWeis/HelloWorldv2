using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeForm1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //this is acutally the submit button (rip what it's actually called)
        private void button1_Click(object sender, EventArgs e)
        {
            //if the length of the text is zero
            if (codeInputBox.Text == string.Empty)
            {
                //print an error message in that text box
                codeInputBox.Text = "Error: Please enter some text.";
            }

            //this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar_Click(object sender, EventArgs e)
        {

        }

        // This will clear all input in the Code Input Box
        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the code input box
            codeInputBox.Clear();
        }

        // This will allow the user to edit the text that is currently in the form 
        private void codeInputBox_TextChanged(object sender, EventArgs e)
        {
            //Have the using be able to chnage the KeyBoard Input
            codeInputBox.Text = "// Get the current keyboard state \n KeyboardState kbState = Keyboard.GetState(); \n //Never do this: \n KeyboardState kbState = new KeyboardState(); \n //Statement will be blank! \n //Check for the Right Key \n If(kbState.IsKeyDown(Keys.Right)) \n // Move the player right \n } \n } \n //Check for the Left Key \n If(kbState.IsKeyDown(Keys.Left)) \n { \n // Move the player left \n } ";
            
            //codeInputBox.Text = " I will teach you to code maybe";
            
            //saves input to a string
            string codeInput = codeInputBox.ToString();
        }

        //Give Some Instructions to the user
        private void promptView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Give Some Instructions to the user
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            promptTextBox.Text = "KEYBOARD (Right/Left) \n Check for left/right keyboard input. \n Get the current keyboard state: \n Use  KeyboardState kbState = Keyboard.GetState()";
        }
    }
}
