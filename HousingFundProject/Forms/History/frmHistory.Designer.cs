namespace HousingFundProject.Forms.History
{
    partial class frmHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            toolStrip1 = new ToolStrip();
            btnToolStripBack = new ToolStripButton();
            lblSearch = new ToolStripLabel();
            txtSearch = new ToolStripTextBox();
            statusStrip1 = new StatusStrip();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            dgvHistories = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Income = new DataGridViewTextBoxColumn();
            FirstName = new DataGridViewTextBoxColumn();
            LastName = new DataGridViewTextBoxColumn();
            NationalCode = new DataGridViewTextBoxColumn();
            PhoneNumber = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistories).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(48, 48);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnToolStripBack, lblSearch, txtSearch });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1170, 55);
            toolStrip1.TabIndex = 3;
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
            // lblSearch
            // 
            lblSearch.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(0, 64, 64);
            lblSearch.ImageAlign = ContentAlignment.TopCenter;
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(297, 52);
            lblSearch.Text = "جستجو (عنوان، نام و نام خانوادگی برنده):";
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
            statusStrip1.Location = new Point(0, 455);
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
            // dgvHistories
            // 
            dgvHistories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHistories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistories.Columns.AddRange(new DataGridViewColumn[] { Title, Income, FirstName, LastName, NationalCode, PhoneNumber, CreatedDate });
            dgvHistories.Location = new Point(0, 58);
            dgvHistories.Name = "dgvHistories";
            dgvHistories.RowHeadersWidth = 51;
            dgvHistories.Size = new Size(1170, 394);
            dgvHistories.TabIndex = 5;
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
            // FirstName
            // 
            FirstName.DataPropertyName = "FirstName";
            FirstName.HeaderText = "نام برنده";
            FirstName.MinimumWidth = 6;
            FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            LastName.DataPropertyName = "LastName";
            LastName.HeaderText = "نام خانوادگی برنده";
            LastName.MinimumWidth = 6;
            LastName.Name = "LastName";
            // 
            // NationalCode
            // 
            NationalCode.DataPropertyName = "NationalCode";
            NationalCode.HeaderText = "کد ملی برنده";
            NationalCode.MinimumWidth = 6;
            NationalCode.Name = "NationalCode";
            // 
            // PhoneNumber
            // 
            PhoneNumber.DataPropertyName = "PhoneNumber";
            PhoneNumber.HeaderText = "شماره تماس برنده";
            PhoneNumber.MinimumWidth = 6;
            PhoneNumber.Name = "PhoneNumber";
            // 
            // CreatedDate
            // 
            CreatedDate.DataPropertyName = "CreatedDate";
            CreatedDate.HeaderText = "تاریخ ثبت";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            // 
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 484);
            Controls.Add(dgvHistories);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(50, 50);
            Name = "frmHistory";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "تاریخچه";
            Load += frmHistory_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistories).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnToolStripBack;
        private ToolStripLabel lblSearch;
        private ToolStripTextBox txtSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDate;
        private ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
        private DataGridView dgvHistories;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Income;
        private DataGridViewTextBoxColumn FirstName;
        private DataGridViewTextBoxColumn LastName;
        private DataGridViewTextBoxColumn NationalCode;
        private DataGridViewTextBoxColumn PhoneNumber;
        private DataGridViewTextBoxColumn CreatedDate;
    }
}