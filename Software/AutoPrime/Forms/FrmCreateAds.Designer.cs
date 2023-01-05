namespace AutoPrime.Forms
{
    partial class FrmCreateAds
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNaslovOglasa = new System.Windows.Forms.TextBox();
            this.cmbMarkaVozila = new System.Windows.Forms.ComboBox();
            this.cmbModelVozila = new System.Windows.Forms.ComboBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.txtGodinaProizvodnje = new System.Windows.Forms.TextBox();
            this.txtKilometraza = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.cmbMotor = new System.Windows.Forms.ComboBox();
            this.cbOstecenja = new System.Windows.Forms.CheckBox();
            this.cbLeasing = new System.Windows.Forms.CheckBox();
            this.btnDodajOglas = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDodajOstecenja = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naslov oglasa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka vozila:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Model vozila:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Lokacija:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Godina proizvodnje:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cijena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kilometraža:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Motor:";
            // 
            // txtNaslovOglasa
            // 
            this.txtNaslovOglasa.Location = new System.Drawing.Point(198, 48);
            this.txtNaslovOglasa.Name = "txtNaslovOglasa";
            this.txtNaslovOglasa.Size = new System.Drawing.Size(278, 22);
            this.txtNaslovOglasa.TabIndex = 10;
            // 
            // cmbMarkaVozila
            // 
            this.cmbMarkaVozila.FormattingEnabled = true;
            this.cmbMarkaVozila.Location = new System.Drawing.Point(198, 91);
            this.cmbMarkaVozila.Name = "cmbMarkaVozila";
            this.cmbMarkaVozila.Size = new System.Drawing.Size(278, 24);
            this.cmbMarkaVozila.TabIndex = 11;
            this.cmbMarkaVozila.SelectedIndexChanged += new System.EventHandler(this.cmbMarkaVozila_SelectedIndexChanged);
            // 
            // cmbModelVozila
            // 
            this.cmbModelVozila.FormattingEnabled = true;
            this.cmbModelVozila.Location = new System.Drawing.Point(198, 138);
            this.cmbModelVozila.Name = "cmbModelVozila";
            this.cmbModelVozila.Size = new System.Drawing.Size(278, 24);
            this.cmbModelVozila.TabIndex = 12;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Location = new System.Drawing.Point(198, 187);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(278, 22);
            this.txtLokacija.TabIndex = 13;
            // 
            // txtGodinaProizvodnje
            // 
            this.txtGodinaProizvodnje.Location = new System.Drawing.Point(198, 234);
            this.txtGodinaProizvodnje.Name = "txtGodinaProizvodnje";
            this.txtGodinaProizvodnje.Size = new System.Drawing.Size(278, 22);
            this.txtGodinaProizvodnje.TabIndex = 14;
            // 
            // txtKilometraza
            // 
            this.txtKilometraza.Location = new System.Drawing.Point(198, 319);
            this.txtKilometraza.Name = "txtKilometraza";
            this.txtKilometraza.Size = new System.Drawing.Size(278, 22);
            this.txtKilometraza.TabIndex = 16;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(198, 276);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(278, 22);
            this.txtCijena.TabIndex = 15;
            // 
            // cmbMotor
            // 
            this.cmbMotor.FormattingEnabled = true;
            this.cmbMotor.Location = new System.Drawing.Point(198, 362);
            this.cmbMotor.Name = "cmbMotor";
            this.cmbMotor.Size = new System.Drawing.Size(278, 24);
            this.cmbMotor.TabIndex = 17;
            // 
            // cbOstecenja
            // 
            this.cbOstecenja.AutoSize = true;
            this.cbOstecenja.Location = new System.Drawing.Point(198, 416);
            this.cbOstecenja.Name = "cbOstecenja";
            this.cbOstecenja.Size = new System.Drawing.Size(90, 20);
            this.cbOstecenja.TabIndex = 18;
            this.cbOstecenja.Text = "Oštećenja";
            this.cbOstecenja.UseVisualStyleBackColor = true;
            // 
            // cbLeasing
            // 
            this.cbLeasing.AutoSize = true;
            this.cbLeasing.Location = new System.Drawing.Point(198, 452);
            this.cbLeasing.Name = "cbLeasing";
            this.cbLeasing.Size = new System.Drawing.Size(77, 20);
            this.cbLeasing.TabIndex = 19;
            this.cbLeasing.Text = "Leasing";
            this.cbLeasing.UseVisualStyleBackColor = true;
            // 
            // btnDodajOglas
            // 
            this.btnDodajOglas.Location = new System.Drawing.Point(281, 631);
            this.btnDodajOglas.Name = "btnDodajOglas";
            this.btnDodajOglas.Size = new System.Drawing.Size(96, 29);
            this.btnDodajOglas.TabIndex = 20;
            this.btnDodajOglas.Text = "Dodaj oglas";
            this.btnDodajOglas.UseVisualStyleBackColor = true;
            this.btnDodajOglas.Click += new System.EventHandler(this.btnDodajOglas_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(380, 631);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(96, 29);
            this.btnOdustani.TabIndex = 21;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(276, 484);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpDatum.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(64, 489);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Datum:";
            // 
            // btnDodajOstecenja
            // 
            this.btnDodajOstecenja.Location = new System.Drawing.Point(187, 591);
            this.btnDodajOstecenja.Name = "btnDodajOstecenja";
            this.btnDodajOstecenja.Size = new System.Drawing.Size(126, 29);
            this.btnDodajOstecenja.TabIndex = 25;
            this.btnDodajOstecenja.Text = "Dodaj ostecenja";
            this.btnDodajOstecenja.UseVisualStyleBackColor = true;
            this.btnDodajOstecenja.Click += new System.EventHandler(this.btnDodajOstecenja_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(67, 591);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(114, 29);
            this.btnDodajSliku.TabIndex = 24;
            this.btnDodajSliku.Text = "Dodaj sliku";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // FrmCreateAds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 672);
            this.Controls.Add(this.btnDodajOstecenja);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnDodajOglas);
            this.Controls.Add(this.cbLeasing);
            this.Controls.Add(this.cbOstecenja);
            this.Controls.Add(this.cmbMotor);
            this.Controls.Add(this.txtKilometraza);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtGodinaProizvodnje);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.cmbModelVozila);
            this.Controls.Add(this.cmbMarkaVozila);
            this.Controls.Add(this.txtNaslovOglasa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmCreateAds";
            this.Text = "Kreiranje novog oglasa";
            this.Load += new System.EventHandler(this.FrmCreateAds_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNaslovOglasa;
        private System.Windows.Forms.ComboBox cmbMarkaVozila;
        private System.Windows.Forms.ComboBox cmbModelVozila;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.TextBox txtGodinaProizvodnje;
        private System.Windows.Forms.TextBox txtKilometraza;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.ComboBox cmbMotor;
        private System.Windows.Forms.CheckBox cbOstecenja;
        private System.Windows.Forms.CheckBox cbLeasing;
        private System.Windows.Forms.Button btnDodajOglas;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDodajOstecenja;
        private System.Windows.Forms.Button btnDodajSliku;
    }
}