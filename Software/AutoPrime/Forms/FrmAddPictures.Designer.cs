namespace AutoPrime.Forms
{
    partial class FrmAddPictures
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
            this.btnDodajSlike = new System.Windows.Forms.Button();
            this.pbSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajSlike
            // 
            this.btnDodajSlike.Location = new System.Drawing.Point(144, 345);
            this.btnDodajSlike.Name = "btnDodajSlike";
            this.btnDodajSlike.Size = new System.Drawing.Size(243, 54);
            this.btnDodajSlike.TabIndex = 0;
            this.btnDodajSlike.Text = "Dodaj slike";
            this.btnDodajSlike.UseVisualStyleBackColor = true;
            this.btnDodajSlike.Click += new System.EventHandler(this.btnDodajSlike_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(12, 12);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(776, 316);
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // FrmAddPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnDodajSlike);
            this.Name = "FrmAddPictures";
            this.Text = "FrmAddPictures";
            this.Load += new System.EventHandler(this.FrmAddPictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajSlike;
        private System.Windows.Forms.PictureBox pbSlika;
    }
}