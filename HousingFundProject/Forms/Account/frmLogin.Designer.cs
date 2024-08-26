namespace HousingFundProject.Account
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            timer1 = new System.Windows.Forms.Timer(components);
            btnLogin = new Button();
            lblTitleLogin = new Label();
            boxLogo = new PictureBox();
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserError = new Label();
            lblRequiredUserName = new Label();
            lblRequiredPassword = new Label();
            pnlMain = new Panel();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            timer2 = new System.Windows.Forms.Timer(components);
            pnlIsLoading = new Panel();
            lblIsLoading = new Label();
            ((System.ComponentModel.ISupportInitialize)boxLogo).BeginInit();
            pnlMain.SuspendLayout();
            statusStrip1.SuspendLayout();
            pnlIsLoading.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer_Tick;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkGray;
            btnLogin.BackgroundImageLayout = ImageLayout.Center;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.FromArgb(0, 64, 64);
            btnLogin.Location = new Point(55, 480);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(423, 55);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblTitleLogin
            // 
            lblTitleLogin.AutoSize = true;
            lblTitleLogin.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitleLogin.ForeColor = Color.FromArgb(0, 64, 64);
            lblTitleLogin.Location = new Point(107, 161);
            lblTitleLogin.Name = "lblTitleLogin";
            lblTitleLogin.Size = new Size(301, 21);
            lblTitleLogin.TabIndex = 0;
            lblTitleLogin.Text = "به برنامه صندوق خانگی خوش آمدید";
            // 
            // boxLogo
            // 
            boxLogo.Image = Properties.Resources.money_Icon_taskbar1;
            boxLogo.Location = new Point(208, 23);
            boxLogo.Name = "boxLogo";
            boxLogo.Size = new Size(128, 128);
            boxLogo.SizeMode = PictureBoxSizeMode.AutoSize;
            boxLogo.TabIndex = 2;
            boxLogo.TabStop = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = Color.FromArgb(0, 64, 64);
            lblUserName.Location = new Point(378, 275);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(89, 18);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "نام کاربری :";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.FromArgb(0, 64, 64);
            lblPassword.Location = new Point(391, 337);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(76, 18);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "رمز عبور :";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(75, 269);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(277, 26);
            txtUserName.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(75, 337);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(277, 26);
            txtPassword.TabIndex = 2;
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
            // lblRequiredUserName
            // 
            lblRequiredUserName.AutoSize = true;
            lblRequiredUserName.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequiredUserName.ForeColor = Color.Red;
            lblRequiredUserName.Location = new Point(136, 305);
            lblRequiredUserName.Name = "lblRequiredUserName";
            lblRequiredUserName.Size = new Size(216, 16);
            lblRequiredUserName.TabIndex = 0;
            lblRequiredUserName.Text = "وارد کردن نام کاربری الزامی است.";
            lblRequiredUserName.Visible = false;
            // 
            // lblRequiredPassword
            // 
            lblRequiredPassword.AutoSize = true;
            lblRequiredPassword.Font = new Font("Tahoma", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequiredPassword.ForeColor = Color.Red;
            lblRequiredPassword.Location = new Point(136, 374);
            lblRequiredPassword.Name = "lblRequiredPassword";
            lblRequiredPassword.Size = new Size(206, 16);
            lblRequiredPassword.TabIndex = 0;
            lblRequiredPassword.Text = "وارد کردن رمز عبور الزامی است.";
            lblRequiredPassword.Visible = false;
            // 
            // pnlMain
            // 
            pnlMain.AutoSize = true;
            pnlMain.BackColor = Color.White;
            pnlMain.Controls.Add(lblRequiredPassword);
            pnlMain.Controls.Add(lblRequiredUserName);
            pnlMain.Controls.Add(lblUserError);
            pnlMain.Controls.Add(txtPassword);
            pnlMain.Controls.Add(txtUserName);
            pnlMain.Controls.Add(lblPassword);
            pnlMain.Controls.Add(lblUserName);
            pnlMain.Controls.Add(boxLogo);
            pnlMain.Controls.Add(lblTitleLogin);
            pnlMain.Controls.Add(btnLogin);
            pnlMain.Location = new Point(131, 66);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(530, 559);
            pnlMain.TabIndex = 0;
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
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblDate, lblTime });
            statusStrip1.Location = new Point(0, 724);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(782, 29);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // timer2
            // 
            timer2.Interval = 5000;
            timer2.Tick += timer2_Tick;
            // 
            // pnlIsLoading
            // 
            pnlIsLoading.BackColor = Color.White;
            pnlIsLoading.Controls.Add(lblIsLoading);
            pnlIsLoading.Location = new Point(130, 65);
            pnlIsLoading.Name = "pnlIsLoading";
            pnlIsLoading.Size = new Size(532, 145);
            pnlIsLoading.TabIndex = 0;
            pnlIsLoading.Visible = false;
            // 
            // lblIsLoading
            // 
            lblIsLoading.AutoSize = true;
            lblIsLoading.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIsLoading.ForeColor = Color.FromArgb(0, 64, 64);
            lblIsLoading.Location = new Point(209, 64);
            lblIsLoading.Name = "lblIsLoading";
            lblIsLoading.Size = new Size(121, 21);
            lblIsLoading.TabIndex = 0;
            lblIsLoading.Text = "در حال اجرا ...";
            // 
            // frmLogin
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.Disable;
            BackColor = Color.Teal;
            ClientSize = new Size(782, 753);
            Controls.Add(pnlIsLoading);
            Controls.Add(statusStrip1);
            Controls.Add(pnlMain);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MaximizeBox = false;
            MaximumSize = new Size(800, 800);
            MinimizeBox = false;
            MinimumSize = new Size(800, 800);
            Name = "frmLogin";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "صندوق خانگی";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)boxLogo).EndInit();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlIsLoading.ResumeLayout(false);
            pnlIsLoading.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private Button btnLogin;
        private Label lblTitleLogin;
        private PictureBox boxLogo;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label lblUserError;
        private Label lblRequiredUserName;
        private Label lblRequiredPassword;
        private Panel pnlMain;
        private ToolStripStatusLabel lblDate;
        private ToolStripStatusLabel lblTime;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer2;
        private Panel pnlIsLoading;
        private Label lblIsLoading;
    }
}