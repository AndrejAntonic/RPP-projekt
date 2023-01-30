namespace AutoPrime.Forms
{
    partial class FrmLeasing
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
            this.btnZatvori = new System.Windows.Forms.Button();
            this.dgvOglasi = new System.Windows.Forms.DataGridView();
            this.btnDetaljno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(594, 427);
            this.btnZatvori.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(62, 23);
            this.btnZatvori.TabIndex = 0;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            this.btnZatvori.Click += new System.EventHandler(this.btnZatvori_Click);
            // 
            // dgvOglasi
            // 
            this.dgvOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOglasi.Location = new System.Drawing.Point(28, 20);
            this.dgvOglasi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvOglasi.Name = "dgvOglasi";
            this.dgvOglasi.RowHeadersWidth = 51;
            this.dgvOglasi.RowTemplate.Height = 24;
            this.dgvOglasi.Size = new System.Drawing.Size(628, 330);
            this.dgvOglasi.TabIndex = 1;
            // 
            // btnDetaljno
            // 
            this.btnDetaljno.Location = new System.Drawing.Point(28, 418);
            this.btnDetaljno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDetaljno.Name = "btnDetaljno";
            this.btnDetaljno.Size = new System.Drawing.Size(87, 32);
            this.btnDetaljno.TabIndex = 2;
            this.btnDetaljno.Text = "Detaljan prikaz";
            this.btnDetaljno.UseVisualStyleBackColor = true;
            this.btnDetaljno.Click += new System.EventHandler(this.btnDetaljno_Click);
            // 
            // FrmLeasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 464);
            this.Controls.Add(this.btnDetaljno);
            this.Controls.Add(this.dgvOglasi);
            this.Controls.Add(this.btnZatvori);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmLeasing";
            this.Text = "Leasing vozila";
            this.Load += new System.EventHandler(this.FrmLeasing_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmLeasing_HelpRequested);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.DataGridView dgvOglasi;
        private System.Windows.Forms.Button btnDetaljno;
    }
}