﻿using HousingFund.DAL.Repositories.Implementation;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.ViewModels.Portal.Fund;
using HousingFund.DAL.ViewModels.Security.User;
using HousingFundProject.Forms.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousingFundProject.Forms.Lottary
{
    public partial class frmAdd_EditFund : Form
    {
        public Guid Id = Guid.Empty;

        private readonly IFundRepository _fundRepository;
        public frmAdd_EditFund()
        {
            InitializeComponent();

            _fundRepository = new FundRepository();
        }

        private bool Validation()
        {
            bool result = true;

            lblRequiredTitle.Visible = false;
            lblRequiredIncome.Visible = false;

            if (txtTitle.Text == "")
            {
                lblRequiredTitle.Visible = true;
                result = false;
            }

            if (txtIncome.Text == "")
            {
                lblRequiredIncome.Visible = true;
                result = false;
            }

            return result;
        }

        private void frmAdd_EditFund_Load(object sender, EventArgs e)
        {
            if (Id != Guid.Empty)
            {
                this.Text = "ویرایش قرعه";
                btnAdd_EditFund.Text = "ویرایش";

                var fund = _fundRepository.GetFundById(Id);

                if (fund != null)
                {
                    txtIncome.Text = fund.Income;
                    txtTitle.Text = fund.Title;
                }
            }


        }

        private void btnAdd_EditFund_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                var message = "";
                var checkMessage = "";

                try
                {
                    if (Id == Guid.Empty)
                    {

                        RegisterFundVM fund = new()
                        {
                            Title = txtTitle.Text,
                            Income = txtIncome.Text,
                            IsActive = true,
                            CreatedDate = DateTime.Now,
                        };

                        bool result = _fundRepository.Add(fund, out checkMessage);

                        if (result)
                        {
                            _fundRepository.SaveChanges();
                            message = "عملیات ثبت با موفقیت انجام شد.";
                            this.Close();
                        }
                        else if (!result)
                        {
                            message = checkMessage;
                        }
                    }
                    else
                    {
                        EditFundVM fund = new()
                        {
                            FundId = Id,
                            Title = txtTitle.Text,
                            Income = txtIncome.Text,
                            UpdateDate = DateTime.Now,
                        };

                        bool result = _fundRepository.Edit(fund, out checkMessage);

                        if (result)
                        {
                            _fundRepository.SaveChanges();
                            message = "عملیات ویرایش با موفقیت انجام شد.";
                            this.Close();
                        }
                        else if (!result)
                        {
                            message = checkMessage;
                        }

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
