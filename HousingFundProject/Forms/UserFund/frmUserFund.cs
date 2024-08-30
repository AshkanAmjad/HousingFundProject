using HousingFund.DAL.Context;
using HousingFund.DAL.Repositories.Implementation;
using HousingFund.DAL.Repositories.Interface;
using HousingFundProject.Forms.Lottary;
using HousingFundProject.Forms.Messages;
using HousingFundProject.Forms.Selection;
using HousingFundProject.Forms.UserFund;
using HousingFundProject.Utilities;

namespace HousingFundProject.Forms.Fund
{
    public partial class frmUserFund : Form
    {
        private readonly IUserFundRepository _userfundRepository;
        public Guid Id = Guid.Empty;

        public frmUserFund()
        {
            InitializeComponent();

            _userfundRepository = new UserFundRepository();
        }

        private void frmAddUserFund_Load(object sender, EventArgs e)
        {

            BindGrid(Id);

            lblDate.Text = DateAndTimeFormat.DateFormat();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateAndTimeFormat.TimeFormat();
        }

        private void btnToolStripBack_Click(object sender, EventArgs e)
        {
            this.Close();

            frmSelection selection = new();
            selection.Show();
        }

        private void btnToolStripAddUserFund_Click(object sender, EventArgs e)
        {
            frmAddUserFund add = new();
            add.Id = Id;
            add.ShowDialog();

            BindGrid(Id);
        }

        private void btnToolStripDeleteUserFund_Click(object sender, EventArgs e)
        {
            if (dgvUserFunds.CurrentRow != null)
            {
                var message = "";
                var checkMessage = "";

                DialogResult boxResult = frmCustomMessageBox.Show("آیا از حذف این شرکت کننده از قرعه مطمئن هستید؟");

                if (boxResult == DialogResult.Yes)
                {
                    try
                    {
                        string? id = dgvUserFunds.CurrentRow.Cells[0].Value.ToString();

                        Guid userFundId = new Guid(id);

                        bool result = _userfundRepository.Delete(userFundId, out checkMessage);

                        if (result)
                        {
                            message = "عملیات حذف با موفقیت انجام شد.";
                        }
                        else if (!result)
                        {
                            message = checkMessage;
                        }

                    }
                    catch (Exception ex)
                    {
                        while (ex.InnerException != null)
                        {
                            ex = ex.InnerException;
                        }
                        message = $"خطای داخلی : {ex.Message}";
                    }

                    BindGrid(Id);

                    if (message != "")
                    {
                        frmMessage messageForm = new(message);
                        messageForm.ShowDialog();
                    }
                }
            }

        }

        private void BindGrid(Guid fundId)
        {
            using (HousingFundContext context = new())
            {
                var userFunds = _userfundRepository.GetUserFunds(fundId);
                dgvUserFunds.DataSource = userFunds;
                dgvUserFunds.AutoGenerateColumns = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearch.Text;

            if (searchValue != "")
            {
                searchValue = searchValue.ToString();
            }

            var userFunds = _userfundRepository.Search(Id, searchValue);

            dgvUserFunds.DataSource = userFunds;
        }


    }
}
