namespace lab_2_2_5_Stevenson
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
            this.showBack = new System.Windows.Forms.Button();
            this.faceCard = new System.Windows.Forms.PictureBox();
            this.backCard = new System.Windows.Forms.PictureBox();
            this.showFront = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.faceCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCard)).BeginInit();
            this.SuspendLayout();
            // 
            // showBack
            // 
            this.showBack.Location = new System.Drawing.Point(73, 282);
            this.showBack.Name = "showBack";
            this.showBack.Size = new System.Drawing.Size(92, 55);
            this.showBack.TabIndex = 1;
            this.showBack.Text = "Show the Card Back";
            this.showBack.UseVisualStyleBackColor = true;
            this.showBack.Click += new System.EventHandler(this.ShowBack_Click);
            // 
            // faceCard
            // 
            this.faceCard.Image = global::lab_2_2_5_Stevenson.Properties.Resources.download__3_;
            this.faceCard.Location = new System.Drawing.Point(119, 12);
            this.faceCard.Name = "faceCard";
            this.faceCard.Size = new System.Drawing.Size(187, 244);
            this.faceCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.faceCard.TabIndex = 2;
            this.faceCard.TabStop = false;
            // 
            // backCard
            // 
            this.backCard.Image = global::lab_2_2_5_Stevenson.Properties.Resources.download__2_;
            this.backCard.Location = new System.Drawing.Point(119, 12);
            this.backCard.Name = "backCard";
            this.backCard.Size = new System.Drawing.Size(187, 244);
            this.backCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backCard.TabIndex = 0;
            this.backCard.TabStop = false;
            // 
            // showFront
            // 
            this.showFront.Location = new System.Drawing.Point(285, 282);
            this.showFront.Name = "showFront";
            this.showFront.Size = new System.Drawing.Size(92, 55);
            this.showFront.TabIndex = 3;
            this.showFront.Text = "Show the Card Face";
            this.showFront.UseVisualStyleBackColor = true;
            this.showFront.Click += new System.EventHandler(this.ShowFront_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 393);
            this.Controls.Add(this.showFront);
            this.Controls.Add(this.faceCard);
            this.Controls.Add(this.showBack);
            this.Controls.Add(this.backCard);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.faceCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backCard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox backCard;
        private System.Windows.Forms.Button showBack;
        private System.Windows.Forms.PictureBox faceCard;
        private System.Windows.Forms.Button showFront;
    }
}

