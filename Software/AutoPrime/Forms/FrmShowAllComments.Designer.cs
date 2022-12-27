namespace AutoPrime
{
    partial class FrmShowAllComments
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
            this.dgvAllComments = new System.Windows.Forms.DataGridView();
            this.btnShowComment = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllComments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllComments
            // 
            this.dgvAllComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllComments.Location = new System.Drawing.Point(12, 12);
            this.dgvAllComments.Name = "dgvAllComments";
            this.dgvAllComments.Size = new System.Drawing.Size(573, 250);
            this.dgvAllComments.TabIndex = 0;
            // 
            // btnShowComment
            // 
            this.btnShowComment.Location = new System.Drawing.Point(421, 268);
            this.btnShowComment.Name = "btnShowComment";
            this.btnShowComment.Size = new System.Drawing.Size(79, 35);
            this.btnShowComment.TabIndex = 1;
            this.btnShowComment.Text = "Prikaži komentar";
            this.btnShowComment.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(506, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(79, 35);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // FrmShowAllComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 311);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnShowComment);
            this.Controls.Add(this.dgvAllComments);
            this.Name = "FrmShowAllComments";
            this.Text = "Svi komentari za korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllComments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllComments;
        private System.Windows.Forms.Button btnShowComment;
        private System.Windows.Forms.Button btnClose;
    }
}