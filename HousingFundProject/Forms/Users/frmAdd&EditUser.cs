using HousingFund.DAL.Repositories.Implementation;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.ViewModels.Security.User;
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

namespace HousingFundProject.Forms.Users
{
    public partial class frmAdd_EditUser : Form
    {
        public Guid Id = Guid.Empty;
        IUserRepository _userRepository = new UserRepository();

        public frmAdd_EditUser()
        {
            InitializeComponent();
        }

        private void btnAdd_EditUser_Click(object sender, EventArgs e)
        {
            var message = "";
            var checkMessage = "";

            if (Validation())
            {
                try
                {
                    if (Id == Guid.Empty)
                    {

                        RegisterUserVM user = new()
                        {
                            NationalCode = txtNationalCode.Text,
                            Address = txtAddress.Text,
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            IsActive = true,
                            IsAdmin = false,
                            PhoneNumber = txtPhoneNumber.Text,
                            Password = txtPassword.Text,
                            UserName = txtUserName.Text,
                            RegisterDate = DateTime.Now
                        };

                        bool result = _userRepository.Add(user, out checkMessage);

                        if (result)         
                        {
                            _userRepository.SaveChanges();
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
                        EditUserVM user = new()
                        {
                            UserId = Id,
                            Address = txtAddress.Text,
                            FirstName = txtFirstName.Text,
                            LastName = txtLastName.Text,
                            NationalCode = txtNationalCode.Text,
                            PhoneNumber = txtPhoneNumber.Text,
                            UserName = txtUserName.Text,
                            IsActive = chbIsActive.Checked,
                            IsAdmin = chbIsAdmin.Checked,
                            Password = txtPassword.Text,
                            UpdateDate = DateTime.Now,
                        };

                        bool result = _userRepository.Edit(user, out checkMessage);

                        if (result)
                        {
                            _userRepository.SaveChanges();
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
            }

            if (message != "")
            {
                frmMessage messageForm = new(message);
                messageForm.ShowDialog();
            }

        }

        private bool Validation()
        {
            bool result = true;

            lblRequiredNationalCode.Visible = false;
            lblRequiredFirstName.Visible = false;
            lblRequiredLastName.Visible = false;
            lblRequiredUserName.Visible = false;
            lblRequiredPassword.Visible = false;
            lblRequiredConfirmPassword.Visible = false;
            lblRequiredPhoneNumber.Visible = false;
            lblRequiredAddress.Visible = false;

            if (txtNationalCode.Text == "")
            {
                lblRequiredNationalCode.Visible = true;
                result = false;
            }

            if (Id == Guid.Empty && txtPassword.Text == "")
            {
                lblRequiredPassword.Visible = true;
                result = false;
            }


            if (Id == Guid.Empty && txtConfirmPassword.Text == "" )
            {
                lblRequiredConfirmPassword.Visible = true;
                result = false;
            }


            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                lblRequiredConfirmPassword.Visible = true;
                result = false;
            }

            if (txtUserName.Text == "")
            {
                lblRequiredUserName.Visible = true;
                result = false;
            }

            if (txtFirstName.Text == "")
            {
                lblRequiredFirstName.Visible = true;
                result = false;
            }

            if (txtLastName.Text == "")
            {
                lblRequiredLastName.Visible = true;
                result = false;
            }

            if (txtAddress.Text == "")
            {
                lblRequiredAddress.Visible = true;
                result = false;
            }

            if (txtPhoneNumber.Text == "")
            {
                lblRequiredPhoneNumber.Visible = true;
                result = false;
            }

            return result;
        }

        private void frmAdd_EditUser_Load(object sender, EventArgs e)
        {
            if (Id != Guid.Empty)
            {
                this.Text = "ویرایش کاربر";
                btnAdd_EditUser.Text = "ویرایش";
                lblIsActive.Visible = true;
                lblIsAdmin.Visible = true;
                chbIsActive.Visible = true;
                chbIsAdmin.Visible = true;

                var user = _userRepository.GetUserById(Id);

                if (user != null )
                {
                    txtAddress.Text = user.Address;
                    txtFirstName.Text = user.FirstName;
                    txtLastName.Text = user.LastName;
                    txtNationalCode.Text = user.NationalCode;
                    txtPhoneNumber.Text = user.PhoneNumber;
                    txtUserName.Text = user.UserName;
                    chbIsAdmin.Checked = user.IsAdmin;
                    chbIsActive.Checked = user.IsActive;
                }

            }
        }
    }
}
