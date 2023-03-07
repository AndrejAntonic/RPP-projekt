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
            this.btnGotovo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDodajSlike
            // 
            this.btnDodajSlike.Location = new System.Drawing.Point(108, 280);
            this.btnDodajSlike.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDodajSlike.Name = "btnDodajSlike";
            this.btnDodajSlike.Size = new System.Drawing.Size(182, 44);
            this.btnDodajSlike.TabIndex = 0;
            this.btnDodajSlike.Text = "Dodaj slike";
            this.btnDodajSlike.UseVisualStyleBackColor = true;
            this.btnDodajSlike.Click += new System.EventHandler(this.btnDodajSlike_Click);
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(9, 10);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(582, 257);
            this.pbSlika.TabIndex = 1;
            this.pbSlika.TabStop = false;
            // 
            // btnGotovo
            // 
            this.btnGotovo.Location = new System.Drawing.Point(341, 331);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(75, 23);
            this.btnGotovo.TabIndex = 2;
            this.btnGotovo.Text = "Gotovo";
            this.btnGotovo.UseVisualStyleBackColor = true;
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click);
            // 
            // FrmAddPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 366);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnDodajSlike);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmAddPictures";
            this.Text = "FrmAddPictures";
            this.Load += new System.EventHandler(this.FrmAddPictures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDodajSlike;
        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnGotovo;
    }
}