﻿namespace AutoPrime.Forms
{
    partial class FrmShowDamage
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
            this.txtOpisOstecenja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.pbOstecenja = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOstecenja)).BeginInit();
            this.SuspendLayout();
            // 
            // txtOpisOstecenja
            // 
            this.txtOpisOstecenja.Location = new System.Drawing.Point(42, 434);
            this.txtOpisOstecenja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOpisOstecenja.Name = "txtOpisOstecenja";
            this.txtOpisOstecenja.Size = new System.Drawing.Size(550, 20);
            this.txtOpisOstecenja.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 436);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Opis:";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(519, 483);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(72, 24);
            this.btnZatvori.TabIndex = 3;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // pbOstecenja
            // 
            this.pbOstecenja.Location = new System.Drawing.Point(9, 10);
            this.pbOstecenja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbOstecenja.Name = "pbOstecenja";
            this.pbOstecenja.Size = new System.Drawing.Size(582, 402);
            this.pbOstecenja.TabIndex = 4;
            this.pbOstecenja.TabStop = false;
            // 
            // FrmShowDamage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 517);
            this.Controls.Add(this.pbOstecenja);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpisOstecenja);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmShowDamage";
            this.Text = "Oštećenja na automobilu";
            this.Load += new System.EventHandler(this.FrmShowDamage_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmShowDamage_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.pbOstecenja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOpisOstecenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.PictureBox pbOstecenja;
    }
}