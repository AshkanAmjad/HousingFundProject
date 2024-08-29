using HousingFund.DAL.Context;
using HousingFund.DAL.Repositories.Implementation;
using HousingFund.DAL.Repositories.Interface;
using HousingFundProject.Forms.Selection;
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

namespace HousingFundProject.Forms.History
{
    public partial class frmHistory : Form
    {
        private readonly IHistoryWinnerRepository _historyWinnerRepository;
        public frmHistory()
        {
            InitializeComponent();

            _historyWinnerRepository = new HistoryWinnerRepository();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateAndTimeFormat.TimeFormat();
        }

        private void frmHistory_Load(object sender, EventArgs e)
        {
            BindGrid();

            lblDate.Text = DateAndTimeFormat.DateFormat();
        }

        private void btnToolStripBack_Click(object sender, EventArgs e)
        {
            this.Close();

            frmSelection selection = new();
            selection.ShowDialog();
        }

        private void BindGrid()
        {
            using (HousingFundContext context = new())
            {
                var histories = _historyWinnerRepository.GetHistories();
                dgvHistories.DataSource = histories;
                dgvHistories.AutoGenerateColumns = false;
            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var searchValue = txtSearch.Text;

            if (searchValue != "")
            {
                searchValue = searchValue.ToString();
            }

            var histories = _historyWinnerRepository.Search(searchValue);

            dgvHistories.DataSource = histories;

        }
    }
}
