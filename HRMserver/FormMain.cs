using HRMserver.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions;

namespace HRMserver
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private bool SystemLocked = false;

        private void FormMain_Load(object sender, EventArgs e)                                                      // 载入窗体
        {
            FormLogin fl = new FormLogin();
            DialogResult dr = fl.ShowDialog();
            if (dr != DialogResult.OK)
            {
                Application.Exit();
            }
            User us = User.GetUser();
            tssInfo.Text = String.Format("欢迎{0}，登录时间：{1}", us.RealName, DateTime.Now.ToString());
        }

        private void tsmiLogQuery_Click(object sender, EventArgs e)                                               // 日志窗口
        {
            (new FormLogList()).ShowDialog();
        }

        private void tsmEmployee_Click(object sender, EventArgs e)                                                // 员工管理
        {
            FormEmployeeManagement fem = new FormEmployeeManagement(SystemLocked);
            fem.ShowDialog();
        }

        private void tsmDepartment_Click(object sender, EventArgs e)                                            // 部门管理
        {
            FormDepartmentManagement fdm = new FormDepartmentManagement(SystemLocked);
            fdm.ShowDialog();
        }

        private void tsmiNewSalarySheet_Click(object sender, EventArgs e)                                   // 薪资管理
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            FormSalaryManagement fsm = new FormSalaryManagement();
            fsm.ShowDialog();
        }

        private void tsmiDictionaryManagement_Click(object sender, EventArgs e)                       // 字典管理
        {
            FormDictionaryManagement fdm = new FormDictionaryManagement(SystemLocked);
            fdm.ShowDialog();
        }

        private void tsmiSalaryReport_Click(object sender, EventArgs e)                                         // 薪资表单
        {
            FormSalaryReport fsr = new FormSalaryReport();
            fsr.ShowDialog();
        }

        private void tsmiExit_Click(object sender, EventArgs e)                                                         // 关闭
        {
            Helper.ShowSuccess("Bye~");
            Application.Exit();
        }

        private void tsmiOperatorManagement_Click(object sender, EventArgs e)                           //操作员管理
        {
            User use = User.GetUser();
            if (use.Name != "admin")
            {
                Helper.ShowFail("Please Login as admin!");
                return;
            }
            FormOperatorManagement fom = new FormOperatorManagement();
            fom.ShowDialog();
        }

        private void tsmiChangeOperator_Click(object sender, EventArgs e)                                     // 切换账户
        {
            this.Visible = false;
            FormLogin fl = new FormLogin();
            DialogResult dr = fl.ShowDialog();
            if (dr != DialogResult.OK)
            {
                Application.Exit();
            }
            this.Visible = true;
            User us = User.GetUser();
            tssInfo.Text = String.Format("欢迎{0}，登录时间：{1}", us.RealName, DateTime.Now.ToString());
        }

        private void tsmiAccountManagement_Click(object sender, EventArgs e)                                // 账户管理
        {
            FormAccountManagement fam = new FormAccountManagement();
            fam.ShowDialog();
        }

        private void tsmiCalculator_Click(object sender, EventArgs e)                                                  // 计算器
        {
            FormCalculator fc = new FormCalculator();
            fc.Show();
        }

        private void tsmiDraft_Click(object sender, EventArgs e)                                                           // 画板
        {
            FormDraw fd = new FormDraw();
            fd.Show();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)                                                          // 关于
        {
            Helper.ShowSuccess("该软件由我国《著作权法》和《计算机软件保护条例》保护，未经软件著作权人及其合法受让者同意，禁止以商业目的复制、修改、传播此软件。所有版权归**所有。");
        }

        private void tsmiSystemLock_Click(object sender, EventArgs e)                                                // 锁定非查询功能
        {
            SystemLocked = !SystemLocked;
            if (SystemLocked)
            {
                this.tsmiSystemLock.Text = "解锁系统(U)";
            }
            else
            {
                this.tsmiSystemLock.Text = "锁定系统(L)";
            }
        }
    }
}
