namespace AutoPrime
{
    partial class FrmIndex
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
            this.dgvNajtrazeniji = new System.Windows.Forms.DataGridView();
            this.btnPregledOdabranog = new System.Windows.Forms.Button();
            this.btnPregledOglasaAukcija = new System.Windows.Forms.Button();
            this.btnKreirajOglas = new System.Windows.Forms.Button();
            this.btnKreirajAukciju = new System.Windows.Forms.Button();
            this.btnLeasing = new System.Windows.Forms.Button();
            this.btnKalkulator = new System.Windows.Forms.Button();
            this.btnProfil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajtrazeniji)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Najtraženiji oglasi";
            // 
            // dgvNajtrazeniji
            // 
            this.dgvNajtrazeniji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNajtrazeniji.Location = new System.Drawing.Point(12, 52);
            this.dgvNajtrazeniji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvNajtrazeniji.Name = "dgvNajtrazeniji";
            this.dgvNajtrazeniji.RowHeadersWidth = 51;
            this.dgvNajtrazeniji.RowTemplate.Height = 24;
            this.dgvNajtrazeniji.Size = new System.Drawing.Size(572, 122);
            this.dgvNajtrazeniji.TabIndex = 1;
            // 
            // btnPregledOdabranog
            // 
            this.btnPregledOdabranog.Location = new System.Drawing.Point(422, 199);
            this.btnPregledOdabranog.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPregledOdabranog.Name = "btnPregledOdabranog";
            this.btnPregledOdabranog.Size = new System.Drawing.Size(162, 23);
            this.btnPregledOdabranog.TabIndex = 2;
            this.btnPregledOdabranog.Text = "Pregled odabranog oglasa";
            this.btnPregledOdabranog.UseVisualStyleBackColor = true;
            // 
            // btnPregledOglasaAukcija
            // 
            this.btnPregledOglasaAukcija.Location = new System.Drawing.Point(242, 254);
            this.btnPregledOglasaAukcija.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPregledOglasaAukcija.Name = "btnPregledOglasaAukcija";
            this.btnPregledOglasaAukcija.Size = new System.Drawing.Size(157, 24);
            this.btnPregledOglasaAukcija.TabIndex = 3;
            this.btnPregledOglasaAukcija.Text = "Pregled oglasa i aukcija";
            this.btnPregledOglasaAukcija.UseVisualStyleBackColor = true;
            this.btnPregledOglasaAukcija.Click += new System.EventHandler(this.btnPregledOglasaAukcija_Click);
            // 
            // btnKreirajOglas
            // 
            this.btnKreirajOglas.Location = new System.Drawing.Point(242, 301);
            this.btnKreirajOglas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKreirajOglas.Name = "btnKreirajOglas";
            this.btnKreirajOglas.Size = new System.Drawing.Size(157, 24);
            this.btnKreirajOglas.TabIndex = 4;
            this.btnKreirajOglas.Text = "Kreiraj oglas";
            this.btnKreirajOglas.UseVisualStyleBackColor = true;
            this.btnKreirajOglas.Click += new System.EventHandler(this.btnKreirajOglas_Click);
            // 
            // btnKreirajAukciju
            // 
            this.btnKreirajAukciju.Location = new System.Drawing.Point(242, 349);
            this.btnKreirajAukciju.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKreirajAukciju.Name = "btnKreirajAukciju";
            this.btnKreirajAukciju.Size = new System.Drawing.Size(157, 24);
            this.btnKreirajAukciju.TabIndex = 5;
            this.btnKreirajAukciju.Text = "Kreiraj aukciju";
            this.btnKreirajAukciju.UseVisualStyleBackColor = true;
            this.btnKreirajAukciju.Click += new System.EventHandler(this.btnKreirajAukciju_Click);
            // 
            // btnLeasing
            // 
            this.btnLeasing.Location = new System.Drawing.Point(242, 400);
            this.btnLeasing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeasing.Name = "btnLeasing";
            this.btnLeasing.Size = new System.Drawing.Size(157, 24);
            this.btnLeasing.TabIndex = 6;
            this.btnLeasing.Text = "Leasing";
            this.btnLeasing.UseVisualStyleBackColor = true;
            this.btnLeasing.Click += new System.EventHandler(this.btnLeasing_Click);
            // 
            // btnKalkulator
            // 
            this.btnKalkulator.Location = new System.Drawing.Point(242, 442);
            this.btnKalkulator.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKalkulator.Name = "btnKalkulator";
            this.btnKalkulator.Size = new System.Drawing.Size(157, 24);
            this.btnKalkulator.TabIndex = 7;
            this.btnKalkulator.Text = "Kalkulator";
            this.btnKalkulator.UseVisualStyleBackColor = true;
            this.btnKalkulator.Click += new System.EventHandler(this.btnKalkulator_Click);
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(242, 488);
            this.btnProfil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(157, 24);
            this.btnProfil.TabIndex = 8;
            this.btnProfil.Text = "Vlastiti profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            this.btnProfil.Click += new System.EventHandler(this.btnProfil_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 522);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnKalkulator);
            this.Controls.Add(this.btnLeasing);
            this.Controls.Add(this.btnKreirajAukciju);
            this.Controls.Add(this.btnKreirajOglas);
            this.Controls.Add(this.btnPregledOglasaAukcija);
            this.Controls.Add(this.btnPregledOdabranog);
            this.Controls.Add(this.dgvNajtrazeniji);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmIndex";
            this.Text = "Auto Prime";
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNajtrazeniji)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvNajtrazeniji;
        private System.Windows.Forms.Button btnPregledOdabranog;
        private System.Windows.Forms.Button btnPregledOglasaAukcija;
        private System.Windows.Forms.Button btnKreirajOglas;
        private System.Windows.Forms.Button btnKreirajAukciju;
        private System.Windows.Forms.Button btnLeasing;
        private System.Windows.Forms.Button btnKalkulator;
        private System.Windows.Forms.Button btnProfil;
    }
}

