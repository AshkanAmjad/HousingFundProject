using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingFundProject.Forms.Messages
{
    public partial class frmCustomMessageBox : Form
    {
        public frmCustomMessageBox(string message)
        {
            InitializeComponent();
            pnlMessage.Dock = DockStyle.None;
            lblMessage.AutoSize = false;
            lblMessage.Width = default;
            lblMessage.Dock = DockStyle.Fill;
            lblMessage.Text = message;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        public static DialogResult Show(string message)
        {
            using (var msgBox = new frmCustomMessageBox(message))
            {
                return msgBox.ShowDialog();
            }
        }
    }
}
