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
            this.lblRating.Location = new System.Drawing.Point(16, 22);
            this.lblRating.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(53, 16);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "Ocjena:";
            // 
            // lblStars
            // 
            this.lblStars.AutoSize = true;
            this.lblStars.Location = new System.Drawing.Point(229, 22);
            this.lblStars.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStars.Name = "lblStars";
            this.lblStars.Size = new System.Drawing.Size(10, 16);
            this.lblStars.TabIndex = 1;
            this.lblStars.Text = ".";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(16, 54);
            this.lblComment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(67, 16);
            this.lblComment.TabIndex = 2;
            this.lblComment.Text = "Komentar:";
            // 
            // txtComment
            // 
            this.txtComment.Location = new System.Drawing.Point(20, 74);
            this.txtComment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(500, 192);
            this.txtComment.TabIndex = 3;
            // 
            // tcbRating
            // 
            this.tcbRating.Location = new System.Drawing.Point(83, 15);
            this.tcbRating.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcbRating.Maximum = 5;
            this.tcbRating.Minimum = 1;
            this.tcbRating.Name = "tcbRating";
            this.tcbRating.Size = new System.Drawing.Size(139, 56);
            this.tcbRating.TabIndex = 4;
            this.tcbRating.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tcbRating.Value = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(313, 274);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(421, 274);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 314);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tcbRating);
            this.Controls.Add(this.txtComment);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblStars);
            this.Controls.Add(this.lblRating);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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