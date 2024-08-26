namespace HousingFundProject.Forms.Messages
{
    partial class frmMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessage));
            pnlMessage = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            lblMessage = new Label();
            pnlMessage.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMessage
            // 
            pnlMessage.BackColor = Color.White;
            pnlMessage.Controls.Add(lblMessage);
            pnlMessage.Location = new Point(46, 36);
            pnlMessage.Name = "pnlMessage";
            pnlMessage.Padding = new Padding(10);
            pnlMessage.Size = new Size(530, 223);
            pnlMessage.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3000;
            timer1.Tick += timer1_Tick;
            // 
            // lblMessage
            // 
            lblMessage.Anchor = AnchorStyles.None;
            lblMessage.Font = new Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(251, 100);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(28, 22);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "...";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmMessage
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(620, 290);
            Controls.Add(pnlMessage);
            Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMessage";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پیام";
            pnlMessage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMessage;
        private System.Windows.Forms.Timer timer1;
        private Label lblMessage;
    }
}