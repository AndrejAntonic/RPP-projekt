namespace AutoPrime.Forms
{
    partial class SlikaTester
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
            this.pbSlikaTester = new System.Windows.Forms.PictureBox();
            this.btnPrikazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaTester)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlikaTester
            // 
            this.pbSlikaTester.Location = new System.Drawing.Point(233, 12);
            this.pbSlikaTester.Name = "pbSlikaTester";
            this.pbSlikaTester.Size = new System.Drawing.Size(328, 254);
            this.pbSlikaTester.TabIndex = 0;
            this.pbSlikaTester.TabStop = false;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(366, 272);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(75, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // SlikaTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.pbSlikaTester);
            this.Name = "SlikaTester";
            this.Text = "SlikaTester";
            this.Load += new System.EventHandler(this.SlikaTester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaTester)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlikaTester;
        private System.Windows.Forms.Button btnPrikazi;
    }
}