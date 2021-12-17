
namespace Tutorial4_4_Stevenson
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CalculateMpg = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.calculateMpgOutput = new System.Windows.Forms.TextBox();
            this.gallonsUsedInput = new System.Windows.Forms.TextBox();
            this.numberOfMilesDriven = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of miles driven:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the gallons of gas used:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Your car\'s MPG";
            // 
            // CalculateMpg
            // 
            this.CalculateMpg.Location = new System.Drawing.Point(32, 110);
            this.CalculateMpg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CalculateMpg.Name = "CalculateMpg";
            this.CalculateMpg.Size = new System.Drawing.Size(112, 45);
            this.CalculateMpg.TabIndex = 3;
            this.CalculateMpg.Text = "Calculate MPG";
            this.CalculateMpg.UseVisualStyleBackColor = true;
            this.CalculateMpg.Click += new System.EventHandler(this.CalculateMpg_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(166, 106);
            this.Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(112, 45);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // calculateMpgOutput
            // 
            this.calculateMpgOutput.Location = new System.Drawing.Point(215, 75);
            this.calculateMpgOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calculateMpgOutput.Name = "calculateMpgOutput";
            this.calculateMpgOutput.Size = new System.Drawing.Size(86, 23);
            this.calculateMpgOutput.TabIndex = 5;
            // 
            // gallonsUsedInput
            // 
            this.gallonsUsedInput.Location = new System.Drawing.Point(215, 48);
            this.gallonsUsedInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gallonsUsedInput.Name = "gallonsUsedInput";
            this.gallonsUsedInput.Size = new System.Drawing.Size(86, 23);
            this.gallonsUsedInput.TabIndex = 6;
            // 
            // numberOfMilesDriven
            // 
            this.numberOfMilesDriven.Location = new System.Drawing.Point(215, 16);
            this.numberOfMilesDriven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberOfMilesDriven.Name = "numberOfMilesDriven";
            this.numberOfMilesDriven.Size = new System.Drawing.Size(86, 23);
            this.numberOfMilesDriven.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 164);
            this.Controls.Add(this.numberOfMilesDriven);
            this.Controls.Add(this.gallonsUsedInput);
            this.Controls.Add(this.calculateMpgOutput);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CalculateMpg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalculateMpg;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox calculateMpgOutput;
        private System.Windows.Forms.TextBox gallonsUsedInput;
        private System.Windows.Forms.TextBox numberOfMilesDriven;
    }
}

