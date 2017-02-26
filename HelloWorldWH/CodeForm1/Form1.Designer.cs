namespace CodeForm1
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
            this.label1 = new System.Windows.Forms.Label();
            this.hintButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.promptLabel = new System.Windows.Forms.Label();
            this.inputCode = new System.Windows.Forms.RichTextBox();
            this.promptText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(788, 990);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(189, 76);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(75, 990);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(189, 76);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please input code:";
            // 
            // hintButton
            // 
            this.hintButton.Location = new System.Drawing.Point(788, 118);
            this.hintButton.Name = "hintButton";
            this.hintButton.Size = new System.Drawing.Size(189, 76);
            this.hintButton.TabIndex = 4;
            this.hintButton.Text = "Hint";
            this.hintButton.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(335, 957);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(385, 23);
            this.progressBar.TabIndex = 5;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // promptLabel
            // 
            this.promptLabel.AutoSize = true;
            this.promptLabel.Location = new System.Drawing.Point(74, 50);
            this.promptLabel.Name = "promptLabel";
            this.promptLabel.Size = new System.Drawing.Size(86, 25);
            this.promptLabel.TabIndex = 6;
            this.promptLabel.Text = "Prompt:";
            this.promptLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(75, 313);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(902, 612);
            this.inputCode.TabIndex = 8;
            this.inputCode.Text = "";
            this.inputCode.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // promptText
            // 
            this.promptText.Location = new System.Drawing.Point(79, 98);
            this.promptText.Name = "promptText";
            this.promptText.Size = new System.Drawing.Size(669, 135);
            this.promptText.TabIndex = 9;
            this.promptText.Text = "";
            this.promptText.TextChanged += new System.EventHandler(this.promptText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 1121);
            this.Controls.Add(this.promptText);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.promptLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.hintButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Console Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button hintButton;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label promptLabel;
        private System.Windows.Forms.RichTextBox inputCode;
        private System.Windows.Forms.RichTextBox promptText;
    }
}

