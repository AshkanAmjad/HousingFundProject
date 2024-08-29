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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistory));
            toolStrip1 = new ToolStrip();
            btnToolStripBack = new ToolStripButton();
            lblSearch = new ToolStripLabel();
            txtSearch = new ToolStripTextBox();
            statusStrip1 = new StatusStrip();
            lblDate = new ToolStripStatusLabel();
            lblTime = new ToolStripStatusLabel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
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
            // frmHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 484);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Location = new Point(50, 50);
            Name = "frmHistory";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "تاریخچه";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
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
    }
}