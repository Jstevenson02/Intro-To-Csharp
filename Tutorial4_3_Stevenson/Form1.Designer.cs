
namespace Tutorial4_3_Stevenson
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
            this.annualSalaryInput = new System.Windows.Forms.TextBox();
            this.yearsAtCurrentJob = new System.Windows.Forms.TextBox();
            this.loanDecisionOutput = new System.Windows.Forms.TextBox();
            this.checkQualifications = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // annualSalaryInput
            // 
            this.annualSalaryInput.Location = new System.Drawing.Point(224, 12);
            this.annualSalaryInput.Name = "annualSalaryInput";
            this.annualSalaryInput.Size = new System.Drawing.Size(100, 23);
            this.annualSalaryInput.TabIndex = 0;
            this.annualSalaryInput.TextChanged += new System.EventHandler(this.annualSalaryInput_TextChanged);
            // 
            // yearsAtCurrentJob
            // 
            this.yearsAtCurrentJob.Location = new System.Drawing.Point(224, 41);
            this.yearsAtCurrentJob.Name = "yearsAtCurrentJob";
            this.yearsAtCurrentJob.Size = new System.Drawing.Size(100, 23);
            this.yearsAtCurrentJob.TabIndex = 1;
            this.yearsAtCurrentJob.TextChanged += new System.EventHandler(this.yearsAtCurrentJob_TextChanged);
            // 
            // loanDecisionOutput
            // 
            this.loanDecisionOutput.Location = new System.Drawing.Point(12, 83);
            this.loanDecisionOutput.Name = "loanDecisionOutput";
            this.loanDecisionOutput.Size = new System.Drawing.Size(312, 23);
            this.loanDecisionOutput.TabIndex = 2;
            this.loanDecisionOutput.TextChanged += new System.EventHandler(this.loanDecisionOutput_TextChanged);
            // 
            // checkQualifications
            // 
            this.checkQualifications.Location = new System.Drawing.Point(12, 112);
            this.checkQualifications.Name = "checkQualifications";
            this.checkQualifications.Size = new System.Drawing.Size(97, 53);
            this.checkQualifications.TabIndex = 3;
            this.checkQualifications.Text = "Check Qualifications";
            this.checkQualifications.UseVisualStyleBackColor = true;
            this.checkQualifications.Click += new System.EventHandler(this.checkQualifications_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Annual Salary";
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(115, 112);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(110, 53);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(231, 112);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(93, 53);
            this.exit.TabIndex = 6;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Years at Current Job";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Loan Decision";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 177);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkQualifications);
            this.Controls.Add(this.loanDecisionOutput);
            this.Controls.Add(this.yearsAtCurrentJob);
            this.Controls.Add(this.annualSalaryInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox annualSalaryInput;
        private System.Windows.Forms.TextBox yearsAtCurrentJob;
        private System.Windows.Forms.TextBox loanDecisionOutput;
        private System.Windows.Forms.Button checkQualifications;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

