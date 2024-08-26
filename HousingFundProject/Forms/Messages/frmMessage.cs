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
    public partial class frmMessage : Form
    {
        public frmMessage(string Message)
        {
            InitializeComponent();
            pnlMessage.Dock = DockStyle.None;
            lblMessage.AutoSize = false;
            lblMessage.Width = default;
            lblMessage.Dock=DockStyle.Fill;
            lblMessage.Text = Message;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();

            timer1.Enabled = false;
        }
    }
}
