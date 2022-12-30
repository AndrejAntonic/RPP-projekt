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
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Najtraženiji oglasi";
            // 
            // dgvNajtrazeniji
            // 
            this.dgvNajtrazeniji.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNajtrazeniji.Location = new System.Drawing.Point(16, 64);
            this.dgvNajtrazeniji.Name = "dgvNajtrazeniji";
            this.dgvNajtrazeniji.RowHeadersWidth = 51;
            this.dgvNajtrazeniji.RowTemplate.Height = 24;
            this.dgvNajtrazeniji.Size = new System.Drawing.Size(763, 150);
            this.dgvNajtrazeniji.TabIndex = 1;
            // 
            // btnPregledOdabranog
            // 
            this.btnPregledOdabranog.Location = new System.Drawing.Point(562, 245);
            this.btnPregledOdabranog.Name = "btnPregledOdabranog";
            this.btnPregledOdabranog.Size = new System.Drawing.Size(216, 28);
            this.btnPregledOdabranog.TabIndex = 2;
            this.btnPregledOdabranog.Text = "Pregled odabranog oglasa";
            this.btnPregledOdabranog.UseVisualStyleBackColor = true;
            // 
            // btnPregledOglasaAukcija
            // 
            this.btnPregledOglasaAukcija.Location = new System.Drawing.Point(322, 313);
            this.btnPregledOglasaAukcija.Name = "btnPregledOglasaAukcija";
            this.btnPregledOglasaAukcija.Size = new System.Drawing.Size(209, 29);
            this.btnPregledOglasaAukcija.TabIndex = 3;
            this.btnPregledOglasaAukcija.Text = "Pregled oglasa i aukcija";
            this.btnPregledOglasaAukcija.UseVisualStyleBackColor = true;
            // 
            // btnKreirajOglas
            // 
            this.btnKreirajOglas.Location = new System.Drawing.Point(322, 371);
            this.btnKreirajOglas.Name = "btnKreirajOglas";
            this.btnKreirajOglas.Size = new System.Drawing.Size(209, 29);
            this.btnKreirajOglas.TabIndex = 4;
            this.btnKreirajOglas.Text = "Kreiraj oglas";
            this.btnKreirajOglas.UseVisualStyleBackColor = true;
            // 
            // btnKreirajAukciju
            // 
            this.btnKreirajAukciju.Location = new System.Drawing.Point(322, 429);
            this.btnKreirajAukciju.Name = "btnKreirajAukciju";
            this.btnKreirajAukciju.Size = new System.Drawing.Size(209, 29);
            this.btnKreirajAukciju.TabIndex = 5;
            this.btnKreirajAukciju.Text = "Kreiraj aukciju";
            this.btnKreirajAukciju.UseVisualStyleBackColor = true;
            // 
            // btnLeasing
            // 
            this.btnLeasing.Location = new System.Drawing.Point(322, 492);
            this.btnLeasing.Name = "btnLeasing";
            this.btnLeasing.Size = new System.Drawing.Size(209, 29);
            this.btnLeasing.TabIndex = 6;
            this.btnLeasing.Text = "Leasing";
            this.btnLeasing.UseVisualStyleBackColor = true;
            // 
            // btnKalkulator
            // 
            this.btnKalkulator.Location = new System.Drawing.Point(322, 544);
            this.btnKalkulator.Name = "btnKalkulator";
            this.btnKalkulator.Size = new System.Drawing.Size(209, 29);
            this.btnKalkulator.TabIndex = 7;
            this.btnKalkulator.Text = "Kalkulator";
            this.btnKalkulator.UseVisualStyleBackColor = true;
            // 
            // btnProfil
            // 
            this.btnProfil.Location = new System.Drawing.Point(322, 601);
            this.btnProfil.Name = "btnProfil";
            this.btnProfil.Size = new System.Drawing.Size(209, 29);
            this.btnProfil.TabIndex = 8;
            this.btnProfil.Text = "Profil";
            this.btnProfil.UseVisualStyleBackColor = true;
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 642);
            this.Controls.Add(this.btnProfil);
            this.Controls.Add(this.btnKalkulator);
            this.Controls.Add(this.btnLeasing);
            this.Controls.Add(this.btnKreirajAukciju);
            this.Controls.Add(this.btnKreirajOglas);
            this.Controls.Add(this.btnPregledOglasaAukcija);
            this.Controls.Add(this.btnPregledOdabranog);
            this.Controls.Add(this.dgvNajtrazeniji);
            this.Controls.Add(this.label1);
            this.Name = "FrmIndex";
            this.Text = "Auto Prime";
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

