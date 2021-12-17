
namespace lab4_1_Stevenson
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
            this.test1 = new System.Windows.Forms.TextBox();
            this.test2 = new System.Windows.Forms.TextBox();
            this.test3 = new System.Windows.Forms.TextBox();
            this.AverageForTests = new System.Windows.Forms.TextBox();
            this.ClearFields = new System.Windows.Forms.Button();
            this.ExitProgram = new System.Windows.Forms.Button();
            this.CalculateAverage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // test1
            // 
            this.test1.Location = new System.Drawing.Point(133, 23);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(157, 23);
            this.test1.TabIndex = 0;
            this.test1.TextChanged += new System.EventHandler(this.test1_TextChanged);
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(133, 69);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(157, 23);
            this.test2.TabIndex = 1;
            this.test2.TextChanged += new System.EventHandler(this.test2_TextChanged);
            // 
            // test3
            // 
            this.test3.Location = new System.Drawing.Point(133, 118);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(157, 23);
            this.test3.TabIndex = 2;
            this.test3.TextChanged += new System.EventHandler(this.test3_TextChanged);
            // 
            // AverageForTests
            // 
            this.AverageForTests.Location = new System.Drawing.Point(133, 165);
            this.AverageForTests.Name = "AverageForTests";
            this.AverageForTests.Size = new System.Drawing.Size(121, 23);
            this.AverageForTests.TabIndex = 3;
            this.AverageForTests.TextChanged += new System.EventHandler(this.AverageForTests_TextChanged);
            // 
            // ClearFields
            // 
            this.ClearFields.Location = new System.Drawing.Point(159, 220);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(95, 40);
            this.ClearFields.TabIndex = 4;
            this.ClearFields.Text = "Clear";
            this.ClearFields.UseVisualStyleBackColor = true;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // ExitProgram
            // 
            this.ExitProgram.Location = new System.Drawing.Point(159, 277);
            this.ExitProgram.Name = "ExitProgram";
            this.ExitProgram.Size = new System.Drawing.Size(95, 40);
            this.ExitProgram.TabIndex = 5;
            this.ExitProgram.Text = "Exit";
            this.ExitProgram.UseVisualStyleBackColor = true;
            this.ExitProgram.Click += new System.EventHandler(this.ExitProgram_Click);
            // 
            // CalculateAverage
            // 
            this.CalculateAverage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateAverage.Location = new System.Drawing.Point(41, 220);
            this.CalculateAverage.Name = "CalculateAverage";
            this.CalculateAverage.Size = new System.Drawing.Size(112, 98);
            this.CalculateAverage.TabIndex = 6;
            this.CalculateAverage.Text = "Calculate Average";
            this.CalculateAverage.UseVisualStyleBackColor = true;
            this.CalculateAverage.Click += new System.EventHandler(this.CalculateAverage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test Score 1#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test Score 2#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Test Score 3#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 329);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalculateAverage);
            this.Controls.Add(this.ExitProgram);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.AverageForTests);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox test1;
        private System.Windows.Forms.TextBox test2;
        private System.Windows.Forms.TextBox test3;
        private System.Windows.Forms.TextBox AverageForTests;
        private System.Windows.Forms.Button ClearFields;
        private System.Windows.Forms.Button ExitProgram;
        private System.Windows.Forms.Button CalculateAverage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

