namespace HousingFundProject.Forms.Selection
{
    partial class frmSelection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelection));
            pnlMain = new Panel();
            btnHistory = new Button();
            btnUsers = new Button();
            btnLottary = new Button();
            lblUserError = new Label();
            statusStrip1 = new StatusStrip();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            timer1 = new System.Windows.Forms.Timer(components);
            pnlMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.AutoSize = true;
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(btnHistory);
            pnlMain.Controls.Add(btnUsers);
            pnlMain.Controls.Add(btnLottary);
            pnlMain.Controls.Add(lblUserError);
            pnlMain.Location = new Point(126, 97);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(530, 559);
            pnlMain.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.Silver;
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderColor = Color.Teal;
            btnHistory.FlatAppearance.BorderSize = 2;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHistory.ForeColor = Color.FromArgb(0, 64, 64);
            btnHistory.Location = new Point(32, 396);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(466, 111);
            btnHistory.TabIndex = 10;
            btnHistory.Text = "تاریخچه";
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnUsers
            // 
            btnUsers.BackColor = Color.Silver;
            btnUsers.Cursor = Cursors.Hand;
            btnUsers.FlatAppearance.BorderColor = Color.Teal;
            btnUsers.FlatAppearance.BorderSize = 2;
            btnUsers.FlatStyle = FlatStyle.Flat;
            btnUsers.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUsers.ForeColor = Color.FromArgb(0, 64, 64);
            btnUsers.Location = new Point(32, 226);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(466, 111);
            btnUsers.TabIndex = 9;
            btnUsers.Text = "کاربران";
            btnUsers.UseVisualStyleBackColor = false;
            btnUsers.Click += btnUsers_Click;
            // 
            // btnLottary
            // 
            btnLottary.BackColor = Color.Silver;
            btnLottary.BackgroundImageLayout = ImageLayout.None;
            btnLottary.Cursor = Cursors.Hand;
            btnLottary.FlatAppearance.BorderColor = Color.Teal;
            btnLottary.FlatAppearance.BorderSize = 2;
            btnLottary.FlatStyle = FlatStyle.Flat;
            btnLottary.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLottary.ForeColor = Color.FromArgb(0, 64, 64);
            btnLottary.ImageAlign = ContentAlignment.BottomLeft;
            btnLottary.Location = new Point(32, 54);
            btnLottary.Name = "btnLottary";
            btnLottary.RightToLeft = RightToLeft.No;
            btnLottary.Size = new Size(466, 111);
            btnLottary.TabIndex = 8;
            btnLottary.Text = "وام ها";
            btnLottary.UseVisualStyleBackColor = false;
            btnLottary.Click += btnLottary_Click;
            // 
            // lblUserError
            // 
            lblUserError.AutoSize = true;
            lblUserError.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserError.ForeColor = Color.Red;
            lblUserError.Location = new Point(177, 217);
            lblUserError.Name = "lblUserError";
            lblUserError.Size = new Size(0, 18);
            lblUserError.TabIndex = 7;
            lblUserError.TextAlign = ContentAlignment.TopRight;
            lblUserError.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDate, lblTime });
            statusStrip1.Location = new Point(0, 724);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(782, 29);
            statusStrip1.TabIndex = 0;
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
            timer1.Tick += timer_Tick;
            // 
            // frmSelection
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Teal;
            ClientSize = new Size(782, 753);
            Controls.Add(statusStrip1);
            Controls.Add(pnlMain);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 800);
            MinimizeBox = false;
            MinimumSize = new Size(800, 800);
            Name = "frmSelection";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صندوق خانگی";
            Load += frmSelection_Load;
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlMain;
        private Button btnLottary;
        private Label lblUserError;
        private Button btnUsers;
        private Button btnHistory;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblDate;
        private ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer timer1;
    }
}