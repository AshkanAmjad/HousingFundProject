namespace HousingFundProject.Forms.Users
{
    partial class frmAdd_EditUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdd_EditUser));
            grbUsers = new GroupBox();
            chbIsActive = new CheckBox();
            chbIsAdmin = new CheckBox();
            lblIsActive = new Label();
            lblIsAdmin = new Label();
            lblRequiredAddress = new Label();
            lblRequiredPhoneNumber = new Label();
            lblRequiredConfirmPassword = new Label();
            lblRequiredPassword = new Label();
            lblRequiredUserName = new Label();
            lblRequiredLastName = new Label();
            lblRequiredFirstName = new Label();
            lblRequiredNationalCode = new Label();
            btnAdd_EditUser = new Button();
            txtAddress = new TextBox();
            lblAddress = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUserName = new TextBox();
            lblUserName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            lblFirstName = new Label();
            txtNationalCode = new TextBox();
            lblNationalCode = new Label();
            grbUsers.SuspendLayout();
            SuspendLayout();
            // 
            // grbUsers
            // 
            grbUsers.Controls.Add(chbIsActive);
            grbUsers.Controls.Add(chbIsAdmin);
            grbUsers.Controls.Add(lblIsActive);
            grbUsers.Controls.Add(lblIsAdmin);
            grbUsers.Controls.Add(lblRequiredAddress);
            grbUsers.Controls.Add(lblRequiredPhoneNumber);
            grbUsers.Controls.Add(lblRequiredConfirmPassword);
            grbUsers.Controls.Add(lblRequiredPassword);
            grbUsers.Controls.Add(lblRequiredUserName);
            grbUsers.Controls.Add(lblRequiredLastName);
            grbUsers.Controls.Add(lblRequiredFirstName);
            grbUsers.Controls.Add(lblRequiredNationalCode);
            grbUsers.Controls.Add(btnAdd_EditUser);
            grbUsers.Controls.Add(txtAddress);
            grbUsers.Controls.Add(lblAddress);
            grbUsers.Controls.Add(txtPhoneNumber);
            grbUsers.Controls.Add(lblPhoneNumber);
            grbUsers.Controls.Add(txtConfirmPassword);
            grbUsers.Controls.Add(lblConfirmPassword);
            grbUsers.Controls.Add(txtPassword);
            grbUsers.Controls.Add(lblPassword);
            grbUsers.Controls.Add(txtUserName);
            grbUsers.Controls.Add(lblUserName);
            grbUsers.Controls.Add(txtLastName);
            grbUsers.Controls.Add(lblLastName);
            grbUsers.Controls.Add(txtFirstName);
            grbUsers.Controls.Add(lblFirstName);
            grbUsers.Controls.Add(txtNationalCode);
            grbUsers.Controls.Add(lblNationalCode);
            grbUsers.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbUsers.ForeColor = Color.FromArgb(0, 64, 64);
            grbUsers.Location = new Point(12, 9);
            grbUsers.Name = "grbUsers";
            grbUsers.Size = new Size(431, 470);
            grbUsers.TabIndex = 2;
            grbUsers.TabStop = false;
            grbUsers.Text = "افزودن کاربر";
            // 
            // chbIsActive
            // 
            chbIsActive.AutoSize = true;
            chbIsActive.Location = new Point(25, 383);
            chbIsActive.Name = "chbIsActive";
            chbIsActive.Size = new Size(18, 17);
            chbIsActive.TabIndex = 11;
            chbIsActive.UseVisualStyleBackColor = true;
            chbIsActive.Visible = false;
            // 
            // chbIsAdmin
            // 
            chbIsAdmin.AutoSize = true;
            chbIsAdmin.Location = new Point(259, 383);
            chbIsAdmin.Name = "chbIsAdmin";
            chbIsAdmin.Size = new Size(18, 17);
            chbIsAdmin.TabIndex = 9;
            chbIsAdmin.UseVisualStyleBackColor = true;
            chbIsAdmin.Visible = false;
            // 
            // lblIsActive
            // 
            lblIsActive.AutoSize = true;
            lblIsActive.Location = new Point(109, 380);
            lblIsActive.Name = "lblIsActive";
            lblIsActive.Size = new Size(65, 18);
            lblIsActive.TabIndex = 0;
            lblIsActive.Text = "فعالیت :";
            lblIsActive.Visible = false;
            // 
            // lblIsAdmin
            // 
            lblIsAdmin.AutoSize = true;
            lblIsAdmin.Location = new Point(340, 380);
            lblIsAdmin.Name = "lblIsAdmin";
            lblIsAdmin.Size = new Size(83, 18);
            lblIsAdmin.TabIndex = 0;
            lblIsAdmin.Text = "دسترسی:";
            lblIsAdmin.Visible = false;
            // 
            // lblRequiredAddress
            // 
            lblRequiredAddress.AutoSize = true;
            lblRequiredAddress.ForeColor = Color.Red;
            lblRequiredAddress.Location = new Point(6, 307);
            lblRequiredAddress.Name = "lblRequiredAddress";
            lblRequiredAddress.Size = new Size(18, 18);
            lblRequiredAddress.TabIndex = 10;
            lblRequiredAddress.Text = "*";
            lblRequiredAddress.Visible = false;
            // 
            // lblRequiredPhoneNumber
            // 
            lblRequiredPhoneNumber.AutoSize = true;
            lblRequiredPhoneNumber.ForeColor = Color.Red;
            lblRequiredPhoneNumber.Location = new Point(6, 270);
            lblRequiredPhoneNumber.Name = "lblRequiredPhoneNumber";
            lblRequiredPhoneNumber.Size = new Size(18, 18);
            lblRequiredPhoneNumber.TabIndex = 0;
            lblRequiredPhoneNumber.Text = "*";
            lblRequiredPhoneNumber.Visible = false;
            // 
            // lblRequiredConfirmPassword
            // 
            lblRequiredConfirmPassword.AutoSize = true;
            lblRequiredConfirmPassword.ForeColor = Color.Red;
            lblRequiredConfirmPassword.Location = new Point(6, 231);
            lblRequiredConfirmPassword.Name = "lblRequiredConfirmPassword";
            lblRequiredConfirmPassword.Size = new Size(18, 18);
            lblRequiredConfirmPassword.TabIndex = 0;
            lblRequiredConfirmPassword.Text = "*";
            lblRequiredConfirmPassword.Visible = false;
            // 
            // lblRequiredPassword
            // 
            lblRequiredPassword.AutoSize = true;
            lblRequiredPassword.ForeColor = Color.Red;
            lblRequiredPassword.Location = new Point(6, 191);
            lblRequiredPassword.Name = "lblRequiredPassword";
            lblRequiredPassword.Size = new Size(18, 18);
            lblRequiredPassword.TabIndex = 0;
            lblRequiredPassword.Text = "*";
            lblRequiredPassword.Visible = false;
            // 
            // lblRequiredUserName
            // 
            lblRequiredUserName.AutoSize = true;
            lblRequiredUserName.ForeColor = Color.Red;
            lblRequiredUserName.Location = new Point(6, 154);
            lblRequiredUserName.Name = "lblRequiredUserName";
            lblRequiredUserName.Size = new Size(18, 18);
            lblRequiredUserName.TabIndex = 0;
            lblRequiredUserName.Text = "*";
            lblRequiredUserName.Visible = false;
            // 
            // lblRequiredLastName
            // 
            lblRequiredLastName.AutoSize = true;
            lblRequiredLastName.ForeColor = Color.Red;
            lblRequiredLastName.Location = new Point(6, 115);
            lblRequiredLastName.Name = "lblRequiredLastName";
            lblRequiredLastName.Size = new Size(18, 18);
            lblRequiredLastName.TabIndex = 0;
            lblRequiredLastName.Text = "*";
            lblRequiredLastName.Visible = false;
            // 
            // lblRequiredFirstName
            // 
            lblRequiredFirstName.AutoSize = true;
            lblRequiredFirstName.ForeColor = Color.Red;
            lblRequiredFirstName.Location = new Point(6, 79);
            lblRequiredFirstName.Name = "lblRequiredFirstName";
            lblRequiredFirstName.Size = new Size(18, 18);
            lblRequiredFirstName.TabIndex = 0;
            lblRequiredFirstName.Text = "*";
            lblRequiredFirstName.Visible = false;
            // 
            // lblRequiredNationalCode
            // 
            lblRequiredNationalCode.AutoSize = true;
            lblRequiredNationalCode.ForeColor = Color.Red;
            lblRequiredNationalCode.Location = new Point(6, 40);
            lblRequiredNationalCode.Name = "lblRequiredNationalCode";
            lblRequiredNationalCode.Size = new Size(18, 18);
            lblRequiredNationalCode.TabIndex = 0;
            lblRequiredNationalCode.Text = "*";
            lblRequiredNationalCode.Visible = false;
            // 
            // btnAdd_EditUser
            // 
            btnAdd_EditUser.BackColor = Color.Silver;
            btnAdd_EditUser.Cursor = Cursors.Hand;
            btnAdd_EditUser.ForeColor = Color.FromArgb(0, 64, 64);
            btnAdd_EditUser.Location = new Point(159, 415);
            btnAdd_EditUser.Name = "btnAdd_EditUser";
            btnAdd_EditUser.Size = new Size(130, 41);
            btnAdd_EditUser.TabIndex = 9;
            btnAdd_EditUser.Text = "ثبت";
            btnAdd_EditUser.UseVisualStyleBackColor = false;
            btnAdd_EditUser.Click += btnAdd_EditUser_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(25, 304);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(252, 67);
            txtAddress.TabIndex = 8;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(301, 305);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(122, 18);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "نشانی سکونت :";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(25, 267);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(252, 26);
            txtPhoneNumber.TabIndex = 7;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(315, 267);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(108, 18);
            lblPhoneNumber.TabIndex = 0;
            lblPhoneNumber.Text = "شماره تماس :";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(25, 228);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(252, 26);
            txtConfirmPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Location = new Point(310, 228);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(113, 18);
            lblConfirmPassword.TabIndex = 0;
            lblConfirmPassword.Text = "تکرار رمز عبور :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(25, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(252, 26);
            txtPassword.TabIndex = 5;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(347, 191);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 18);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "رمز عبور :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(25, 151);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(252, 26);
            txtUserName.TabIndex = 4;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(334, 153);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(89, 18);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "نام کاربری :";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(25, 112);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(252, 26);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(317, 115);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(106, 18);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "نام خانوادگی :";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(25, 74);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(252, 26);
            txtFirstName.TabIndex = 2;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(386, 79);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(37, 18);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "نام :";
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(25, 37);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(252, 26);
            txtNationalCode.TabIndex = 1;
            // 
            // lblNationalCode
            // 
            lblNationalCode.AutoSize = true;
            lblNationalCode.Location = new Point(354, 40);
            lblNationalCode.Name = "lblNationalCode";
            lblNationalCode.Size = new Size(69, 18);
            lblNationalCode.TabIndex = 0;
            lblNationalCode.Text = "کد ملی :";
            // 
            // frmAdd_EditUser
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(455, 490);
            Controls.Add(grbUsers);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdd_EditUser";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن کاربر";
            Load += frmAdd_EditUser_Load;
            grbUsers.ResumeLayout(false);
            grbUsers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbUsers;
        private Label lblIsActive;
        private Label lblIsAdmin;
        private Label lblRequiredAddress;
        private Label lblRequiredPhoneNumber;
        private Label lblRequiredConfirmPassword;
        private Label lblRequiredPassword;
        private Label lblRequiredUserName;
        private Label lblRequiredLastName;
        private Label lblRequiredFirstName;
        private Label lblRequiredNationalCode;
        private Button btnAdd_EditUser;
        private TextBox txtAddress;
        private Label lblAddress;
        private TextBox txtPhoneNumber;
        private Label lblPhoneNumber;
        private TextBox txtConfirmPassword;
        private Label lblConfirmPassword;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private Label lblFirstName;
        private TextBox txtNationalCode;
        private Label lblNationalCode;
        private CheckBox chbIsAdmin;
        private CheckBox chbIsActive;
    }
}