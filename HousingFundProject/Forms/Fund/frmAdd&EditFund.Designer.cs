namespace HousingFundProject.Forms.Lottary
{
    partial class frmAdd_EditFund
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
            lblTitle = new Label();
            grbUsers = new GroupBox();
            lblRequiredUserName = new Label();
            lblRequiredIncome = new Label();
            lblRequiredTitle = new Label();
            btnAdd_EditFund = new Button();
            txtIncome = new TextBox();
            lblIncome = new Label();
            txtTitle = new TextBox();
            grbUsers.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(354, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(57, 18);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "عنوان :";
            // 
            // grbUsers
            // 
            grbUsers.Controls.Add(lblRequiredUserName);
            grbUsers.Controls.Add(lblRequiredIncome);
            grbUsers.Controls.Add(lblRequiredTitle);
            grbUsers.Controls.Add(btnAdd_EditFund);
            grbUsers.Controls.Add(txtIncome);
            grbUsers.Controls.Add(lblIncome);
            grbUsers.Controls.Add(txtTitle);
            grbUsers.Controls.Add(lblTitle);
            grbUsers.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbUsers.ForeColor = Color.FromArgb(0, 64, 64);
            grbUsers.Location = new Point(22, 12);
            grbUsers.Name = "grbUsers";
            grbUsers.Size = new Size(431, 180);
            grbUsers.TabIndex = 3;
            grbUsers.TabStop = false;
            grbUsers.Text = "افزودن قرعه";
            // 
            // lblRequiredUserName
            // 
            lblRequiredUserName.AutoSize = true;
            lblRequiredUserName.ForeColor = Color.Red;
            lblRequiredUserName.Location = new Point(6, 154);
            lblRequiredUserName.Name = "lblRequiredUserName";
            lblRequiredUserName.Size = new Size(0, 18);
            lblRequiredUserName.TabIndex = 0;
            lblRequiredUserName.Visible = false;
            // 
            // lblRequiredIncome
            // 
            lblRequiredIncome.AutoSize = true;
            lblRequiredIncome.ForeColor = Color.Red;
            lblRequiredIncome.Location = new Point(6, 79);
            lblRequiredIncome.Name = "lblRequiredIncome";
            lblRequiredIncome.Size = new Size(18, 18);
            lblRequiredIncome.TabIndex = 0;
            lblRequiredIncome.Text = "*";
            lblRequiredIncome.Visible = false;
            // 
            // lblRequiredTitle
            // 
            lblRequiredTitle.AutoSize = true;
            lblRequiredTitle.ForeColor = Color.Red;
            lblRequiredTitle.Location = new Point(6, 40);
            lblRequiredTitle.Name = "lblRequiredTitle";
            lblRequiredTitle.Size = new Size(18, 18);
            lblRequiredTitle.TabIndex = 0;
            lblRequiredTitle.Text = "*";
            lblRequiredTitle.Visible = false;
            // 
            // btnAdd_EditFund
            // 
            btnAdd_EditFund.BackColor = Color.Silver;
            btnAdd_EditFund.Cursor = Cursors.Hand;
            btnAdd_EditFund.ForeColor = Color.FromArgb(0, 64, 64);
            btnAdd_EditFund.Location = new Point(147, 126);
            btnAdd_EditFund.Name = "btnAdd_EditFund";
            btnAdd_EditFund.Size = new Size(130, 41);
            btnAdd_EditFund.TabIndex = 9;
            btnAdd_EditFund.Text = "ثبت";
            btnAdd_EditFund.UseVisualStyleBackColor = false;
            btnAdd_EditFund.Click += btnAdd_EditFund_Click;
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(25, 74);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(252, 26);
            txtIncome.TabIndex = 2;
            // 
            // lblIncome
            // 
            lblIncome.AutoSize = true;
            lblIncome.Location = new Point(357, 79);
            lblIncome.Name = "lblIncome";
            lblIncome.Size = new Size(54, 18);
            lblIncome.TabIndex = 0;
            lblIncome.Text = "درآمد :";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(25, 37);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(252, 26);
            txtTitle.TabIndex = 1;
            // 
            // frmAdd_EditFund
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 206);
            Controls.Add(grbUsers);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdd_EditFund";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterParent;
            Text = "افزودن قرعه";
            Load += frmAdd_EditFund_Load;
            grbUsers.ResumeLayout(false);
            grbUsers.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CheckBox chbIsAdmin;
        private Label lblIsAdmin;
        private Label lblRequiredLastName;
        private TextBox txtUserName;
        private Label lblUserName;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblTitle;
        private GroupBox grbUsers;
        private Label lblRequiredUserName;
        private Label lblRequiredIncome;
        private Label lblRequiredTitle;
        private Button btnAdd_EditFund;
        private TextBox txtIncome;
        private Label lblIncome;
        private TextBox txtTitle;
    }
}