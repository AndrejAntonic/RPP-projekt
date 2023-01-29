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
            this.lblMake.Location = new System.Drawing.Point(12, 14);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(94, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Marka automobila:";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 42);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(93, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model automobila:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(12, 163);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(64, 13);
            this.lblMileage.TabIndex = 3;
            this.lblMileage.Text = "Kilometraža:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(12, 134);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(46, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Godište:";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(112, 161);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(121, 20);
            this.txtMileage.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(112, 132);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(121, 20);
            this.txtYear.TabIndex = 6;
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(112, 39);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 8;
            this.cmbModel.SelectedIndexChanged += new System.EventHandler(this.cmbModel_SelectedIndexChanged);
            // 
            // cmbMake
            // 
            this.cmbMake.FormattingEnabled = true;
            this.cmbMake.Location = new System.Drawing.Point(112, 12);
            this.cmbMake.Name = "cmbMake";
            this.cmbMake.Size = new System.Drawing.Size(121, 21);
            this.cmbMake.TabIndex = 9;
            this.cmbMake.SelectedIndexChanged += new System.EventHandler(this.cmbMake_SelectedIndexChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(239, 10);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Izračunaj";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(239, 39);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblEstimatedPrice
            // 
            this.lblEstimatedPrice.Location = new System.Drawing.Point(12, 67);
            this.lblEstimatedPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstimatedPrice.Name = "lblEstimatedPrice";
            this.lblEstimatedPrice.Size = new System.Drawing.Size(89, 27);
            this.lblEstimatedPrice.TabIndex = 12;
            this.lblEstimatedPrice.Text = "Vrijednost novog vozila:";
            // 
            // lblInsertedPrice
            // 
            this.lblInsertedPrice.AutoSize = true;
            this.lblInsertedPrice.Location = new System.Drawing.Point(12, 105);
            this.lblInsertedPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInsertedPrice.Name = "lblInsertedPrice";
            this.lblInsertedPrice.Size = new System.Drawing.Size(86, 13);
            this.lblInsertedPrice.TabIndex = 13;
            this.lblInsertedPrice.Text = "Vrijednost vozila:";
            // 
            // txtEstimatedPrice
            // 
            this.txtEstimatedPrice.Enabled = false;
            this.txtEstimatedPrice.Location = new System.Drawing.Point(112, 72);
            this.txtEstimatedPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEstimatedPrice.Name = "txtEstimatedPrice";
            this.txtEstimatedPrice.Size = new System.Drawing.Size(121, 20);
            this.txtEstimatedPrice.TabIndex = 14;
            // 
            // txtInsertedPrice
            // 
            this.txtInsertedPrice.Enabled = false;
            this.txtInsertedPrice.Location = new System.Drawing.Point(112, 103);
            this.txtInsertedPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInsertedPrice.Name = "txtInsertedPrice";
            this.txtInsertedPrice.Size = new System.Drawing.Size(121, 20);
            this.txtInsertedPrice.TabIndex = 15;
            // 
            // chbxChoice
            // 
            this.chbxChoice.AutoSize = true;
            this.chbxChoice.Location = new System.Drawing.Point(15, 190);
            this.chbxChoice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chbxChoice.Name = "chbxChoice";
            this.chbxChoice.Size = new System.Drawing.Size(208, 17);
            this.chbxChoice.TabIndex = 16;
            this.chbxChoice.Text = "Želim sam unijeti vrijednost automobila.";
            this.chbxChoice.UseVisualStyleBackColor = true;
            this.chbxChoice.Click += new System.EventHandler(this.chbxChoice_Click);
            // 
            // FrmKalkulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 217);
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
            this.Name = "FrmKalkulator";
            this.Text = "Kalkulator vrijednosti automobila";
            this.Load += new System.EventHandler(this.FrmKalkulator_Load);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.FrmKalkulator_HelpRequested);
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