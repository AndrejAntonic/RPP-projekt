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
            this.btnPocetna = new System.Windows.Forms.Button();
            this.dgvOglasi = new System.Windows.Forms.DataGridView();
            this.btnDetaljno = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPocetna
            // 
            this.btnPocetna.Location = new System.Drawing.Point(37, 520);
            this.btnPocetna.Name = "btnPocetna";
            this.btnPocetna.Size = new System.Drawing.Size(82, 28);
            this.btnPocetna.TabIndex = 0;
            this.btnPocetna.Text = "Početna";
            this.btnPocetna.UseVisualStyleBackColor = true;
            // 
            // dgvOglasi
            // 
            this.dgvOglasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOglasi.Location = new System.Drawing.Point(37, 24);
            this.dgvOglasi.Name = "dgvOglasi";
            this.dgvOglasi.RowHeadersWidth = 51;
            this.dgvOglasi.RowTemplate.Height = 24;
            this.dgvOglasi.Size = new System.Drawing.Size(837, 406);
            this.dgvOglasi.TabIndex = 1;
            // 
            // btnDetaljno
            // 
            this.btnDetaljno.Location = new System.Drawing.Point(148, 515);
            this.btnDetaljno.Name = "btnDetaljno";
            this.btnDetaljno.Size = new System.Drawing.Size(104, 39);
            this.btnDetaljno.TabIndex = 2;
            this.btnDetaljno.Text = "Detaljan prikaz";
            this.btnDetaljno.UseVisualStyleBackColor = true;
            // 
            // FrmLeasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 571);
            this.Controls.Add(this.btnDetaljno);
            this.Controls.Add(this.dgvOglasi);
            this.Controls.Add(this.btnPocetna);
            this.Name = "FrmLeasing";
            this.Text = "FrmLeasing";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOglasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPocetna;
        private System.Windows.Forms.DataGridView dgvOglasi;
        private System.Windows.Forms.Button btnDetaljno;
    }
}