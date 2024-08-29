using HousingFund.DAL.Entities.Security.User.Models;
using HousingFund.DAL.Repositories.Implementation;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.ViewModels.Portal.UserFund;
using HousingFundProject.Forms.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingFundProject.Forms.UserFund
{
    public partial class frmAddUserFund : Form
    {
        public Guid Id = Guid.Empty;
        private readonly IUserFundRepository _userfundRepository;

        public frmAddUserFund()
        {
            InitializeComponent();

            _userfundRepository = new UserFundRepository();
        }

        private void frmAdd_EditUserFund_Load(object sender, EventArgs e)
        {
            #region ComboBox
            cmbUserFund.DisplayMember = "FullName";
            cmbUserFund.ValueMember = "UserId";
            cmbUserFund.DataSource = _userfundRepository.GetIdAndNameUsers();
            #endregion

        }

        private void btnAddUserFund_Click(object sender, EventArgs e)
        {
            if (cmbUserFund.SelectedIndex >= 0)
            {
                var message = "";
                var checkMessage = "";

                try
                {
                    string id = cmbUserFund.SelectedValue.ToString();
                    Guid userId = new Guid(id);

                    Guid fundId = Id;

                    RegisterUserFundVM userFund = new()
                    {
                        FundId = fundId,
                        UserId = userId,
                        CreatedDate = DateTime.Now,
                        IsWinner = false,
                    };

                    bool result = _userfundRepository.Add(userFund, out checkMessage);

                    if (result)
                    {
                        _userfundRepository.SaveChanges();
                        message = "عملیات ثبت با موفقیت انجام شد.";
                        this.Close();
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

                if (message != "")
                {
                    frmMessage messageForm = new(message);
                    messageForm.ShowDialog();
                }
            }


        }
    }
}
