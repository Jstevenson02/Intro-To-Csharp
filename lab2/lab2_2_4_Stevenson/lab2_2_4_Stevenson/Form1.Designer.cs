namespace lab2_2_4_Stevenson
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
            this.components = new System.ComponentModel.Container();
            this.frenchFlag = new System.Windows.Forms.PictureBox();
            this.germanFlag = new System.Windows.Forms.PictureBox();
            this.finnishFlag = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outputCountry = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.frenchFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanFlag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finnishFlag)).BeginInit();
            this.SuspendLayout();
            // 
            // frenchFlag
            // 
            this.frenchFlag.Image = global::lab2_2_4_Stevenson.Properties.Resources.download1;
            this.frenchFlag.Location = new System.Drawing.Point(533, 89);
            this.frenchFlag.Name = "frenchFlag";
            this.frenchFlag.Size = new System.Drawing.Size(208, 124);
            this.frenchFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.frenchFlag.TabIndex = 2;
            this.frenchFlag.TabStop = false;
            this.frenchFlag.Click += new System.EventHandler(this.FrenchFlag_Click);
            // 
            // germanFlag
            // 
            this.germanFlag.Image = global::lab2_2_4_Stevenson.Properties.Resources.download;
            this.germanFlag.Location = new System.Drawing.Point(291, 89);
            this.germanFlag.Name = "germanFlag";
            this.germanFlag.Size = new System.Drawing.Size(208, 124);
            this.germanFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.germanFlag.TabIndex = 1;
            this.germanFlag.TabStop = false;
            this.germanFlag.Click += new System.EventHandler(this.GermanFlag_Click);
            // 
            // finnishFlag
            // 
            this.finnishFlag.Image = global::lab2_2_4_Stevenson.Properties.Resources.download__1_;
            this.finnishFlag.Location = new System.Drawing.Point(51, 89);
            this.finnishFlag.Name = "finnishFlag";
            this.finnishFlag.Size = new System.Drawing.Size(208, 124);
            this.finnishFlag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.finnishFlag.TabIndex = 0;
            this.finnishFlag.TabStop = false;
            this.finnishFlag.Click += new System.EventHandler(this.FinnishFlag_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // outputCountry
            // 
            this.outputCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 29.25F);
            this.outputCountry.Location = new System.Drawing.Point(126, 304);
            this.outputCountry.Name = "outputCountry";
            this.outputCountry.Size = new System.Drawing.Size(500, 52);
            this.outputCountry.TabIndex = 4;
            this.outputCountry.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.outputCountry.TextChanged += new System.EventHandler(this.OutputCountry_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.Location = new System.Drawing.Point(159, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Click on a flag to see the name of the country.";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outputCountry);
            this.Controls.Add(this.frenchFlag);
            this.Controls.Add(this.germanFlag);
            this.Controls.Add(this.finnishFlag);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.frenchFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.germanFlag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finnishFlag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox finnishFlag;
        private System.Windows.Forms.PictureBox germanFlag;
        private System.Windows.Forms.PictureBox frenchFlag;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox outputCountry;
        private System.Windows.Forms.Label label1;
    }
}

