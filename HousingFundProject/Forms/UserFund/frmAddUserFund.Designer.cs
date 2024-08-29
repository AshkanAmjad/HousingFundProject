namespace HousingFundProject.Forms.UserFund
{
    partial class frmAddUserFund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddUserFund));
            grbUsers = new GroupBox();
            cmbUserFund = new ComboBox();
            btnAddUserFund = new Button();
            lblPassword = new Label();
            lblUserFund = new Label();
            grbUsers.SuspendLayout();
            SuspendLayout();
            // 
            // grbUsers
            // 
            grbUsers.Controls.Add(cmbUserFund);
            grbUsers.Controls.Add(btnAddUserFund);
            grbUsers.Controls.Add(lblPassword);
            grbUsers.Controls.Add(lblUserFund);
            grbUsers.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbUsers.ForeColor = Color.FromArgb(0, 64, 64);
            grbUsers.Location = new Point(12, 12);
            grbUsers.Name = "grbUsers";
            grbUsers.Size = new Size(431, 141);
            grbUsers.TabIndex = 0;
            grbUsers.TabStop = false;
            grbUsers.Text = "افزودن شرکت کننده";
            // 
            // cmbUserFund
            // 
            cmbUserFund.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbUserFund.ForeColor = Color.FromArgb(0, 64, 64);
            cmbUserFund.FormattingEnabled = true;
            cmbUserFund.Location = new Point(30, 34);
            cmbUserFund.Name = "cmbUserFund";
            cmbUserFund.Size = new Size(252, 24);
            cmbUserFund.TabIndex = 1;
            cmbUserFund.Text = "                           ...";
            // 
            // btnAddUserFund
            // 
            btnAddUserFund.BackColor = Color.Silver;
            btnAddUserFund.Cursor = Cursors.Hand;
            btnAddUserFund.ForeColor = Color.FromArgb(0, 64, 64);
            btnAddUserFund.Location = new Point(160, 88);
            btnAddUserFund.Name = "btnAddUserFund";
            btnAddUserFund.Size = new Size(130, 41);
            btnAddUserFund.TabIndex = 2;
            btnAddUserFund.Text = "ثبت";
            btnAddUserFund.UseVisualStyleBackColor = false;
            btnAddUserFund.Click += btnAddUserFund_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(347, 191);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(0, 18);
            lblPassword.TabIndex = 0;
            // 
            // lblUserFund
            // 
            lblUserFund.AutoSize = true;
            lblUserFund.Location = new Point(366, 37);
            lblUserFund.Name = "lblUserFund";
            lblUserFund.Size = new Size(50, 18);
            lblUserFund.TabIndex = 0;
            lblUserFund.Text = "کاربر :";
            // 
            // frmAddUserFund
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(455, 163);
            Controls.Add(grbUsers);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 64, 64);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddUserFund";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن شرکت کننده";
            Load += frmAdd_EditUserFund_Load;
            grbUsers.ResumeLayout(false);
            grbUsers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbUsers;
        private Button btnAddUserFund;
        private Label lblPassword;
        private Label lblUserFund;
        private ComboBox cmbUserFund;
    }
}