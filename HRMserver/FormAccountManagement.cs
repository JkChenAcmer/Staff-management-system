using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMserver.Model;
using HRMserver.BLL;

namespace HRMserver
{
    public partial class FormAccountManagement : Form
    {
        public FormAccountManagement()
        {
            InitializeComponent();
        }

        private User user = User.GetUser();

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string pwdOld = Helper.GetMD5(txtOldPassword.Text.Trim());
            string pwdNew = Helper.GetMD5(txtNewPassword.Text.Trim());
            string pwdRepeat = Helper.GetMD5(txtRepeatPassword.Text.Trim());
            if (pwdNew != pwdRepeat)
            {
                Helper.ShowFail("请输入相同密码！");
                return;
            }
            if (this.user.Password.CompareTo(pwdOld) != 0)
            {
                Helper.ShowFail("请输入正确密码！");
                return;
            }
            Business.UpdateOperatorPassword(this.user.Name, pwdNew);
            Helper.ShowSuccess("修改密码成功！");
        }

        private void btnUpdateRealName_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (name != "")
            {
                Business.UpdateOperatorName(user.Name, name);
                user.RealName = name;
                Helper.ShowSuccess("修改姓名成功！");
            }
        }

        private void FormAccountManagement_Resize(object sender, EventArgs e)
        {
            int X = this.Width, Y = this.Height;
            int top = (Y - 465) / 3;
            int left = (X - 360) / 2;
            this.groupBox1.Top = top;
            this.groupBox1.Left = left;
            this.groupBox3.Top = top * 2 + this.groupBox1.Height ;
            this.groupBox3.Left = left;
        }
    }
}
