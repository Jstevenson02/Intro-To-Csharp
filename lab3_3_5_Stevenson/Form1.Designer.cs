
namespace lab3_3_5_Stevenson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fivecent = new System.Windows.Forms.PictureBox();
            this.tencent = new System.Windows.Forms.PictureBox();
            this.twentyfivecent = new System.Windows.Forms.PictureBox();
            this.fiftycent = new System.Windows.Forms.PictureBox();
            this.clickcoin = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.changeCounted = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fivecent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tencent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyfivecent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftycent)).BeginInit();
            this.SuspendLayout();
            // 
            // fivecent
            // 
            this.fivecent.Image = global::lab3_3_5_Stevenson.Properties.Resources._5_cents_coin_united_states_dollar_nickel_reverse_1;
            this.fivecent.Location = new System.Drawing.Point(28, 78);
            this.fivecent.Name = "fivecent";
            this.fivecent.Size = new System.Drawing.Size(172, 169);
            this.fivecent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fivecent.TabIndex = 0;
            this.fivecent.TabStop = false;
            this.fivecent.Click += new System.EventHandler(this.fivecent_Click);
            // 
            // tencent
            // 
            this.tencent.Image = ((System.Drawing.Image)(resources.GetObject("tencent.Image")));
            this.tencent.Location = new System.Drawing.Point(28, 269);
            this.tencent.Name = "tencent";
            this.tencent.Size = new System.Drawing.Size(172, 169);
            this.tencent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tencent.TabIndex = 1;
            this.tencent.TabStop = false;
            this.tencent.Click += new System.EventHandler(this.tencent_Click);
            // 
            // twentyfivecent
            // 
            this.twentyfivecent.Image = ((System.Drawing.Image)(resources.GetObject("twentyfivecent.Image")));
            this.twentyfivecent.Location = new System.Drawing.Point(206, 78);
            this.twentyfivecent.Name = "twentyfivecent";
            this.twentyfivecent.Size = new System.Drawing.Size(172, 169);
            this.twentyfivecent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.twentyfivecent.TabIndex = 2;
            this.twentyfivecent.TabStop = false;
            this.twentyfivecent.Click += new System.EventHandler(this.twentyfivecent_Click);
            // 
            // fiftycent
            // 
            this.fiftycent.Image = ((System.Drawing.Image)(resources.GetObject("fiftycent.Image")));
            this.fiftycent.Location = new System.Drawing.Point(206, 269);
            this.fiftycent.Name = "fiftycent";
            this.fiftycent.Size = new System.Drawing.Size(172, 169);
            this.fiftycent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fiftycent.TabIndex = 3;
            this.fiftycent.TabStop = false;
            this.fiftycent.Click += new System.EventHandler(this.fiftycent_Click);
            // 
            // clickcoin
            // 
            this.clickcoin.AutoSize = true;
            this.clickcoin.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clickcoin.Location = new System.Drawing.Point(100, 9);
            this.clickcoin.Name = "clickcoin";
            this.clickcoin.Size = new System.Drawing.Size(198, 46);
            this.clickcoin.TabIndex = 4;
            this.clickcoin.Text = "Click A Coin";
            this.clickcoin.Click += new System.EventHandler(this.clickcoin_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total.Location = new System.Drawing.Point(419, 139);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(92, 46);
            this.total.TabIndex = 5;
            this.total.Text = "Total";
            // 
            // changeCounted
            // 
            this.changeCounted.Location = new System.Drawing.Point(411, 197);
            this.changeCounted.Name = "changeCounted";
            this.changeCounted.Size = new System.Drawing.Size(100, 23);
            this.changeCounted.TabIndex = 6;
            this.changeCounted.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 450);
            this.Controls.Add(this.changeCounted);
            this.Controls.Add(this.total);
            this.Controls.Add(this.clickcoin);
            this.Controls.Add(this.fiftycent);
            this.Controls.Add(this.twentyfivecent);
            this.Controls.Add(this.tencent);
            this.Controls.Add(this.fivecent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fivecent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tencent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.twentyfivecent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiftycent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox fivecent;
        private System.Windows.Forms.PictureBox tencent;
        private System.Windows.Forms.PictureBox twentyfivecent;
        private System.Windows.Forms.PictureBox fiftycent;
        private System.Windows.Forms.Label clickcoin;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.TextBox changeCounted;
    }
}

