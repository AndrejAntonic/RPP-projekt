﻿namespace AutoPrime.Forms
{
    partial class FrmKalkulatorDetails
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
            this.lblMethod = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAhead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblMethod.Location = new System.Drawing.Point(8, 6);
            this.lblMethod.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(17, 17);
            this.lblMethod.TabIndex = 0;
            this.lblMethod.Text = "a";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDescription.Location = new System.Drawing.Point(9, 27);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(35, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "label1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(456, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(31, 19);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAhead
            // 
            this.btnAhead.Location = new System.Drawing.Point(491, 4);
            this.btnAhead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAhead.Name = "btnAhead";
            this.btnAhead.Size = new System.Drawing.Size(31, 19);
            this.btnAhead.TabIndex = 3;
            this.btnAhead.Text = ">";
            this.btnAhead.UseVisualStyleBackColor = true;
            this.btnAhead.Click += new System.EventHandler(this.btnAhead_Click);
            // 
            // FrmKalkulatorDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 437);
            this.Controls.Add(this.btnAhead);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblMethod);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmKalkulatorDetails";
            this.Text = "Detaljni opis kalkulacija";
            this.Load += new System.EventHandler(this.FrmKalkulatorDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMethod;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAhead;
    }
}