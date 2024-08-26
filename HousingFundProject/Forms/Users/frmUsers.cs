using HousingFund.DAL.Context;
using HousingFund.DAL.Repositories.Implementation;
using HousingFund.DAL.Repositories.Interface;
using HousingFundProject.Forms.Messages;
using HousingFundProject.Forms.Selection;
using HousingFundProject.Utilities;
namespace HousingFundProject.Forms.Users
{
    public partial class frmUsers : Form
    {
        IUserRepository _userRepository = new UserRepository();
        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            BindGrid();

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
            selection.ShowDialog();
        }

        private void btnToolStripAddUser_Click(object sender, EventArgs e)
        {
            frmAdd_EditUser add_edit = new();
            add_edit.ShowDialog();

            BindGrid();
        }

        private void btnToolStripEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {
                string id = dgvUsers.CurrentRow.Cells[0].Value.ToString();
                Guid userId = new Guid(id);

                frmAdd_EditUser add_edit = new();
                add_edit.Id = userId;
                add_edit.ShowDialog();

                BindGrid();

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearch.Text;

            if (searchValue != "")
            {
                searchValue = searchValue.ToString();
            }

            var users = _userRepository.Search(searchValue);

            dgvUsers.DataSource = users;
        }

        private void BindGrid()
        {
            using (HousingFundContext context = new())
            {
                var users = _userRepository.GetUsers();
                dgvUsers.DataSource = users;
                dgvUsers.AutoGenerateColumns = false;
            }

        }

        private void btnToolStripDeleteUser_Click(object sender, EventArgs e)
        {
            var message = "";
            var checkMessage = "";

            if (dgvUsers.CurrentRow != null)
            {
                if (RtlMessageBox.Show("آیا از حذف این کاربر مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        string id = dgvUsers.CurrentRow.Cells[0].Value.ToString();
                        Guid userId = new Guid(id);

                        bool result = _userRepository.Delete(userId, out checkMessage);

                        if (result)
                        {
                            _userRepository.SaveChanges();
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

                    BindGrid();

                    if (message != "")
                    {
                        frmMessage messageForm = new(message);
                        messageForm.ShowDialog();
                    }
                }
            }
        }
    }
}
