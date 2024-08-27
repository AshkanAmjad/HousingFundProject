namespace HousingFundProject.Forms.Messages
{
    partial class frmCustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomMessageBox));
            btnYes = new Button();
            btnNo = new Button();
            pnlMessage = new Panel();
            lblMessage = new Label();
            pnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.ForeColor = Color.FromArgb(0, 64, 64);
            btnYes.Location = new Point(214, 245);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(94, 29);
            btnYes.TabIndex = 1;
            btnYes.Text = "بلی";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.ForeColor = Color.FromArgb(0, 64, 64);
            btnNo.Location = new Point(314, 245);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(94, 29);
            btnNo.TabIndex = 2;
            btnNo.Text = "خیر";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // pnlMessage
            // 
            pnlMessage.BackColor = Color.White;
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Location = new Point(41, 34);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Padding = new Padding(10);
            pnlMessage.Size = new Size(539, 190);
            pnlMessage.TabIndex = 2;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.None;
            lblMessage.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(13, 84);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(513, 22);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "...";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(620, 290);
            Controls.Add(pnlMessage);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 64, 64);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCustomMessageBox";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پیام";
            pnlMessage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnYes;
        private Button btnNo;
        private Panel pnlMessage;
        private Label lblMessage;
    }
}