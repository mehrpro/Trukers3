using System;
using System.Windows.Forms;
using CLB;
using CLD;

namespace Trukers3
{
    public partial class FrmLogin : Form
    {
        QMS db = new QMS();
        private IUserModule _userModule;
        public FrmLogin()
        {
            InitializeComponent();
            _userModule = new UserModule(db);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_userModule.LoginUser(txtUserName.Text,txtPassword.Text.Trim()))
            {
                PublicVar.LoginTest = true;
                Close();
            }
            else
            {
                MessageBox.Show("نام کاربری یا رمز عبور اشتباه است دوباره تلاش کنید", Text, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
