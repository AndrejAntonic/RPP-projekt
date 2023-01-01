namespace AutoPrime
{
    partial class FrmKalkulator
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
            this.lblMake = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(16, 18);
            this.lblMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(118, 16);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Marka automobila:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(16, 52);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(118, 16);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model automobila:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(16, 186);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(146, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Procijenjena vrijednost:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(16, 117);
            this.lblMileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(80, 16);
            this.lblMileage.TabIndex = 3;
            this.lblMileage.Text = "Kilometraža:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(16, 85);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(57, 16);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Godište:";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(149, 113);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(160, 22);
            this.txtMileage.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(149, 81);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(160, 22);
            this.txtYear.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(179, 182);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(131, 22);
            this.txtPrice.TabIndex = 7;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(149, 48);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(160, 24);
            this.cmbModel.TabIndex = 8;
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(149, 15);
            this.cmbMake.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(160, 24);
            this.cmbMake.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(319, 12);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Izračunaj";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(319, 48);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmKalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 215);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmKalkulator";
            this.Text = "Kalkulator vrijednosti automobila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
    }
}