namespace HousingFundProject.Forms.Lottary
{
    partial class frmFund
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFund));
            toolStrip1 = new ToolStrip();
            btnToolStripBack = new ToolStripButton();
            btnToolStripAddFund = new ToolStripButton();
            btnToolStripEditFund = new ToolStripButton();
            btnToolStripDeleteFund = new ToolStripButton();
            lblSearch = new ToolStripLabel();
            txtSearch = new ToolStripTextBox();
            btnToolStriplottery = new ToolStripButton();
            btnToolStripAddFundUser = new ToolStripButton();
            statusStrip1 = new StatusStrip();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            dgvFunds = new DataGridView();
            FundId = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Income = new DataGridViewTextBoxColumn();
            IsActive = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunds).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnToolStripBack, btnToolStripAddFund, btnToolStripEditFund, btnToolStripDeleteFund, lblSearch, txtSearch, btnToolStriplottery, btnToolStripAddFundUser });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1170, 55);
            toolStrip1.TabIndex = 2;
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
            // btnToolStripAddFund
            // 
            btnToolStripAddFund.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripAddFund.Image = Properties.Resources.add_fund_icon;
            btnToolStripAddFund.ImageTransparentColor = Color.Magenta;
            btnToolStripAddFund.Name = "btnToolStripAddFund";
            btnToolStripAddFund.Size = new Size(52, 52);
            btnToolStripAddFund.Click += btnToolStripAddFund_Click;
            // 
            // btnToolStripEditFund
            // 
            btnToolStripEditFund.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripEditFund.Image = Properties.Resources.edit_user_icon;
            btnToolStripEditFund.ImageTransparentColor = Color.Magenta;
            btnToolStripEditFund.Name = "btnToolStripEditFund";
            btnToolStripEditFund.Size = new Size(52, 52);
            btnToolStripEditFund.Click += btnToolStripEditFund_Click;
            // 
            // btnToolStripDeleteFund
            // 
            btnToolStripDeleteFund.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripDeleteFund.Image = Properties.Resources.delete_user_icon;
            btnToolStripDeleteFund.ImageTransparentColor = Color.Magenta;
            btnToolStripDeleteFund.Name = "btnToolStripDeleteFund";
            btnToolStripDeleteFund.Size = new Size(52, 52);
            btnToolStripDeleteFund.Click += btnToolStripDeleteFund_Click;
            // 
            // lblSearch
            // 
            lblSearch.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(0, 64, 64);
            lblSearch.ImageAlign = ContentAlignment.TopCenter;
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(170, 52);
            lblSearch.Text = "جستجو (عنوان، درآمد):";
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
            // btnToolStriplottery
            // 
            btnToolStriplottery.Alignment = ToolStripItemAlignment.Right;
            btnToolStriplottery.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStriplottery.Image = Properties.Resources.lottery_icon;
            btnToolStriplottery.ImageTransparentColor = Color.Magenta;
            btnToolStriplottery.Name = "btnToolStriplottery";
            btnToolStriplottery.Size = new Size(52, 52);
            btnToolStriplottery.Text = "toolStrip";
            btnToolStriplottery.Click += btnToolStriplottery_Click;
            // 
            // btnToolStripAddFundUser
            // 
            btnToolStripAddFundUser.Alignment = ToolStripItemAlignment.Right;
            btnToolStripAddFundUser.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnToolStripAddFundUser.Image = Properties.Resources.add_user_icon;
            btnToolStripAddFundUser.ImageTransparentColor = Color.Magenta;
            btnToolStripAddFundUser.Name = "btnToolStripAddFundUser";
            btnToolStripAddFundUser.RightToLeft = RightToLeft.No;
            btnToolStripAddFundUser.Size = new Size(52, 52);
            btnToolStripAddFundUser.Click += btnToolStripAddUser_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDate, lblTime });
            statusStrip1.Location = new Point(0, 455);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1170, 29);
            statusStrip1.TabIndex = 3;
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
            // dgvFunds
            // 
            dgvFunds.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvFunds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFunds.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFunds.Columns.AddRange(new DataGridViewColumn[] { FundId, Title, Income, IsActive, CreatedDate });
            dgvFunds.Location = new Point(0, 58);
            dgvFunds.Name = "dgvFunds";
            dgvFunds.RowHeadersWidth = 51;
            dgvFunds.Size = new Size(1170, 394);
            dgvFunds.TabIndex = 0;
            // 
            // FundId
            // 
            FundId.DataPropertyName = "FundId";
            FundId.HeaderText = "شناسه";
            FundId.MinimumWidth = 6;
            FundId.Name = "FundId";
            FundId.Visible = false;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "عنوان";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            // 
            // Income
            // 
            Income.DataPropertyName = "Income";
            Income.HeaderText = "درآمد";
            Income.MinimumWidth = 6;
            Income.Name = "Income";
            // 
            // IsActive
            // 
            IsActive.DataPropertyName = "IsActive";
            IsActive.HeaderText = "وضعیت";
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
            // frmFund
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 484);
            Controls.Add(dgvFunds);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFund";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "قرعه ها";
            Load += frmLottary_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFunds).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton btnToolStripBack;
        private ToolStripButton btnToolStripAddFund;
        private ToolStripButton btnToolStripEditFund;
        private ToolStripButton btnToolStripDeleteFund;
        private ToolStripLabel lblSearch;
        private ToolStripTextBox txtSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDate;
        private ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvFunds;
        private DataGridViewTextBoxColumn FundId;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Income;
        private DataGridViewTextBoxColumn IsActive;
        private DataGridViewTextBoxColumn CreatedDate;
        private ToolStripButton btnToolStripAddFundUser;
        private ToolStripButton btnToolStriplottery;
    }
}