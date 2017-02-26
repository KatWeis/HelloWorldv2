namespace HelloWorldWH
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
            this.submitButton.Location = new System.Drawing.Point(511, 515);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(102, 45);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(29, 515);
            this.clearButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(102, 45);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // codeInputText
            // 
            this.codeInputText.Location = new System.Drawing.Point(29, 164);
            this.codeInputText.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.codeInputText.Name = "codeInputText";
            this.codeInputText.Size = new System.Drawing.Size(585, 325);
            this.codeInputText.TabIndex = 2;
            this.codeInputText.Text = "";
            this.codeInputText.TextChanged += new System.EventHandler(this.codeInputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Input Code:";
            // 
            // hintButton
            // 
            this.hintButton.Location = new System.Drawing.Point(511, 58);
            this.hintButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(102, 45);
            this.hintButton.TabIndex = 4;
            this.hintButton.Text = "Hint";
            this.hintButton.UseVisualStyleBackColor = true;
            // 
            // userPrompt
            // 
            this.userPrompt.Location = new System.Drawing.Point(29, 45);
            this.userPrompt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userPrompt.Multiline = true;
            this.userPrompt.Name = "userPrompt";
            this.userPrompt.ReadOnly = true;
            this.userPrompt.Size = new System.Drawing.Size(469, 71);
            this.userPrompt.TabIndex = 5;
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(26, 20);
            this.promptLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(91, 17);
            this.promptLabel.TabIndex = 6;
            this.promptLabel.Text = "User Prompt:";
            // 
            // colorChangeButton
            // 
            this.colorChangeButton.Location = new System.Drawing.Point(265, 515);
            this.colorChangeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.colorChangeButton.Name = "colorChangeButton";
            this.colorChangeButton.Size = new System.Drawing.Size(102, 45);
            this.colorChangeButton.TabIndex = 7;
            this.colorChangeButton.Text = "Change Color";
            this.colorChangeButton.UseVisualStyleBackColor = true;
            this.colorChangeButton.Click += new System.EventHandler(this.colorChangeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 595);
            this.Controls.Add(this.colorChangeButton);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.userPrompt);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.codeInputText);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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