namespace AutoPrime
{
    partial class FrmReview
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
            this.lblRating = new System.Windows.Forms.Label();
            this.lblStars = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.tcbRating = new System.Windows.Forms.TrackBar();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tcbRating)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(12, 18);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(44, 13);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Ocjena:";
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblStars.Location = new System.Drawing.Point(172, 6);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(17, 25);
            this.lblStars.TabIndex = 1;
            this.lblStars.Text = ".";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(12, 44);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(55, 13);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "Komentar:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(15, 60);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(376, 157);
            this.txtComment.TabIndex = 3;
            // 
            // tcbRating
            // 
            this.tcbRating.Location = new System.Drawing.Point(62, 12);
            this.tcbRating.Maximum = 5;
            this.tcbRating.Minimum = 1;
            this.tcbRating.Name = "tcbRating";
            this.tcbRating.Size = new System.Drawing.Size(104, 45);
            this.tcbRating.TabIndex = 4;
            this.tcbRating.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tcbRating.Value = 1;
            this.tcbRating.ValueChanged += new System.EventHandler(this.tcbRating_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(235, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(316, 223);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 255);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tcbRating);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblStars);
            this.Controls.Add(this.lblRating);
            this.Name = "FrmReview";
            this.Text = "Recenzija prodavatelja";
            ((System.ComponentModel.ISupportInitialize)(this.tcbRating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblStars;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TrackBar tcbRating;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}