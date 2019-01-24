namespace TaxCalculatorWinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.incomeTextBox = new System.Windows.Forms.TextBox();
            this.addIncomeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.deductionTextBox = new System.Windows.Forms.TextBox();
            this.addDeductionButton = new System.Windows.Forms.Button();
            this.grossIncomeLabel = new System.Windows.Forms.Label();
            this.totalDeductionLabel = new System.Windows.Forms.Label();
            this.taxInfoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Income:";
            // 
            // incomeTextBox
            // 
            this.incomeTextBox.Location = new System.Drawing.Point(175, 68);
            this.incomeTextBox.Name = "incomeTextBox";
            this.incomeTextBox.Size = new System.Drawing.Size(100, 31);
            this.incomeTextBox.TabIndex = 1;
            // 
            // addIncomeButton
            // 
            this.addIncomeButton.Location = new System.Drawing.Point(292, 64);
            this.addIncomeButton.Name = "addIncomeButton";
            this.addIncomeButton.Size = new System.Drawing.Size(163, 38);
            this.addIncomeButton.TabIndex = 2;
            this.addIncomeButton.Text = "Add Income";
            this.addIncomeButton.UseVisualStyleBackColor = true;
            this.addIncomeButton.Click += new System.EventHandler(this.addIncomeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dedution:";
            // 
            // deductionTextBox
            // 
            this.deductionTextBox.Location = new System.Drawing.Point(174, 135);
            this.deductionTextBox.Name = "deductionTextBox";
            this.deductionTextBox.Size = new System.Drawing.Size(100, 31);
            this.deductionTextBox.TabIndex = 4;
            // 
            // addDeductionButton
            // 
            this.addDeductionButton.Location = new System.Drawing.Point(292, 135);
            this.addDeductionButton.Name = "addDeductionButton";
            this.addDeductionButton.Size = new System.Drawing.Size(175, 48);
            this.addDeductionButton.TabIndex = 5;
            this.addDeductionButton.Text = "Add Deduction";
            this.addDeductionButton.UseVisualStyleBackColor = true;
            this.addDeductionButton.Click += new System.EventHandler(this.addDeductionButton_Click);
            // 
            // grossIncomeLabel
            // 
            this.grossIncomeLabel.AutoSize = true;
            this.grossIncomeLabel.Location = new System.Drawing.Point(550, 64);
            this.grossIncomeLabel.Name = "grossIncomeLabel";
            this.grossIncomeLabel.Size = new System.Drawing.Size(150, 25);
            this.grossIncomeLabel.TabIndex = 6;
            this.grossIncomeLabel.Text = "Gross Income:";
            // 
            // totalDeductionLabel
            // 
            this.totalDeductionLabel.AutoSize = true;
            this.totalDeductionLabel.Location = new System.Drawing.Point(550, 141);
            this.totalDeductionLabel.Name = "totalDeductionLabel";
            this.totalDeductionLabel.Size = new System.Drawing.Size(186, 25);
            this.totalDeductionLabel.TabIndex = 7;
            this.totalDeductionLabel.Text = "Total Deductions: ";
            // 
            // taxInfoLabel
            // 
            this.taxInfoLabel.AutoSize = true;
            this.taxInfoLabel.Location = new System.Drawing.Point(205, 298);
            this.taxInfoLabel.Name = "taxInfoLabel";
            this.taxInfoLabel.Size = new System.Drawing.Size(89, 25);
            this.taxInfoLabel.TabIndex = 8;
            this.taxInfoLabel.Text = "Tax Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 689);
            this.Controls.Add(this.taxInfoLabel);
            this.Controls.Add(this.totalDeductionLabel);
            this.Controls.Add(this.grossIncomeLabel);
            this.Controls.Add(this.addDeductionButton);
            this.Controls.Add(this.deductionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addIncomeButton);
            this.Controls.Add(this.incomeTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox incomeTextBox;
        private System.Windows.Forms.Button addIncomeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox deductionTextBox;
        private System.Windows.Forms.Button addDeductionButton;
        private System.Windows.Forms.Label grossIncomeLabel;
        private System.Windows.Forms.Label totalDeductionLabel;
        private System.Windows.Forms.Label taxInfoLabel;
    }
}

