
namespace lab3_3_4_Stevenson
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
            this.avg = new System.Windows.Forms.TextBox();
            this.exit = new System.Windows.Forms.Button();
            this.clearclick = new System.Windows.Forms.Button();
            this.avgclick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // test1
            // 
            this.test1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test1.Location = new System.Drawing.Point(433, 52);
            this.test1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test1.Name = "test1";
            this.test1.Size = new System.Drawing.Size(263, 74);
            this.test1.TabIndex = 0;
            this.test1.TextChanged += new System.EventHandler(this.test1_TextChanged);
            // 
            // test2
            // 
            this.test2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test2.Location = new System.Drawing.Point(433, 167);
            this.test2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(263, 74);
            this.test2.TabIndex = 1;
            // 
            // test3
            // 
            this.test3.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.test3.Location = new System.Drawing.Point(433, 285);
            this.test3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.test3.Name = "test3";
            this.test3.Size = new System.Drawing.Size(263, 74);
            this.test3.TabIndex = 2;
            // 
            // avg
            // 
            this.avg.Location = new System.Drawing.Point(469, 420);
            this.avg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avg.Name = "avg";
            this.avg.Size = new System.Drawing.Size(44, 31);
            this.avg.TabIndex = 3;
            this.avg.TextChanged += new System.EventHandler(this.avg_TextChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(521, 587);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(221, 143);
            this.exit.TabIndex = 4;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearclick
            // 
            this.clearclick.Location = new System.Drawing.Point(274, 587);
            this.clearclick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearclick.Name = "clearclick";
            this.clearclick.Size = new System.Drawing.Size(221, 143);
            this.clearclick.TabIndex = 5;
            this.clearclick.Text = "clear";
            this.clearclick.UseVisualStyleBackColor = true;
            this.clearclick.Click += new System.EventHandler(this.clearclick_Click);
            // 
            // avgclick
            // 
            this.avgclick.Location = new System.Drawing.Point(17, 587);
            this.avgclick.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.avgclick.Name = "avgclick";
            this.avgclick.Size = new System.Drawing.Size(221, 143);
            this.avgclick.TabIndex = 6;
            this.avgclick.Text = "average";
            this.avgclick.UseVisualStyleBackColor = true;
            this.avgclick.Click += new System.EventHandler(this.avgclick_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Test 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Test 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Test 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 425);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 750);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.avgclick);
            this.Controls.Add(this.clearclick);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.avg);
            this.Controls.Add(this.test3);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.test1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox test1;
        private System.Windows.Forms.TextBox test2;
        private System.Windows.Forms.TextBox test3;
        private System.Windows.Forms.TextBox avg;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button clearclick;
        private System.Windows.Forms.Button avgclick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

