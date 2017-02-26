﻿namespace HelloWorldWH
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
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.codeInputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hintButton = new System.Windows.Forms.Button();
            this.userPrompt = new System.Windows.Forms.TextBox();
            this.promptLabel = new System.Windows.Forms.Label();
            this.colorChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.AliceBlue;
            this.submitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.submitButton.Location = new System.Drawing.Point(766, 805);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(153, 70);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.AliceBlue;
            this.clearButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.clearButton.Location = new System.Drawing.Point(44, 805);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(153, 70);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // codeInputText
            // 
            this.codeInputText.ForeColor = System.Drawing.Color.PaleGreen;
            this.codeInputText.Location = new System.Drawing.Point(44, 256);
            this.codeInputText.Name = "codeInputText";
            this.codeInputText.Size = new System.Drawing.Size(876, 506);
            this.codeInputText.TabIndex = 2;
            this.codeInputText.Text = "";
            this.codeInputText.TextChanged += new System.EventHandler(this.codeInputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.AliceBlue;
            this.label1.Location = new System.Drawing.Point(39, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Input Code:";
            // 
            // hintButton
            // 
            this.hintButton.BackColor = System.Drawing.Color.AliceBlue;
            this.hintButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hintButton.Location = new System.Drawing.Point(766, 91);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(153, 70);
            this.hintButton.TabIndex = 4;
            this.hintButton.Text = "Hint";
            this.hintButton.UseVisualStyleBackColor = false;
            // 
            // userPrompt
            // 
            this.userPrompt.Location = new System.Drawing.Point(44, 70);
            this.userPrompt.Multiline = true;
            this.userPrompt.Name = "userPrompt";
            this.userPrompt.ReadOnly = true;
            this.userPrompt.Size = new System.Drawing.Size(702, 109);
            this.userPrompt.TabIndex = 5;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.ForeColor = System.Drawing.Color.AliceBlue;
            this.promptLabel.Location = new System.Drawing.Point(39, 31);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(137, 25);
            this.promptLabel.TabIndex = 6;
            this.promptLabel.Text = "User Prompt:";
            // 
            // colorChangeButton
            // 
            this.colorChangeButton.BackColor = System.Drawing.Color.AliceBlue;
            this.colorChangeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.colorChangeButton.Location = new System.Drawing.Point(398, 805);
            this.colorChangeButton.Name = "colorChangeButton";
            this.colorChangeButton.Size = new System.Drawing.Size(153, 70);
            this.colorChangeButton.TabIndex = 7;
            this.colorChangeButton.Text = "Change Color";
            this.colorChangeButton.UseVisualStyleBackColor = false;
            this.colorChangeButton.Click += new System.EventHandler(this.colorChangeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(974, 930);
            this.Controls.Add(this.colorChangeButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.userPrompt);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeInputText);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Console Window";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RichTextBox codeInputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.TextBox userPrompt;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.Button colorChangeButton;
    }
}