namespace HousingFundProject.Forms.Fund
{
    partial class frmUserFund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserFund));
            statusStrip1 = new StatusStrip();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            toolStrip1 = new ToolStrip();
            btnToolStripBack = new ToolStripButton();
            btnToolStripAddUserFund = new ToolStripButton();
            btnToolStripDeleteUserFund = new ToolStripButton();
            lblSearch = new ToolStripLabel();
            txtSearch = new ToolStripTextBox();
            dgvUserFunds = new DataGridView();
            UserFundId = new DataGridViewTextBoxColumn();
            FundId = new DataGridViewTextBoxColumn();
            UserId = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            statusStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserFunds).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDate, lblTime });
            statusStrip1.Location = new Point(0, 407);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1170, 29);
            statusStrip1.TabIndex = 4;
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
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnToolStripBack, btnToolStripAddUserFund, btnToolStripDeleteUserFund, lblSearch, txtSearch });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1170, 55);
            toolStrip1.TabIndex = 5;
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
            // btnToolStripAddUserFund
            // 
            btnToolStripAddUserFund.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripAddUserFund.Image = Properties.Resources.add_fund_icon;
            btnToolStripAddUserFund.ImageTransparentColor = Color.Magenta;
            btnToolStripAddUserFund.Name = "btnToolStripAddUserFund";
            btnToolStripAddUserFund.Size = new Size(52, 52);
            btnToolStripAddUserFund.Click += btnToolStripAddUserFund_Click;
            // 
            // btnToolStripDeleteUserFund
            // 
            btnToolStripDeleteUserFund.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripDeleteUserFund.Image = Properties.Resources.delete_user_icon;
            btnToolStripDeleteUserFund.ImageTransparentColor = Color.Magenta;
            btnToolStripDeleteUserFund.Name = "btnToolStripDeleteUserFund";
            btnToolStripDeleteUserFund.Size = new Size(52, 52);
            btnToolStripDeleteUserFund.Click += btnToolStripDeleteUserFund_Click;
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
            // dgvUserFunds
            // 
            dgvUserFunds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvUserFunds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUserFunds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserFunds.Columns.AddRange(new DataGridViewColumn[] { UserFundId, FundId, UserId, NationalCode, FirstName, LastName, PhoneNumber, IsActive, CreatedDate });
            dgvUserFunds.Location = new Point(0, 58);
            dgvUserFunds.Name = "dgvUserFunds";
            dgvUserFunds.RowHeadersWidth = 51;
            dgvUserFunds.Size = new Size(1170, 346);
            dgvUserFunds.TabIndex = 6;
            // 
            // UserFundId
            // 
            UserFundId.DataPropertyName = "UserFundId";
            UserFundId.HeaderText = "شناسه";
            UserFundId.MinimumWidth = 6;
            UserFundId.Name = "UserFundId";
            UserFundId.Visible = false;
            // 
            // FundId
            // 
            FundId.DataPropertyName = "FundId";
            FundId.HeaderText = "شناسه قرعه";
            FundId.MinimumWidth = 6;
            FundId.Name = "FundId";
            FundId.Visible = false;
            // 
            // UserId
            // 
            UserId.DataPropertyName = "UserId";
            UserId.HeaderText = "شناسه شرکت کننده";
            UserId.MinimumWidth = 6;
            UserId.Name = "UserId";
            UserId.Visible = false;
            // 
            // NationalCode
            // 
            NationalCode.DataPropertyName = "NationalCode";
            NationalCode.HeaderText = "کدملی";
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
            LastName.HeaderText = "نام حانوادگی";
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
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "فعالیت";
            IsActive.MinimumWidth = 6;
            IsActive.Name = "IsActive";
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "تاریخ ثبت";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            // 
            // frmUserFund
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 436);
            Controls.Add(dgvUserFunds);
            Controls.Add(toolStrip1);
            Controls.Add(statusStrip1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmUserFund";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "شرکت کنندگان";
            Load += frmAddUserFund_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserFunds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDate;
        private ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private ToolStrip toolStrip1;
        private ToolStripButton btnToolStripBack;
        private ToolStripButton btnToolStripAddUserFund;
        private ToolStripButton btnToolStripDeleteUserFund;
        private ToolStripLabel lblSearch;
        private ToolStripTextBox txtSearch;
        private DataGridView dgvUserFunds;
        private DataGridViewTextBoxColumn UserFundId;
        private DataGridViewTextBoxColumn FundId;
        private DataGridViewTextBoxColumn UserId;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn CreatedDate;
    }
}