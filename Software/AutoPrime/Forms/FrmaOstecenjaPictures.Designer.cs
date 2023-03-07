namespace AutoPrime.Forms
{
    partial class FrmaOstecenjaPictures
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
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.btnDodajSlike = new System.Windows.Forms.Button();
            this.txtOpisOstecenja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.Location = new System.Drawing.Point(11, 11);
            this.pbSlika.Margin = new System.Windows.Forms.Padding(2);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(582, 257);
            this.pbSlika.TabIndex = 3;
            this.pbSlika.TabStop = false;
            // 
            // btnDodajSlike
            // 
            this.btnDodajSlike.Location = new System.Drawing.Point(168, 381);
            this.btnDodajSlike.Margin = new System.Windows.Forms.Padding(2);
            this.btnDodajSlike.Name = "btnDodajSlike";
            this.btnDodajSlike.Size = new System.Drawing.Size(182, 44);
            this.btnDodajSlike.TabIndex = 2;
            this.btnDodajSlike.Text = "Dodaj slike oštećenja";
            this.btnDodajSlike.UseVisualStyleBackColor = true;
            this.btnDodajSlike.Click += new System.EventHandler(this.btnDodajSlike_Click);
            // 
            // txtOpisOstecenja
            // 
            this.txtOpisOstecenja.Location = new System.Drawing.Point(146, 306);
            this.txtOpisOstecenja.Name = "txtOpisOstecenja";
            this.txtOpisOstecenja.Size = new System.Drawing.Size(290, 20);
            this.txtOpisOstecenja.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Testni opis ostecenja:";
            // 
            // FrmaOstecenjaPictures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 436);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpisOstecenja);
            this.Controls.Add(this.pbSlika);
            this.Controls.Add(this.btnDodajSlike);
            this.Name = "FrmaOstecenjaPictures";
            this.Text = "FrmaOstecenjaPictures";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button btnDodajSlike;
        private System.Windows.Forms.TextBox txtOpisOstecenja;
        private System.Windows.Forms.Label label1;
    }
}