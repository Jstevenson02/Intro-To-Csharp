
namespace lab4_4_2_Stevenson
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
            this.hoursWorkedOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hourlyPayOutput = new System.Windows.Forms.TextBox();
            this.grossPayOutput = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hoursWorkedOutput
            // 
            this.hoursWorkedOutput.Location = new System.Drawing.Point(212, 33);
            this.hoursWorkedOutput.Name = "hoursWorkedOutput";
            this.hoursWorkedOutput.Size = new System.Drawing.Size(174, 27);
            this.hoursWorkedOutput.TabIndex = 0;
            this.hoursWorkedOutput.TextChanged += new System.EventHandler(this.hoursWorkedOutput_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hours Worked:";
            // 
            // hourlyPayOutput
            // 
            this.hourlyPayOutput.Location = new System.Drawing.Point(212, 82);
            this.hourlyPayOutput.Name = "hourlyPayOutput";
            this.hourlyPayOutput.Size = new System.Drawing.Size(174, 27);
            this.hourlyPayOutput.TabIndex = 3;
            this.hourlyPayOutput.TextChanged += new System.EventHandler(this.hourlyPayOutput_TextChanged);
            // 
            // grossPayOutput
            // 
            this.grossPayOutput.Location = new System.Drawing.Point(212, 131);
            this.grossPayOutput.Name = "grossPayOutput";
            this.grossPayOutput.Size = new System.Drawing.Size(174, 27);
            this.grossPayOutput.TabIndex = 4;
            this.grossPayOutput.TextChanged += new System.EventHandler(this.grossPayOutput_TextChanged);
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(26, 183);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(116, 54);
            this.calculate.TabIndex = 6;
            this.calculate.Text = "Calculate Gross Pay";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(148, 183);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(116, 54);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(270, 183);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(116, 54);
            this.exit.TabIndex = 8;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hourly Pay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Gross Pay:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.grossPayOutput);
            this.Controls.Add(this.hourlyPayOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hoursWorkedOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hoursWorkedOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox hourlyPayOutput;
        private System.Windows.Forms.TextBox grossPayOutput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

