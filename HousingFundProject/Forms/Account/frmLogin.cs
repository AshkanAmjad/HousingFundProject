using HousingFund.DAL.Repositories.Implementation;
using HousingFund.DAL.Repositories.Interface;
using HousingFund.DAL.ViewModels.Security.Login;
using HousingFundProject.Forms.Messages;
using HousingFundProject.Forms.Selection;
using HousingFundProject.Utilities;

namespace HousingFundProject.Account
{
    public partial class frmLogin : Form
    {
        private readonly IUserRepository _userRepository;

        public frmLogin()
        {
            InitializeComponent();

            _userRepository = new UserRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool validation = Validation();
            string message = "عملیات ورود با شکست مواجه شده است";
            string checkedMessage = "";

            if (validation)
            {
                try
                {
                    LoginVM loginVM = new()
                    {
                        UserName = txtUserName.Text,
                        Password = txtPassword.Text,
                    };
                    bool result = _userRepository.Login(loginVM, out checkedMessage);

                    if (result)
                    {
                        pnlMain.Visible = false;
                        pnlIsLoading.Visible = true;

                        message = "ورود با موفقیت انجام شد.";
                        frmMessage messageForm = new(message);
                        messageForm.Show();

                        timer2.Enabled = true;
                    }
                    else
                    {
                        message = checkedMessage;
                        lblUserError.Visible = true;
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
            else
            {
                message = "داده های ورودی نا معتبر است.";
            }

            lblUserError.Text = message;
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateAndTimeFormat.DateFormat();
        }

        private bool Validation()
        {
            lblRequiredUserName.Visible = false;
            lblRequiredPassword.Visible = false;

            bool result = true;

            if (txtUserName.Text == "")
            {
                lblRequiredUserName.Visible = true;
                result = false;
            }

            if (txtPassword.Text == "")
            {
                lblRequiredPassword.Visible = true;
                result = false;
            }

            return result;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateAndTimeFormat.TimeFormat();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();

            frmSelection selection = new();
            selection.Show();

            timer2.Enabled = false;
        }
    }
}
