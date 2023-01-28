namespace AutoPrime
{
    partial class FrmShowProfile
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLastComment = new System.Windows.Forms.Label();
            this.lblAverageRating = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblUserAdvertisement = new System.Windows.Forms.Label();
            this.lblUserFavourite = new System.Windows.Forms.Label();
            this.txtAverageRating = new System.Windows.Forms.TextBox();
            this.txtLastComment = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.dgvUserAdvertisement = new System.Windows.Forms.DataGridView();
            this.dgvUserFavourite = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteAdvertisement = new System.Windows.Forms.Button();
            this.btnShowAdvertisement = new System.Windows.Forms.Button();
            this.btnShowAllComments = new System.Windows.Forms.Button();
            this.btnLeaveRating = new System.Windows.Forms.Button();
            this.btnShowInteresting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAdvertisement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserFavourite)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Korisničko ime:";
            // 
            // lblLastComment
            // 
            this.lblLastComment.AutoSize = true;
            this.lblLastComment.Location = new System.Drawing.Point(12, 71);
            this.lblLastComment.Name = "lblLastComment";
            this.lblLastComment.Size = new System.Drawing.Size(101, 13);
            this.lblLastComment.TabIndex = 1;
            this.lblLastComment.Text = "Posljednji komentar:";
            // 
            // lblAverageRating
            // 
            this.lblAverageRating.AutoSize = true;
            this.lblAverageRating.Location = new System.Drawing.Point(12, 45);
            this.lblAverageRating.Name = "lblAverageRating";
            this.lblAverageRating.Size = new System.Drawing.Size(92, 13);
            this.lblAverageRating.TabIndex = 2;
            this.lblAverageRating.Text = "Prosječna ocjena:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(241, 19);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(69, 13);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Broj telefona:";
            // 
            // lblUserAdvertisement
            // 
            this.lblUserAdvertisement.AutoSize = true;
            this.lblUserAdvertisement.Location = new System.Drawing.Point(12, 165);
            this.lblUserAdvertisement.Name = "lblUserAdvertisement";
            this.lblUserAdvertisement.Size = new System.Drawing.Size(91, 13);
            this.lblUserAdvertisement.TabIndex = 4;
            this.lblUserAdvertisement.Text = "Korisnikovi oglasi:";
            // 
            // lblUserFavourite
            // 
            this.lblUserFavourite.AutoSize = true;
            this.lblUserFavourite.Location = new System.Drawing.Point(12, 396);
            this.lblUserFavourite.Name = "lblUserFavourite";
            this.lblUserFavourite.Size = new System.Drawing.Size(83, 13);
            this.lblUserFavourite.TabIndex = 5;
            this.lblUserFavourite.Text = "Zanimljivi oglasi:";
            // 
            // txtAverageRating
            // 
            this.txtAverageRating.Enabled = false;
            this.txtAverageRating.Location = new System.Drawing.Point(119, 42);
            this.txtAverageRating.Name = "txtAverageRating";
            this.txtAverageRating.Size = new System.Drawing.Size(116, 20);
            this.txtAverageRating.TabIndex = 6;
            // 
            // txtLastComment
            // 
            this.txtLastComment.Enabled = false;
            this.txtLastComment.Location = new System.Drawing.Point(119, 68);
            this.txtLastComment.Multiline = true;
            this.txtLastComment.Name = "txtLastComment";
            this.txtLastComment.Size = new System.Drawing.Size(313, 87);
            this.txtLastComment.TabIndex = 7;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Enabled = false;
            this.txtPhoneNumber.Location = new System.Drawing.Point(316, 16);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(116, 20);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(119, 16);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(116, 20);
            this.txtUsername.TabIndex = 9;
            // 
            // dgvUserAdvertisement
            // 
            this.dgvUserAdvertisement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserAdvertisement.Location = new System.Drawing.Point(15, 181);
            this.dgvUserAdvertisement.Name = "dgvUserAdvertisement";
            this.dgvUserAdvertisement.RowHeadersWidth = 51;
            this.dgvUserAdvertisement.Size = new System.Drawing.Size(417, 212);
            this.dgvUserAdvertisement.TabIndex = 10;
            // 
            // dgvUserFavourite
            // 
            this.dgvUserFavourite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserFavourite.Location = new System.Drawing.Point(15, 412);
            this.dgvUserFavourite.Name = "dgvUserFavourite";
            this.dgvUserFavourite.RowHeadersWidth = 51;
            this.dgvUserFavourite.Size = new System.Drawing.Size(417, 212);
            this.dgvUserFavourite.TabIndex = 11;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(438, 601);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Zatvori";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteAdvertisement
            // 
            this.btnDeleteAdvertisement.Location = new System.Drawing.Point(438, 341);
            this.btnDeleteAdvertisement.Name = "btnDeleteAdvertisement";
            this.btnDeleteAdvertisement.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAdvertisement.TabIndex = 13;
            this.btnDeleteAdvertisement.Text = "Obriši oglas";
            this.btnDeleteAdvertisement.UseVisualStyleBackColor = true;
            // 
            // btnShowAdvertisement
            // 
            this.btnShowAdvertisement.Location = new System.Drawing.Point(438, 370);
            this.btnShowAdvertisement.Name = "btnShowAdvertisement";
            this.btnShowAdvertisement.Size = new System.Drawing.Size(75, 23);
            this.btnShowAdvertisement.TabIndex = 14;
            this.btnShowAdvertisement.Text = "Prikaži oglas";
            this.btnShowAdvertisement.UseVisualStyleBackColor = true;
            this.btnShowAdvertisement.Click += new System.EventHandler(this.btnShowAdvertisement_Click);
            // 
            // btnShowAllComments
            // 
            this.btnShowAllComments.Location = new System.Drawing.Point(438, 113);
            this.btnShowAllComments.Name = "btnShowAllComments";
            this.btnShowAllComments.Size = new System.Drawing.Size(75, 42);
            this.btnShowAllComments.TabIndex = 15;
            this.btnShowAllComments.Text = "Prikaži sve komentare";
            this.btnShowAllComments.UseVisualStyleBackColor = true;
            this.btnShowAllComments.Click += new System.EventHandler(this.btnShowAllComments_Click);
            // 
            // btnLeaveRating
            // 
            this.btnLeaveRating.Location = new System.Drawing.Point(438, 68);
            this.btnLeaveRating.Name = "btnLeaveRating";
            this.btnLeaveRating.Size = new System.Drawing.Size(75, 42);
            this.btnLeaveRating.TabIndex = 16;
            this.btnLeaveRating.Text = "Napiši recenziju";
            this.btnLeaveRating.UseVisualStyleBackColor = true;
            this.btnLeaveRating.Visible = false;
            this.btnLeaveRating.Click += new System.EventHandler(this.btnLeaveRating_Click);
            // 
            // btnShowInteresting
            // 
            this.btnShowInteresting.Location = new System.Drawing.Point(438, 412);
            this.btnShowInteresting.Name = "btnShowInteresting";
            this.btnShowInteresting.Size = new System.Drawing.Size(75, 47);
            this.btnShowInteresting.TabIndex = 17;
            this.btnShowInteresting.Text = "Prikaži zanimljivi oglas";
            this.btnShowInteresting.UseVisualStyleBackColor = true;
            this.btnShowInteresting.Click += new System.EventHandler(this.btnShowInteresting_Click);
            // 
            // FrmShowProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 632);
            this.Controls.Add(this.btnShowInteresting);
            this.Controls.Add(this.btnLeaveRating);
            this.Controls.Add(this.btnShowAllComments);
            this.Controls.Add(this.btnShowAdvertisement);
            this.Controls.Add(this.btnDeleteAdvertisement);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvUserFavourite);
            this.Controls.Add(this.dgvUserAdvertisement);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastComment);
            this.Controls.Add(this.txtAverageRating);
            this.Controls.Add(this.lblUserFavourite);
            this.Controls.Add(this.lblUserAdvertisement);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAverageRating);
            this.Controls.Add(this.lblLastComment);
            this.Controls.Add(this.lblUsername);
            this.Name = "FrmShowProfile";
            this.Text = "Pregled profila";
            this.Load += new System.EventHandler(this.FrmShowProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserAdvertisement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserFavourite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLastComment;
        private System.Windows.Forms.Label lblAverageRating;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblUserAdvertisement;
        private System.Windows.Forms.Label lblUserFavourite;
        private System.Windows.Forms.TextBox txtAverageRating;
        private System.Windows.Forms.TextBox txtLastComment;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.DataGridView dgvUserAdvertisement;
        private System.Windows.Forms.DataGridView dgvUserFavourite;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteAdvertisement;
        private System.Windows.Forms.Button btnShowAdvertisement;
        private System.Windows.Forms.Button btnShowAllComments;
        private System.Windows.Forms.Button btnLeaveRating;
        private System.Windows.Forms.Button btnShowInteresting;
    }
}