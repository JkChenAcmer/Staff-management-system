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
    public partial class FormOperatorManagement : Form
    {
        public FormOperatorManagement()
        {
            InitializeComponent();
        }

        private User user = User.GetUser();

        private void RefreshInfor()
        {
            txtInfor.Text = "您的信息为：\n";
            txtInfor.Text += Business.GetOperatorInfor(this.user.Name) + "\n";
            txtInfor.Text += "当前的操作员有：\n";
            txtInfor.Text += Business.OperatorList();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            /*FormLogin fl = new FormLogin();
            DialogResult dr = fl.ShowDialog();
            if (dr != DialogResult.OK)
            {
                Application.Exit();
            }*/
            RefreshInfor();
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (this.user.Name != "admin")
            {
                Helper.ShowFail("当前用户无操作权限！");
                return;
            }
            string user = txtUser.Text.Trim();
            if (user == this.user.Name)
            {
                Helper.ShowFail("无法锁定当前登陆用户！");
                return;
            }
            Business.LockOperator(user);
            Helper.ShowSuccess("锁定成功！");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.user.Name != "admin")
            {
                Helper.ShowFail("当前用户无操作权限！");
                return;
            }
            string user = txtUser.Text.Trim();
            if (user == this.user.Name)
            {
                Helper.ShowFail("无法删除当前登陆用户！");
                return;
            }
            Business.DeleteOperator(user);
            Helper.ShowSuccess("删除成功！");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.user.Name != "admin")
            {
                Helper.ShowFail("当前用户无操作权限！");
                return;
            }
            string user = txtUser.Text.Trim();
            string res = Business.GetOperatorInfor(user);
            if (res.Length == 8)
            {
                Helper.ShowFail(res);
            }
            else
            {
                Helper.ShowSuccess(res);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.user.Name != "admin")
            {
                Helper.ShowFail("当前用户无操作权限！");
                return;
            }
            string user = txtUser2.Text.Trim();
            string pwd = txtPassword2.Text.Trim();
            pwd = Helper.GetMD5(pwd);
            string realName = txtRealName2.Text.Trim();
            Operator op = new Operator(user, pwd, realName, false, false);
            bool result = Business.CreateOperator(op);
            if (result)
            {
                Helper.ShowSuccess("添加成功！");
            }
            else
            {
                Helper.ShowFail("此用户已存在！");
            }
            RefreshInfor();
        }

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
            if (this.user.Password.CompareTo(pwdOld)!=0)
            {
                Helper.ShowFail("请输入正确密码！");
                return;
            }
            Business.UpdateOperatorPassword(this.user.Name, pwdNew);
            Helper.ShowSuccess("修改密码成功！");
        }

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            if (this.user.Name != "admin")
            {
                Helper.ShowFail("当前用户无操作权限！");
                return;
            }
            string user = txtUser.Text.Trim();
            Business.UnLockOperator(user);
            Helper.ShowSuccess("解锁成功！");
        }
    }
}
