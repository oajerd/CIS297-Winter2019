namespace HelloWorldWinForms
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
            this.column1Button = new System.Windows.Forms.Button();
            this.column2Button = new System.Windows.Forms.Button();
            this.column3Button = new System.Windows.Forms.Button();
            this.column4Button = new System.Windows.Forms.Button();
            this.column5Button = new System.Windows.Forms.Button();
            this.column6Button = new System.Windows.Forms.Button();
            this.column7Button = new System.Windows.Forms.Button();
            this.whosTurnLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // column1Button
            // 
            this.column1Button.Location = new System.Drawing.Point(12, 12);
            this.column1Button.Name = "column1Button";
            this.column1Button.Size = new System.Drawing.Size(150, 59);
            this.column1Button.TabIndex = 0;
            this.column1Button.Text = "Drop Piece";
            this.column1Button.UseVisualStyleBackColor = true;
            this.column1Button.Click += new System.EventHandler(this.columnButton_Click);
            // 
            // column2Button
            // 
            this.column2Button.Location = new System.Drawing.Point(168, 12);
            this.column2Button.Name = "column2Button";
            this.column2Button.Size = new System.Drawing.Size(150, 59);
            this.column2Button.TabIndex = 1;
            this.column2Button.Text = "Drop Piece";
            this.column2Button.UseVisualStyleBackColor = true;
            this.column2Button.Click += new System.EventHandler(this.columnButton_Click);
            // 
            // column3Button
            // 
            this.column3Button.Location = new System.Drawing.Point(324, 12);
            this.column3Button.Name = "column3Button";
            this.column3Button.Size = new System.Drawing.Size(150, 59);
            this.column3Button.TabIndex = 2;
            this.column3Button.Text = "Drop Piece";
            this.column3Button.UseVisualStyleBackColor = true;
            this.column3Button.Click += new System.EventHandler(this.columnButton_Click);
            // 
            // column4Button
            // 
            this.column4Button.Location = new System.Drawing.Point(480, 12);
            this.column4Button.Name = "column4Button";
            this.column4Button.Size = new System.Drawing.Size(150, 59);
            this.column4Button.TabIndex = 3;
            this.column4Button.Text = "Drop Piece";
            this.column4Button.UseVisualStyleBackColor = true;
            this.column4Button.Click += new System.EventHandler(this.columnButton_Click);
            // 
            // column5Button
            // 
            this.column5Button.Location = new System.Drawing.Point(636, 12);
            this.column5Button.Name = "column5Button";
            this.column5Button.Size = new System.Drawing.Size(150, 59);
            this.column5Button.TabIndex = 4;
            this.column5Button.Text = "Drop Piece";
            this.column5Button.UseVisualStyleBackColor = true;
            this.column5Button.Click += new System.EventHandler(this.columnButton_Click);
            // 
            // column6Button
            // 
            this.column6Button.Location = new System.Drawing.Point(792, 12);
            this.column6Button.Name = "column6Button";
            this.column6Button.Size = new System.Drawing.Size(150, 59);
            this.column6Button.TabIndex = 5;
            this.column6Button.Text = "Drop Piece";
            this.column6Button.UseVisualStyleBackColor = true;
            this.column6Button.Click += new System.EventHandler(this.columnButton_Click);
            // 
            // column7Button
            // 
            this.column7Button.Location = new System.Drawing.Point(948, 12);
            this.column7Button.Name = "column7Button";
            this.column7Button.Size = new System.Drawing.Size(150, 59);
            this.column7Button.TabIndex = 6;
            this.column7Button.Text = "Drop Piece";
            this.column7Button.UseVisualStyleBackColor = true;
            this.column7Button.Click += new System.EventHandler(this.columnButton_Click);
            // 
            // whosTurnLabel
            // 
            this.whosTurnLabel.AutoSize = true;
            this.whosTurnLabel.Location = new System.Drawing.Point(480, 880);
            this.whosTurnLabel.Name = "whosTurnLabel";
            this.whosTurnLabel.Size = new System.Drawing.Size(120, 25);
            this.whosTurnLabel.TabIndex = 7;
            this.whosTurnLabel.Text = "Blue\'s Turn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 948);
            this.Controls.Add(this.whosTurnLabel);
            this.Controls.Add(this.column7Button);
            this.Controls.Add(this.column6Button);
            this.Controls.Add(this.column5Button);
            this.Controls.Add(this.column4Button);
            this.Controls.Add(this.column3Button);
            this.Controls.Add(this.column2Button);
            this.Controls.Add(this.column1Button);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button column1Button;
        private System.Windows.Forms.Button column2Button;
        private System.Windows.Forms.Button column3Button;
        private System.Windows.Forms.Button column4Button;
        private System.Windows.Forms.Button column5Button;
        private System.Windows.Forms.Button column6Button;
        private System.Windows.Forms.Button column7Button;
        private System.Windows.Forms.Label whosTurnLabel;
    }
}

