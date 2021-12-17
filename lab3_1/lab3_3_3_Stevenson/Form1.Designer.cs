
namespace lab3_3_3_Stevenson
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
            this.label4 = new System.Windows.Forms.Label();
            this.dayOfWeek = new System.Windows.Forms.TextBox();
            this.dayOfMonth = new System.Windows.Forms.TextBox();
            this.numericDayOfMonth = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.showDateOnClick = new System.Windows.Forms.Button();
            this.clearTextFieldsOnClick = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.finalOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the day of the week:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the numeric day of the month:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the year: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter the name of the month:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dayOfWeek
            // 
            this.dayOfWeek.Location = new System.Drawing.Point(219, 9);
            this.dayOfWeek.Name = "dayOfWeek";
            this.dayOfWeek.Size = new System.Drawing.Size(172, 23);
            this.dayOfWeek.TabIndex = 4;
            this.dayOfWeek.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dayOfMonth
            // 
            this.dayOfMonth.Location = new System.Drawing.Point(219, 43);
            this.dayOfMonth.Name = "dayOfMonth";
            this.dayOfMonth.Size = new System.Drawing.Size(172, 23);
            this.dayOfMonth.TabIndex = 5;
            // 
            // numericDayOfMonth
            // 
            this.numericDayOfMonth.Location = new System.Drawing.Point(219, 77);
            this.numericDayOfMonth.Name = "numericDayOfMonth";
            this.numericDayOfMonth.Size = new System.Drawing.Size(172, 23);
            this.numericDayOfMonth.TabIndex = 6;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(219, 106);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(172, 23);
            this.year.TabIndex = 7;
            // 
            // showDateOnClick
            // 
            this.showDateOnClick.Location = new System.Drawing.Point(12, 191);
            this.showDateOnClick.Name = "showDateOnClick";
            this.showDateOnClick.Size = new System.Drawing.Size(100, 23);
            this.showDateOnClick.TabIndex = 8;
            this.showDateOnClick.Text = "Show Date";
            this.showDateOnClick.UseVisualStyleBackColor = true;
            this.showDateOnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearTextFieldsOnClick
            // 
            this.clearTextFieldsOnClick.Location = new System.Drawing.Point(152, 191);
            this.clearTextFieldsOnClick.Name = "clearTextFieldsOnClick";
            this.clearTextFieldsOnClick.Size = new System.Drawing.Size(100, 23);
            this.clearTextFieldsOnClick.TabIndex = 9;
            this.clearTextFieldsOnClick.Text = "Clear";
            this.clearTextFieldsOnClick.UseVisualStyleBackColor = true;
            this.clearTextFieldsOnClick.Click += new System.EventHandler(this.button2_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(291, 191);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(100, 23);
            this.Exit.TabIndex = 10;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // finalOutput
            // 
            this.finalOutput.Location = new System.Drawing.Point(41, 152);
            this.finalOutput.Name = "finalOutput";
            this.finalOutput.Size = new System.Drawing.Size(324, 23);
            this.finalOutput.TabIndex = 11;
            this.finalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 241);
            this.Controls.Add(this.finalOutput);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.clearTextFieldsOnClick);
            this.Controls.Add(this.showDateOnClick);
            this.Controls.Add(this.year);
            this.Controls.Add(this.numericDayOfMonth);
            this.Controls.Add(this.dayOfMonth);
            this.Controls.Add(this.dayOfWeek);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dayOfWeek;
        private System.Windows.Forms.TextBox dayOfMonth;
        private System.Windows.Forms.TextBox numericDayOfMonth;
        private System.Windows.Forms.TextBox year;
        private System.Windows.Forms.Button showDateOnClick;
        private System.Windows.Forms.Button clearTextFieldsOnClick;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox finalOutput;
    }
}

