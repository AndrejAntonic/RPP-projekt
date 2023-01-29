namespace AutoPrime.Forms
{
    partial class FrmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnZabLozinka = new System.Windows.Forms.Button();
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lozinka:";
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(160, 46);
            this.txtKorime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(192, 22);
            this.txtKorime.TabIndex = 2;
            this.txtKorime.TextChanged += new System.EventHandler(this.txtKorime_TextChanged);
            // 
            // txtLozinka
            // 
            this.txtLozinka.Location = new System.Drawing.Point(160, 112);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.PasswordChar = '*';
            this.txtLozinka.Size = new System.Drawing.Size(192, 22);
            this.txtLozinka.TabIndex = 3;
            this.txtLozinka.TextChanged += new System.EventHandler(this.txtLozinka_TextChanged);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(209, 212);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(75, 28);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijava";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnZabLozinka
            // 
            this.btnZabLozinka.Location = new System.Drawing.Point(39, 198);
            this.btnZabLozinka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZabLozinka.Name = "btnZabLozinka";
            this.btnZabLozinka.Size = new System.Drawing.Size(113, 42);
            this.btnZabLozinka.TabIndex = 6;
            this.btnZabLozinka.Text = "Zaboravljena lozinka";
            this.btnZabLozinka.UseVisualStyleBackColor = true;
            this.btnZabLozinka.Click += new System.EventHandler(this.btnZabLozinka_Click);
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.Location = new System.Drawing.Point(333, 212);
            this.btnRegistracija.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(95, 28);
            this.btnRegistracija.TabIndex = 7;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = true;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 261);
            this.Controls.Add(this.btnRegistracija);
            this.Controls.Add(this.btnZabLozinka);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmLogin_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnZabLozinka;
        private System.Windows.Forms.Button btnRegistracija;
    }
}