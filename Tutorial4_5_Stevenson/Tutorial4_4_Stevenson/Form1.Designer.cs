
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backToNormal = new System.Windows.Forms.RadioButton();
            this.white = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.yellow = new System.Windows.Forms.RadioButton();
            this.exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.backToNormal);
            this.groupBox1.Controls.Add(this.white);
            this.groupBox1.Controls.Add(this.red);
            this.groupBox1.Controls.Add(this.yellow);
            this.groupBox1.Location = new System.Drawing.Point(36, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 201);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select A Background Color";
            // 
            // backToNormal
            // 
            this.backToNormal.AutoSize = true;
            this.backToNormal.Location = new System.Drawing.Point(56, 134);
            this.backToNormal.Name = "backToNormal";
            this.backToNormal.Size = new System.Drawing.Size(133, 24);
            this.backToNormal.TabIndex = 6;
            this.backToNormal.TabStop = true;
            this.backToNormal.Text = "Back to Normal";
            this.backToNormal.UseVisualStyleBackColor = true;
            this.backToNormal.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // white
            // 
            this.white.AutoSize = true;
            this.white.Location = new System.Drawing.Point(56, 104);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(69, 24);
            this.white.TabIndex = 5;
            this.white.TabStop = true;
            this.white.Text = "White";
            this.white.UseVisualStyleBackColor = true;
            this.white.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.red.Location = new System.Drawing.Point(56, 74);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(56, 24);
            this.red.TabIndex = 4;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = true;
            this.red.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // yellow
            // 
            this.yellow.AutoSize = true;
            this.yellow.Location = new System.Drawing.Point(56, 44);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(73, 24);
            this.yellow.TabIndex = 3;
            this.yellow.TabStop = true;
            this.yellow.Text = "Yellow";
            this.yellow.UseVisualStyleBackColor = true;
            this.yellow.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(150, 263);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(142, 26);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 301);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton yellow;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton backToNormal;
        private System.Windows.Forms.RadioButton white;
        private System.Windows.Forms.RadioButton red;
    }
}

