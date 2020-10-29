namespace pylesdn_Assignment06
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblPrime = new System.Windows.Forms.Label();
            this.lblNotPrime = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.nudUserInput = new System.Windows.Forms.NumericUpDown();
            this.lblResult = new System.Windows.Forms.Label();
            this.picSadCat = new System.Windows.Forms.PictureBox();
            this.picHappyCat = new System.Windows.Forms.PictureBox();
            this.lblAllPrimeNumbers = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nudUserInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSadCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappyCat)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(100, 103);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(120, 37);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check Number";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblPrime
            // 
            this.lblPrime.AutoSize = true;
            this.lblPrime.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrime.ForeColor = System.Drawing.Color.White;
            this.lblPrime.Location = new System.Drawing.Point(96, 186);
            this.lblPrime.Name = "lblPrime";
            this.lblPrime.Size = new System.Drawing.Size(236, 27);
            this.lblPrime.TabIndex = 1;
            this.lblPrime.Text = "The number is prime";
            this.lblPrime.Visible = false;
            // 
            // lblNotPrime
            // 
            this.lblNotPrime.AutoSize = true;
            this.lblNotPrime.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotPrime.ForeColor = System.Drawing.Color.White;
            this.lblNotPrime.Location = new System.Drawing.Point(95, 186);
            this.lblNotPrime.Name = "lblNotPrime";
            this.lblNotPrime.Size = new System.Drawing.Size(281, 27);
            this.lblNotPrime.TabIndex = 3;
            this.lblNotPrime.Text = "The number is not prime";
            this.lblNotPrime.Visible = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(97, 45);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(255, 19);
            this.lblInstructions.TabIndex = 4;
            this.lblInstructions.Text = "Enter a number to check if it is prime";
            // 
            // nudUserInput
            // 
            this.nudUserInput.Location = new System.Drawing.Point(100, 77);
            this.nudUserInput.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudUserInput.Name = "nudUserInput";
            this.nudUserInput.Size = new System.Drawing.Size(120, 20);
            this.nudUserInput.TabIndex = 5;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(97, 152);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(47, 13);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "Result:";
            // 
            // picSadCat
            // 
            this.picSadCat.Image = global::pylesdn_Assignment06.Properties.Resources.sadcat;
            this.picSadCat.Location = new System.Drawing.Point(100, 249);
            this.picSadCat.Name = "picSadCat";
            this.picSadCat.Size = new System.Drawing.Size(55, 71);
            this.picSadCat.TabIndex = 8;
            this.picSadCat.TabStop = false;
            this.picSadCat.Visible = false;
            // 
            // picHappyCat
            // 
            this.picHappyCat.Image = global::pylesdn_Assignment06.Properties.Resources.happycat;
            this.picHappyCat.Location = new System.Drawing.Point(100, 249);
            this.picHappyCat.Name = "picHappyCat";
            this.picHappyCat.Size = new System.Drawing.Size(66, 71);
            this.picHappyCat.TabIndex = 7;
            this.picHappyCat.TabStop = false;
            this.picHappyCat.Visible = false;
            // 
            // lblAllPrimeNumbers
            // 
            this.lblAllPrimeNumbers.AutoSize = true;
            this.lblAllPrimeNumbers.Location = new System.Drawing.Point(490, 77);
            this.lblAllPrimeNumbers.Name = "lblAllPrimeNumbers";
            this.lblAllPrimeNumbers.Size = new System.Drawing.Size(92, 13);
            this.lblAllPrimeNumbers.TabIndex = 9;
            this.lblAllPrimeNumbers.TabStop = true;
            this.lblAllPrimeNumbers.Text = "All Prime Numbers";
            this.lblAllPrimeNumbers.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAllPrimeNumbers_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAllPrimeNumbers);
            this.Controls.Add(this.picSadCat);
            this.Controls.Add(this.picHappyCat);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.nudUserInput);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.lblNotPrime);
            this.Controls.Add(this.lblPrime);
            this.Controls.Add(this.btnCheck);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudUserInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSadCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHappyCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPrime;
        private System.Windows.Forms.Label lblNotPrime;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.NumericUpDown nudUserInput;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.PictureBox picHappyCat;
        private System.Windows.Forms.PictureBox picSadCat;
        private System.Windows.Forms.LinkLabel lblAllPrimeNumbers;
    }
}

