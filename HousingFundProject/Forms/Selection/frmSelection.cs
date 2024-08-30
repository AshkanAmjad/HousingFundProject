using HousingFundProject.Forms.History;
using HousingFundProject.Forms.Lottary;
using HousingFundProject.Forms.Users;
using HousingFundProject.Utilities;

namespace HousingFundProject.Forms.Selection
{
    public partial class frmSelection : Form
    {
        public frmSelection()
        {
            InitializeComponent();
        }

        private void frmSelection_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateAndTimeFormat.DateFormat();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateAndTimeFormat.TimeFormat();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            this.Close();

            frmUsers users = new();
            users.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Close();

            frmHistory history = new();
            history.Show();
        }

        private void btnLottary_Click(object sender, EventArgs e)
        {
            this.Close();

            frmFund lottary = new();
            lottary.Show();
        }
    }
}
