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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLozinka1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLozinka2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisničko ime:";
            // 
            // txtKorime
            // 
            this.txtKorime.Location = new System.Drawing.Point(133, 51);
            this.txtKorime.Name = "txtKorime";
            this.txtKorime.Size = new System.Drawing.Size(166, 22);
            this.txtKorime.TabIndex = 1;
            // 
            // btnPromjeni
            // 
            this.btnPromjeni.Location = new System.Drawing.Point(33, 287);
            this.btnPromjeni.Name = "btnPromjeni";
            this.btnPromjeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromjeni.TabIndex = 2;
            this.btnPromjeni.Text = "Promjeni";
            this.btnPromjeni.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 98);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(166, 22);
            this.txtEmail.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // txtLozinka1
            // 
            this.txtLozinka1.Location = new System.Drawing.Point(133, 147);
            this.txtLozinka1.Name = "txtLozinka1";
            this.txtLozinka1.Size = new System.Drawing.Size(166, 22);
            this.txtLozinka1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nova lozinka:";
            // 
            // txtLozinka2
            // 
            this.txtLozinka2.Location = new System.Drawing.Point(133, 194);
            this.txtLozinka2.Name = "txtLozinka2";
            this.txtLozinka2.Size = new System.Drawing.Size(166, 22);
            this.txtLozinka2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ponovi lozinku:";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(169, 287);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(75, 23);
            this.btnOdustani.TabIndex = 9;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            // 
            // FrmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 347);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.txtLozinka2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLozinka1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPromjeni);
            this.Controls.Add(this.txtKorime);
            this.Controls.Add(this.label1);
            this.Name = "FrmForgotPassword";
            this.Text = "FrmForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKorime;
        private System.Windows.Forms.Button btnPromjeni;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLozinka1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLozinka2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOdustani;
    }
}