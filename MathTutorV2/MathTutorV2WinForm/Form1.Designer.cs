namespace MathTutorV2WinForm
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
            this.radioButtonPlus = new System.Windows.Forms.RadioButton();
            this.radioButtonMinus = new System.Windows.Forms.RadioButton();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonPlus
            // 
            this.radioButtonPlus.AutoSize = true;
            this.radioButtonPlus.Location = new System.Drawing.Point(56, 45);
            this.radioButtonPlus.Name = "radioButtonPlus";
            this.radioButtonPlus.Size = new System.Drawing.Size(55, 29);
            this.radioButtonPlus.TabIndex = 0;
            this.radioButtonPlus.Text = "+";
            this.radioButtonPlus.UseVisualStyleBackColor = true;
            // 
            // radioButtonMinus
            // 
            this.radioButtonMinus.AutoSize = true;
            this.radioButtonMinus.Location = new System.Drawing.Point(136, 45);
            this.radioButtonMinus.Name = "radioButtonMinus";
            this.radioButtonMinus.Size = new System.Drawing.Size(50, 29);
            this.radioButtonMinus.TabIndex = 1;
            this.radioButtonMinus.Text = "-";
            this.radioButtonMinus.UseVisualStyleBackColor = true;
            this.radioButtonMinus.CheckedChanged += new System.EventHandler(this.radioButtonMinus_CheckedChanged);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(56, 127);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(0, 25);
            this.questionLabel.TabIndex = 2;
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(222, 120);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(100, 31);
            this.answerBox.TabIndex = 3;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(354, 120);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(203, 49);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Check Answer";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 268);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.radioButtonMinus);
            this.Controls.Add(this.radioButtonPlus);
            this.Name = "Form1";
            this.Text = "Math Tutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonPlus;
        private System.Windows.Forms.RadioButton radioButtonMinus;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Button submitButton;
    }
}

