namespace AutoPrime.Forms
{
    partial class FrmRegistration
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
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnRegistriraj = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKorime = new System.Windows.Forms.TextBox();
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGrad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(160, 45);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(181, 22);
            this.txtIme.TabIndex = 2;
            // 
            // btnRegistriraj
            // 
            this.btnRegistriraj.Location = new System.Drawing.Point(255, 509);
            this.btnRegistriraj.Name = "btnRegistriraj";
            this.btnRegistriraj.Size = new System.Drawing.Size(86, 30);
            this.btnRegistriraj.TabIndex = 3;
            this.btnRegistriraj.Text = "Registriraj";
            this.btnRegistriraj.UseVisualStyleBackColor = true;
            this.btnRegistriraj.Click += new System.EventHandler(this.btnRegistriraj_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Location = new System.Drawing.Point(60, 509);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(86, 42);
            this.btnPrijava.TabIndex = 7;
            this.btnPrijava.Text = "Idi na prijavu";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(160, 102);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(181, 22);
            this.txtPrezime.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prezime:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(160, 160);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 22);
            this.txtEmail.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Email:";
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(160, 332);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(181, 22);
            this.txtKorime.TabIndex = 13;
            this.txtKorime.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Location = new System.Drawing.Point(160, 392);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.Size = new System.Drawing.Size(181, 22);
            this.txtLozinka1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Lozinka:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Location = new System.Drawing.Point(160, 447);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.Size = new System.Drawing.Size(181, 22);
            this.txtLozinka2.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ponovi lozinku:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Korisničko ime:";
            // 
            // txtGrad
            // 
            this.txtGrad.Location = new System.Drawing.Point(160, 217);
            this.txtGrad.Name = "txtGrad";
            this.txtGrad.Size = new System.Drawing.Size(181, 22);
            this.txtGrad.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Grad:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(160, 275);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(181, 22);
            this.txtTelefon.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Broj telefona:";
            // 
            // FrmRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 589);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtGrad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLozinka2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLozinka1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.btnRegistriraj);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistration";
            this.Text = "FrmRegistracija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnRegistriraj;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.TextBox txtLozinka1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGrad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label8;
    }
}