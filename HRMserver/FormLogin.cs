using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMserver.DAL;
using HRMserver.BLL;
using HRMserver.Model;

namespace HRMserver
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)                     // 登陆
        {
            string user = txtUser.Text.Trim();
            string pwd = txtPassword.Text.Trim();
            pwd = Helper.GetMD5(pwd);
            Business.FindResult fr = Business.FindOperator(user, pwd);
            if (fr == Business.FindResult.UserError)
            {
                Helper.ShowFail("找不到此用户！");
            }
            else if(fr == Business.FindResult.PasswordError)
            {
                Helper.ShowFail("密码错误！");
            }
            else if (fr == Business.FindResult.IsDeleted)
            {
                Helper.ShowFail("此用户已被删除！");
            }
            else if (fr == Business.FindResult.IsLocked)
            {
                Helper.ShowFail("此用户已被锁定！");
            }
            else
            {
                Helper.ShowSuccess("登陆成功！");
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)                    // 取消
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
