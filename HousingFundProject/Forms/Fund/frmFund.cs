using HousingFund.DAL.Context;
using HousingFund.DAL.Repositories.Implementation;
using HousingFund.DAL.Repositories.Interface;
using HousingFundProject.Forms.Fund;
using HousingFundProject.Forms.Messages;
using HousingFundProject.Forms.Selection;
using HousingFundProject.Forms.Users;
using HousingFundProject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingFundProject.Forms.Lottary
{
    public partial class frmFund : Form
    {
        private readonly IFundRepository _fundRepository;
        private readonly IUserFundRepository _userFundRepository;

        public frmFund()
        {
            InitializeComponent();
            _fundRepository = new FundRepository();
            _userFundRepository = new UserFundRepository();
        }

        private void btnToolStripBack_Click(object sender, EventArgs e)
        {
            this.Close();

            frmSelection selection = new();
            selection.ShowDialog();
        }

        private void btnToolStripAddFund_Click(object sender, EventArgs e)
        {
            frmAdd_EditFund add_edit = new();
            add_edit.ShowDialog();

            BindGrid();
        }

        private void BindGrid()
        {
            using (HousingFundContext context = new())
            {
                var funds = _fundRepository.GetFunds();
                dgvFunds.DataSource = funds;
                dgvFunds.AutoGenerateColumns = false;
            }

        }

        private void btnToolStripDeleteFund_Click(object sender, EventArgs e)
        {
            if (dgvFunds.CurrentRow != null)
            {
                var message = "";
                var checkMessage = "";

                DialogResult boxResult = frmCustomMessageBox.Show("آیا از حذف این قرعه مطمئن هستید؟");

                if (boxResult == DialogResult.Yes)
                {
                    try
                    {
                        string id = dgvFunds.CurrentRow.Cells[0].Value.ToString();
                        Guid fundId = new Guid(id);

                        bool result = _fundRepository.Delete(fundId, out checkMessage);

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

                    BindGrid();

                    if (message != "")
                    {
                        frmMessage messageForm = new(message);
                        messageForm.ShowDialog();
                    }
                }
            }
        }

        private void frmLottary_Load(object sender, EventArgs e)
        {
            BindGrid();

            lblDate.Text = DateAndTimeFormat.DateFormat();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateAndTimeFormat.TimeFormat();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearch.Text;

            if (searchValue != "")
            {
                searchValue = searchValue.ToString();
            }

            var funds = _fundRepository.Search(searchValue);

            dgvFunds.DataSource = funds;
        }

        private void btnToolStripEditFund_Click(object sender, EventArgs e)
        {
            if (dgvFunds.CurrentRow != null)
            {
                string id = dgvFunds.CurrentRow.Cells[0].Value.ToString();
                Guid fundId = new Guid(id);

                frmAdd_EditFund add_edit = new();
                add_edit.Id = fundId;
                add_edit.ShowDialog();

                BindGrid();

            }
        }

        private void btnToolStripAddUser_Click(object sender, EventArgs e)
        {
            if (dgvFunds.CurrentRow != null)
            {
                string id = dgvFunds.CurrentRow.Cells[0].Value.ToString();
                Guid fundId = new Guid(id);

                bool isActive = _fundRepository.IsActive(fundId);

                if (isActive)
                {
                    this.Close();

                    frmUserFund add = new();
                    add.Id = fundId;
                    add.Show();
                }
                else if (!isActive)
                {
                    var message = "این قرعه غیر فعال است.";
                    frmMessage messageForm = new(message);
                    messageForm.ShowDialog();
                }

            }
        }

        private void btnToolStriplottery_Click(object sender, EventArgs e)
        {
            if (dgvFunds.CurrentRow != null)
            {

                var message = "";
                var checkMessage = "";

                DialogResult boxResult = frmCustomMessageBox.Show("آیا از انجام قرعه کشی مطمئن هستید؟");

                if (boxResult == DialogResult.Yes)
                {
                    try
                    {
                        string id = dgvFunds.CurrentRow.Cells[0].Value.ToString();
                        Guid fundId = new Guid(id);

                        bool result = _userFundRepository.Lottery(fundId, out checkMessage);

                        message = checkMessage;
                        _userFundRepository.SaveChanges();

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
