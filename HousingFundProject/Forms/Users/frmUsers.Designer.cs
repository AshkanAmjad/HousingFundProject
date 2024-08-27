namespace HousingFundProject.Forms.Users
{
    partial class frmUsers
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            toolStrip1 = new ToolStrip();
            btnToolStripBack = new ToolStripButton();
            btnToolStripAddUser = new ToolStripButton();
            btnToolStripEditUser = new ToolStripButton();
            btnToolStripDeleteUser = new ToolStripButton();
            lblSearch = new ToolStripLabel();
            txtSearch = new ToolStripTextBox();
            statusStrip1 = new StatusStrip();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            dgvUsers = new DataGridView();
            UserId = new DataGridViewTextBoxColumn();
            UserName = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            IsAdmin = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            RegisterDate = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnToolStripBack, btnToolStripAddUser, btnToolStripEditUser, btnToolStripDeleteUser, lblSearch, txtSearch });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1068, 55);
            toolStrip1.TabIndex = 0;
            // 
            // btnToolStripBack
            // 
            btnToolStripBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripBack.Image = Properties.Resources.back_icon;
            btnToolStripBack.ImageTransparentColor = Color.Magenta;
            btnToolStripBack.Name = "btnToolStripBack";
            btnToolStripBack.RightToLeft = RightToLeft.Yes;
            btnToolStripBack.RightToLeftAutoMirrorImage = true;
            btnToolStripBack.Size = new Size(52, 52);
            btnToolStripBack.Click += btnToolStripBack_Click;
            // 
            // btnToolStripAddUser
            // 
            btnToolStripAddUser.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripAddUser.Image = Properties.Resources.add_user_icon;
            btnToolStripAddUser.ImageTransparentColor = Color.Magenta;
            btnToolStripAddUser.Name = "btnToolStripAddUser";
            btnToolStripAddUser.Size = new Size(52, 52);
            btnToolStripAddUser.Click += btnToolStripAddUser_Click;
            // 
            // btnToolStripEditUser
            // 
            btnToolStripEditUser.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripEditUser.Image = Properties.Resources.edit_user_icon;
            btnToolStripEditUser.ImageTransparentColor = Color.Magenta;
            btnToolStripEditUser.Name = "btnToolStripEditUser";
            btnToolStripEditUser.Size = new Size(52, 52);
            btnToolStripEditUser.Click += btnToolStripEditUser_Click;
            // 
            // btnToolStripDeleteUser
            // 
            btnToolStripDeleteUser.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripDeleteUser.Image = Properties.Resources.delete_user_icon;
            btnToolStripDeleteUser.ImageTransparentColor = Color.Magenta;
            btnToolStripDeleteUser.Name = "btnToolStripDeleteUser";
            btnToolStripDeleteUser.Size = new Size(52, 52);
            btnToolStripDeleteUser.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnToolStripDeleteUser.Click += btnToolStripDeleteUser_Click;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(0, 64, 64);
            lblSearch.ImageAlign = ContentAlignment.TopCenter;
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(266, 52);
            lblSearch.Text = "جستجو (کدملی، نام و نام خانوادگی):";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.FromArgb(0, 64, 64);
            txtSearch.Margin = new Padding(1, 15, 1, 10);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(250, 30);
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDate, lblTime });
            statusStrip1.Location = new Point(0, 472);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1068, 29);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            lblDate.ActiveLinkColor = Color.Transparent;
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lblDate.ForeColor = Color.FromArgb(0, 64, 64);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(67, 23);
            lblDate.Text = "نمایش تاریخ";
            // 
            // lblTime
            // 
            lblTime.ActiveLinkColor = Color.Transparent;
            lblTime.BackColor = Color.Transparent;
            lblTime.Font = new Font("B Nazanin", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lblTime.ForeColor = Color.FromArgb(0, 64, 64);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(72, 23);
            lblTime.Text = "نمایش ساعت";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // dgvUsers
            // 
            dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { UserId, UserName, NationalCode, FirstName, LastName, PhoneNumber, Address, IsAdmin, IsActive, RegisterDate });
            dgvUsers.Location = new Point(0, 58);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.Size = new Size(1068, 411);
            dgvUsers.TabIndex = 0;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "شناسه";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.Visible = false;
            // 
            // UserName
            // 
            UserName.DataPropertyName = "UserName";
            UserName.HeaderText = "نام کاربری";
            UserName.MinimumWidth = 6;
            UserName.Name = "UserName";
            // 
            // NationalCode
            // 
            NationalCode.DataPropertyName = "NationalCode";
            NationalCode.HeaderText = "کد ملی";
            NationalCode.MinimumWidth = 6;
            NationalCode.Name = "NationalCode";
            // 
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "نام";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "نام خانوادگی";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "شماره تماس";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "نشانی";
            Address.MinimumWidth = 6;
            Address.Name = "Address";
            // 
            // IsAdmin
            // 
            IsAdmin.DataPropertyName = "IsAdmin";
            IsAdmin.HeaderText = "ادمین";
            IsAdmin.MinimumWidth = 6;
            IsAdmin.Name = "IsAdmin";
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "فعالیت";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            // 
            // RegisterDate
            // 
            RegisterDate.DataPropertyName = "RegisterDate";
            RegisterDate.HeaderText = "تاریخ ثبت";
            RegisterDate.MinimumWidth = 6;
            RegisterDate.Name = "RegisterDate";
            // 
            // frmUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 501);
            Controls.Add(dgvUsers);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 64, 64);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUsers";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "کاربران";
            Load += frmUsers_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnToolStripBack;
        private ToolStripButton btnToolStripAddUser;
        private ToolStripButton btnToolStripEditUser;
        private ToolStripButton btnToolStripDeleteUser;
        private ToolStripLabel lblSearch;
        private ToolStripTextBox txtSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDate;
        private ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn IsAdmin;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn RegisterDate;
        private DataGridViewTextBoxColumn UserName;
    }
}