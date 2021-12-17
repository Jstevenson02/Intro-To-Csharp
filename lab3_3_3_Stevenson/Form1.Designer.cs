
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
            this.calcualteSalePrice = new System.Windows.Forms.Button();
            this.exitProgram = new System.Windows.Forms.Button();
            this.originalPrice = new System.Windows.Forms.TextBox();
            this.discountPercentage = new System.Windows.Forms.TextBox();
            this.salePrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the item\'s original price: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the discount percentage: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sale price:";
            // 
            // calcualteSalePrice
            // 
            this.calcualteSalePrice.Location = new System.Drawing.Point(38, 119);
            this.calcualteSalePrice.Name = "calcualteSalePrice";
            this.calcualteSalePrice.Size = new System.Drawing.Size(95, 47);
            this.calcualteSalePrice.TabIndex = 3;
            this.calcualteSalePrice.Text = "Calculate Sale Price";
            this.calcualteSalePrice.UseVisualStyleBackColor = true;
            this.calcualteSalePrice.Click += new System.EventHandler(this.calcualteSalePrice_Click);
            // 
            // exitProgram
            // 
            this.exitProgram.Location = new System.Drawing.Point(158, 119);
            this.exitProgram.Name = "exitProgram";
            this.exitProgram.Size = new System.Drawing.Size(95, 47);
            this.exitProgram.TabIndex = 4;
            this.exitProgram.Text = "Exit";
            this.exitProgram.UseVisualStyleBackColor = true;
            this.exitProgram.Click += new System.EventHandler(this.exitProgram_Click);
            // 
            // originalPrice
            // 
            this.originalPrice.Location = new System.Drawing.Point(199, 6);
            this.originalPrice.Name = "originalPrice";
            this.originalPrice.Size = new System.Drawing.Size(76, 23);
            this.originalPrice.TabIndex = 5;
            this.originalPrice.TextChanged += new System.EventHandler(this.originalPrice_TextChanged);
            // 
            // discountPercentage
            // 
            this.discountPercentage.Location = new System.Drawing.Point(199, 40);
            this.discountPercentage.Name = "discountPercentage";
            this.discountPercentage.Size = new System.Drawing.Size(76, 23);
            this.discountPercentage.TabIndex = 6;
            this.discountPercentage.TextChanged += new System.EventHandler(this.discountPercentage_TextChanged);
            // 
            // salePrice
            // 
            this.salePrice.Location = new System.Drawing.Point(199, 70);
            this.salePrice.Name = "salePrice";
            this.salePrice.Size = new System.Drawing.Size(76, 23);
            this.salePrice.TabIndex = 7;
            this.salePrice.TextChanged += new System.EventHandler(this.salePrice_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 178);
            this.Controls.Add(this.salePrice);
            this.Controls.Add(this.discountPercentage);
            this.Controls.Add(this.originalPrice);
            this.Controls.Add(this.exitProgram);
            this.Controls.Add(this.calcualteSalePrice);
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
        private System.Windows.Forms.Button calcualteSalePrice;
        private System.Windows.Forms.Button exitProgram;
        private System.Windows.Forms.TextBox originalPrice;
        private System.Windows.Forms.TextBox discountPercentage;
        private System.Windows.Forms.TextBox salePrice;
    }
}

