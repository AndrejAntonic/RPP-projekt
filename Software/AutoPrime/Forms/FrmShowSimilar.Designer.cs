namespace AutoPrime.Forms
{
    partial class FrmShowSimilar
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
            this.dgvOglasi = new System.Windows.Forms.DataGridView();
            this.btnDetaljan = new System.Windows.Forms.Button();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.btnLeasing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOglasi
            // 
            this.dgvOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOglasi.Location = new System.Drawing.Point(20, 21);
            this.dgvOglasi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOglasi.Name = "dgvOglasi";
            this.dgvOglasi.RowHeadersWidth = 51;
            this.dgvOglasi.RowTemplate.Height = 24;
            this.dgvOglasi.Size = new System.Drawing.Size(664, 342);
            this.dgvOglasi.TabIndex = 0;
            // 
            // btnDetaljan
            // 
            this.btnDetaljan.Location = new System.Drawing.Point(20, 431);
            this.btnDetaljan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetaljan.Name = "btnDetaljan";
            this.btnDetaljan.Size = new System.Drawing.Size(74, 34);
            this.btnDetaljan.TabIndex = 1;
            this.btnDetaljan.Text = "Detaljan prikaz";
            this.btnDetaljan.UseVisualStyleBackColor = true;
            this.btnDetaljan.Click += new System.EventHandler(this.btnDetaljan_Click);
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(611, 431);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(74, 34);
            this.btnZatvori.TabIndex = 2;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnPocetna_Click);
            // 
            // btnLeasing
            // 
            this.btnLeasing.Location = new System.Drawing.Point(98, 431);
            this.btnLeasing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeasing.Name = "btnLeasing";
            this.btnLeasing.Size = new System.Drawing.Size(74, 34);
            this.btnLeasing.TabIndex = 3;
            this.btnLeasing.Text = "Leasing auta";
            this.btnLeasing.UseVisualStyleBackColor = true;
            this.btnLeasing.Click += new System.EventHandler(this.btnLeasing_Click);
            // 
            // FrmShowSimilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 488);
            this.Controls.Add(this.btnLeasing);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.btnDetaljan);
            this.Controls.Add(this.dgvOglasi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmShowSimilar";
            this.Text = "Prikaži slične automobile";
            this.Load += new System.EventHandler(this.FrmShowSimilar_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmShowSimilar_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOglasi;
        private System.Windows.Forms.Button btnDetaljan;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.Button btnLeasing;
    }
}