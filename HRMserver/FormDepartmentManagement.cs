using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMserver.BLL;
using HRMserver.Model;

namespace HRMserver
{
    public partial class FormDepartmentManagement : Form
    {
        private bool SystemLocked;
        public FormDepartmentManagement(bool SystemLocked)
        {
            InitializeComponent();
            this.SystemLocked = SystemLocked;
        }

        private List<Department> Depts = new List<Department>();

        private void FormDepartmentManagement_Load(object sender, EventArgs e)          // 载入窗体
        {
            FullListOfDepartment();
            FullListView();
        }

        private void FullListOfDepartment()                                             // 载入部门列表
        {
            Depts = Business.DepartmentList();
        }
        private void FullListView()                                                     // 填充表格
        {
            this.ltvDepartment.Items.Clear();
            foreach (Department d in Depts)
            {
                this.ltvDepartment.Items.Add(d.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)                           // 新建部门
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            string Name = txtName.Text;
            Business.InsertDepartmentResult idr = Business.InsertDepartment(Name);
            if (idr == Business.InsertDepartmentResult.IdError)
            {
                Helper.ShowFail("生成ID错误，请稍后再试！");
            }
            else if(idr == Business.InsertDepartmentResult.ExistNow)
            {
                Helper.ShowFail("此部门已存在！");
            }
            else
            {
                Helper.ShowSuccess("新建部门成功！");
                FullListOfDepartment();
                FullListView();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)                        // 删除部门
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            string Name = txtName.Text;
            Business.DeleteDepartmentResult ddr;
            foreach (Department d in Depts)
            {
                if (d.Name == Name)
                {
                    ddr = Business.DeleteDepartment(d.Id);
                    if (ddr == Business.DeleteDepartmentResult.HaveEmployee)
                    {
                        Helper.ShowFail("此部门还存在员工，无法直接删除！");
                        return;
                    }
                    else if(ddr == Business.DeleteDepartmentResult.Ok)
                    {
                        Helper.ShowSuccess("删除成功！");
                        FullListOfDepartment();
                        FullListView();
                        return;
                    }
                }
            }
            Helper.ShowFail("此部门不存在！");
        }

        private void btnUpdate_Click(object sender, EventArgs e)                        // 更新部门信息
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            string Name = txtName.Text,NameTo = txtToName.Text;
            foreach (Department d in Depts)
            {
                if (d.Name == Name)
                {
                    Business.UpdateDepartment(d.Id, NameTo);
                    Helper.ShowSuccess("更改成功！");
                    FullListOfDepartment();
                    FullListView();
                    return;
                }
            }
            Helper.ShowFail("此部门不存在！");
        }
    }
}
