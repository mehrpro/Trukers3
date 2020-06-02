using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLB;
using CLD;

namespace Trukers3
{
    public partial class FrmLogin : Form
    {
        TruckersEntities db = new TruckersEntities();
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
