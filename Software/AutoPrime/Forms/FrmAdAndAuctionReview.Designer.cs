namespace AutoPrime.Forms
{
    partial class FrmAdAndAuctionReview
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbGodina = new System.Windows.Forms.ComboBox();
            this.cmbKilometraza = new System.Windows.Forms.ComboBox();
            this.cmbCijena = new System.Windows.Forms.ComboBox();
            this.dgvOglasi = new System.Windows.Forms.DataGridView();
            this.dgvAukcije = new System.Windows.Forms.DataGridView();
            this.btnPregledOglasa = new System.Windows.Forms.Button();
            this.btnPregledAukcije = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAukcije)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pretraživanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(864, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(864, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(864, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godina:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(848, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kilometraža:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(870, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Cijena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Oglasi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 522);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Aukcije:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(120, 27);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(240, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(948, 32);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(121, 24);
            this.cmbMarka.TabIndex = 9;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(948, 67);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 24);
            this.cmbModel.TabIndex = 10;
            // 
            // cmbGodina
            // 
            this.cmbGodina.FormattingEnabled = true;
            this.cmbGodina.Items.AddRange(new object[] {
            "1990-2000",
            "2000-2005",
            "2005-2010",
            "2010-2015",
            "2015-2020",
            "2020-2023"});
            this.cmbGodina.Location = new System.Drawing.Point(948, 107);
            this.cmbGodina.Name = "cmbGodina";
            this.cmbGodina.Size = new System.Drawing.Size(121, 24);
            this.cmbGodina.TabIndex = 11;
            // 
            // cmbKilometraza
            // 
            this.cmbKilometraza.FormattingEnabled = true;
            this.cmbKilometraza.Items.AddRange(new object[] {
            "0-50000",
            "50000-100000",
            "100000-150000",
            "150000-200000",
            "200000-250000",
            "250000-300000",
            "300000-350000"});
            this.cmbKilometraza.Location = new System.Drawing.Point(948, 148);
            this.cmbKilometraza.Name = "cmbKilometraza";
            this.cmbKilometraza.Size = new System.Drawing.Size(121, 24);
            this.cmbKilometraza.TabIndex = 12;
            // 
            // cmbCijena
            // 
            this.cmbCijena.FormattingEnabled = true;
            this.cmbCijena.Items.AddRange(new object[] {
            "0-10000",
            "10000-20000",
            "20000-30000",
            "30000-40000",
            "40000-50000"});
            this.cmbCijena.Location = new System.Drawing.Point(948, 187);
            this.cmbCijena.Name = "cmbCijena";
            this.cmbCijena.Size = new System.Drawing.Size(121, 24);
            this.cmbCijena.TabIndex = 13;
            // 
            // dgvOglasi
            // 
            this.dgvOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOglasi.Location = new System.Drawing.Point(29, 258);
            this.dgvOglasi.Name = "dgvOglasi";
            this.dgvOglasi.RowHeadersWidth = 51;
            this.dgvOglasi.RowTemplate.Height = 24;
            this.dgvOglasi.Size = new System.Drawing.Size(1040, 208);
            this.dgvOglasi.TabIndex = 14;
            // 
            // dgvAukcije
            // 
            this.dgvAukcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAukcije.Location = new System.Drawing.Point(29, 541);
            this.dgvAukcije.Name = "dgvAukcije";
            this.dgvAukcije.RowHeadersWidth = 51;
            this.dgvAukcije.RowTemplate.Height = 24;
            this.dgvAukcije.Size = new System.Drawing.Size(1040, 208);
            this.dgvAukcije.TabIndex = 15;
            // 
            // btnPregledOglasa
            // 
            this.btnPregledOglasa.Location = new System.Drawing.Point(862, 472);
            this.btnPregledOglasa.Name = "btnPregledOglasa";
            this.btnPregledOglasa.Size = new System.Drawing.Size(207, 28);
            this.btnPregledOglasa.TabIndex = 16;
            this.btnPregledOglasa.Text = "Pregled odabranog oglasa";
            this.btnPregledOglasa.UseVisualStyleBackColor = true;
            this.btnPregledOglasa.Click += new System.EventHandler(this.btnPregledOglasa_Click);
            // 
            // btnPregledAukcije
            // 
            this.btnPregledAukcije.Location = new System.Drawing.Point(879, 755);
            this.btnPregledAukcije.Name = "btnPregledAukcije";
            this.btnPregledAukcije.Size = new System.Drawing.Size(207, 28);
            this.btnPregledAukcije.TabIndex = 17;
            this.btnPregledAukcije.Text = "Pregled odabrane aukcije";
            this.btnPregledAukcije.UseVisualStyleBackColor = true;
            this.btnPregledAukcije.Click += new System.EventHandler(this.btnPregledAukcije_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(983, 806);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(103, 28);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.Location = new System.Drawing.Point(994, 225);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(75, 23);
            this.btnFiltriraj.TabIndex = 19;
            this.btnFiltriraj.Text = "Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(831, 225);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(157, 23);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Resetiraj filter";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmAdAndAuctionReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 846);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPregledAukcije);
            this.Controls.Add(this.btnPregledOglasa);
            this.Controls.Add(this.dgvAukcije);
            this.Controls.Add(this.dgvOglasi);
            this.Controls.Add(this.cmbCijena);
            this.Controls.Add(this.cmbKilometraza);
            this.Controls.Add(this.cmbGodina);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdAndAuctionReview";
            this.Text = "FrmAdAndAuctionReview";
            this.Load += new System.EventHandler(this.FrmAdAndAuctionReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAukcije)).EndInit();
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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbMarka;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbGodina;
        private System.Windows.Forms.ComboBox cmbKilometraza;
        private System.Windows.Forms.ComboBox cmbCijena;
        private System.Windows.Forms.DataGridView dgvOglasi;
        private System.Windows.Forms.DataGridView dgvAukcije;
        private System.Windows.Forms.Button btnPregledOglasa;
        private System.Windows.Forms.Button btnPregledAukcije;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFiltriraj;
        private System.Windows.Forms.Button btnReset;
    }
}