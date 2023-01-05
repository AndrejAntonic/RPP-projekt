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
            this.lblMileage = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbMake = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblEstimatedPrice = new System.Windows.Forms.Label();
            this.lblInsertedPrice = new System.Windows.Forms.Label();
            this.txtEstimatedPrice = new System.Windows.Forms.TextBox();
            this.txtInsertedPrice = new System.Windows.Forms.TextBox();
            this.chbxChoice = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(18, 22);
            this.lblMake.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(139, 20);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Marka automobila:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(18, 65);
            this.lblModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(138, 20);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model automobila:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(18, 251);
            this.lblMileage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(96, 20);
            this.lblMileage.TabIndex = 3;
            this.lblMileage.Text = "Kilometraža:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(18, 206);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(69, 20);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Godište:";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(168, 248);
            this.txtMileage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(180, 26);
            this.txtMileage.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(168, 203);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(180, 26);
            this.txtYear.TabIndex = 6;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(168, 60);
            this.cmbModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(180, 28);
            this.cmbModel.TabIndex = 8;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(168, 19);
            this.cmbMake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(180, 28);
            this.cmbMake.TabIndex = 9;
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.cmbMake_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(359, 15);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(112, 35);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Izračunaj";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(359, 60);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(112, 35);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEstimatedPrice
            // 
            this.lblEstimatedPrice.Location = new System.Drawing.Point(18, 103);
            this.lblEstimatedPrice.Name = "lblEstimatedPrice";
            this.lblEstimatedPrice.Size = new System.Drawing.Size(134, 42);
            this.lblEstimatedPrice.TabIndex = 12;
            this.lblEstimatedPrice.Text = "Vrijednost novog vozila:";
            // 
            // lblInsertedPrice
            // 
            this.lblInsertedPrice.AutoSize = true;
            this.lblInsertedPrice.Location = new System.Drawing.Point(18, 161);
            this.lblInsertedPrice.Name = "lblInsertedPrice";
            this.lblInsertedPrice.Size = new System.Drawing.Size(127, 20);
            this.lblInsertedPrice.TabIndex = 13;
            this.lblInsertedPrice.Text = "Vrijednost vozila:";
            // 
            // txtEstimatedPrice
            // 
            this.txtEstimatedPrice.Enabled = false;
            this.txtEstimatedPrice.Location = new System.Drawing.Point(168, 110);
            this.txtEstimatedPrice.Name = "txtEstimatedPrice";
            this.txtEstimatedPrice.Size = new System.Drawing.Size(180, 26);
            this.txtEstimatedPrice.TabIndex = 14;
            // 
            // txtInsertedPrice
            // 
            this.txtInsertedPrice.Enabled = false;
            this.txtInsertedPrice.Location = new System.Drawing.Point(168, 158);
            this.txtInsertedPrice.Name = "txtInsertedPrice";
            this.txtInsertedPrice.Size = new System.Drawing.Size(180, 26);
            this.txtInsertedPrice.TabIndex = 15;
            // 
            // chbxChoice
            // 
            this.chbxChoice.AutoSize = true;
            this.chbxChoice.Location = new System.Drawing.Point(22, 292);
            this.chbxChoice.Name = "chbxChoice";
            this.chbxChoice.Size = new System.Drawing.Size(302, 24);
            this.chbxChoice.TabIndex = 16;
            this.chbxChoice.Text = "Želim sam unijeti vrijednost automobila.";
            this.chbxChoice.UseVisualStyleBackColor = true;
            this.chbxChoice.Click += new System.EventHandler(this.chbxChoice_Click);
            // 
            // FrmKalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 334);
            this.Controls.Add(this.chbxChoice);
            this.Controls.Add(this.txtInsertedPrice);
            this.Controls.Add(this.txtEstimatedPrice);
            this.Controls.Add(this.lblInsertedPrice);
            this.Controls.Add(this.lblEstimatedPrice);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbMake);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKalkulator";
            this.Text = "Kalkulator vrijednosti automobila";
            this.Load += new System.EventHandler(this.FrmKalkulator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.ComboBox cmbMake;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblEstimatedPrice;
        private System.Windows.Forms.Label lblInsertedPrice;
        private System.Windows.Forms.TextBox txtEstimatedPrice;
        private System.Windows.Forms.TextBox txtInsertedPrice;
        private System.Windows.Forms.CheckBox chbxChoice;
    }
}