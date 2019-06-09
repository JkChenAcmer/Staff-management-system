using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRMserver.BLL;
using HRMserver.Model;

namespace HRMserver
{
    public partial class FormSalaryManagement : Form
    {
        public FormSalaryManagement()
        {
            InitializeComponent();
        }

        private List<Department> ListOfDepartments;
        private List<Employee> ListOfEmployees;
        SalarySheet sheet;

        private void FromSalaryManagement_Load(object sender, EventArgs e)
        {
            DateTime NowTime = DateTime.Now;
            int YearNow = NowTime.Year;
            cbbYear.Items.Clear();
            for(int i= YearNow - 10; i<= YearNow + 10; i++)
            {
                cbbYear.Items.Add(i);
            }
            cbbMonth.Items.Clear();
            for(int i = 1; i <= 12; i++)
            {
                cbbMonth.Items.Add(i);
            }
            ListOfDepartments = Business.DepartmentList();
            ListOfEmployees = Business.GetListOfEmployee();
            cbbDept.Items.Clear();
            cbbDept.DisplayMember = "Name";
            cbbDept.ValueMember = "Id";
            cbbDept.DataSource = ListOfDepartments;

            dgvSalarySheet.Font= new Font("宋体", 15);
            dgvSalarySheet.RowHeadersVisible = false;//datagridview前面的空白部分去除
            //dgvSalarySheet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
        }

        private void btnNewSalarySheet_Click(object sender, EventArgs e)
        {
            string Year = cbbYear.Text.Trim();
            string Month = cbbMonth.Text.Trim();
            Guid DeptId = (Guid)cbbDept.SelectedValue;
            if (Year == "" || Month == "" || DeptId == null)
            {
                Helper.ShowFail("请输入正确的年、月或部门！");
                return;
            }

            int count = 0;
            foreach(Employee emp in ListOfEmployees)
            {
                if (emp.DepartmentId == DeptId) { count++; }
            }
            if (count == 0)
            {
                Helper.ShowFail("请选择至少有一个员工在部门！");
                return;
            }

            Guid SheetId = Business.GetSheetId(int.Parse(Year), int.Parse(Month), DeptId);
            sheet = new SalarySheet();
                sheet.DepartmentId = DeptId;
                sheet.Id = SheetId;
                sheet.Month = int.Parse(Month);
                sheet.Year = int.Parse(Year);

            if (SheetId == Guid.Empty)
            {
                SheetId = Business.NewSheet(int.Parse(Year), int.Parse(Month), DeptId);
                sheet.Id = SheetId;
            }
            else
            {
                DialogResult dr = MessageBox.Show
                    ("已存在工资表，是否重新生成？\n点击确定删除已有表，点击取消加载现有表！","信息",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    Business.InitSheetItems(sheet);
                }
            }
            DataTable dt = Business.GetTableOfSalary(SheetId);
            this.dgvSalarySheet.DataSource = dt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sheet == null || sheet.Id == null || sheet.Id == Guid.Empty)
            {
                Helper.ShowFail("请选择正确的表！");
                return;
            }
            for(int i = 0; i < this.dgvSalarySheet.Rows.Count; i++)
            {
                if (this.dgvSalarySheet.Rows[i].Cells[0].Value == null) { break; }
                Guid ItemId = (Guid)this.dgvSalarySheet.Rows[i].Cells[0].Value;
                string Name = this.dgvSalarySheet.Rows[i].Cells[1].Value.ToString();
                double BaseSalary = double.Parse(this.dgvSalarySheet.Rows[i].Cells[2].Value.ToString());
                double Bonus = double.Parse(this.dgvSalarySheet.Rows[i].Cells[3].Value.ToString());
                double Fine = double.Parse(this.dgvSalarySheet.Rows[i].Cells[4].Value.ToString());
                double Other = double.Parse(this.dgvSalarySheet.Rows[i].Cells[5].Value.ToString());
                SalarySheetItem item = new SalarySheetItem(ItemId, sheet.Id, Name,Guid.Empty, BaseSalary, Bonus, Fine, Other);
                Business.UpdateSalaryItem(item);
            }
            Helper.ShowSuccess("保存成功！");
        }
    }
}
