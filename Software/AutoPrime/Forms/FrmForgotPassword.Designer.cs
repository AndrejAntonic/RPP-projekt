namespace AutoPrime.Forms
{
    partial class FrmForgotPassword
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
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.btnPromjeni = new System.Windows.Forms.Button();
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(100, 41);
            this.txtKorime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(126, 20);
            this.txtKorime.TabIndex = 1;
            // 
            // btnPromjeni
            // 
            this.btnPromjeni.Location = new System.Drawing.Point(107, 297);
            this.btnPromjeni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPromjeni.Name = "btnPromjeni";
            this.btnPromjeni.Size = new System.Drawing.Size(56, 19);
            this.btnPromjeni.TabIndex = 2;
            this.btnPromjeni.Text = "Promjeni";
            this.btnPromjeni.UseVisualStyleBackColor = true;
            this.btnPromjeni.Click += new System.EventHandler(this.btnPromjeni_Click);
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Location = new System.Drawing.Point(100, 184);
            this.txtLozinka1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.PasswordChar = '*';
            this.txtLozinka1.Size = new System.Drawing.Size(126, 20);
            this.txtLozinka1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 186);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nova lozinka:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Location = new System.Drawing.Point(100, 222);
            this.txtLozinka2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.PasswordChar = '*';
            this.txtLozinka2.Size = new System.Drawing.Size(126, 20);
            this.txtLozinka2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 224);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ponovi lozinku:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(168, 297);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(56, 19);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(100, 75);
            this.txtIme.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(126, 20);
            this.txtIme.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ime:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(100, 150);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(126, 20);
            this.txtTelefon.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Telefonski broj:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(100, 117);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(126, 20);
            this.txtPrezime.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Prezime:";
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 353);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtLozinka2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLozinka1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPromjeni);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmForgotPassword";
            this.Text = "FrmForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.Button btnPromjeni;
        private System.Windows.Forms.TextBox txtLozinka1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label6;
    }
}