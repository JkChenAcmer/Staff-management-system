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
    public partial class FormSalaryReport : Form
    {
        public FormSalaryReport()
        {
            InitializeComponent();
        }

        private List<Department> ListOfDepartments;
        private List<Employee> ListOfEmployees;
        private void FormSalaryReport_Load(object sender, EventArgs e)
        {

            DateTime NowTime = DateTime.Now;
            int YearNow = NowTime.Year;
            cbbYear.Items.Clear();
            for (int i = YearNow - 10; i <= YearNow + 10; i++)
            {
                cbbYear.Items.Add(i);
            }
            cbbMonth.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                cbbMonth.Items.Add(i);
            }
            ListOfDepartments = Business.DepartmentList();
            ListOfEmployees = Business.GetListOfEmployee();
            cbbDept.Items.Clear();
            cbbDept.DisplayMember = "Name";
            cbbDept.ValueMember = "Id";
            cbbDept.DataSource = ListOfDepartments;
            cbbMonth.SelectedIndex = cbbYear.SelectedIndex = cbbDept.SelectedIndex = -1;
        }

        private void btnInsure_Click(object sender, EventArgs e)
        {
            if (cbbDept.SelectedIndex == -1 || cbbMonth.SelectedIndex == -1 || cbbYear.SelectedIndex == -1)
            {
                Helper.ShowFail("请选择正确的项！");
                return;
            }
            int year = int.Parse(cbbYear.Text);
            int month = int.Parse(cbbMonth.Text);
            Guid deptId = (Guid)cbbDept.SelectedValue;

            Guid sheetId = Business.GetSheetId(year, month, deptId);
            if (sheetId == Guid.Empty)
            {
                Helper.ShowFail("请先生成薪资单！");
                return;
            }
            DataTable dt = Business.GetTableOfSalary(sheetId);
            List<SalarySheetItemForReport> Items = new List<SalarySheetItemForReport>();
            foreach(DataRow dr in dt.Rows)
            {
                SalarySheetItemForReport item = new SalarySheetItemForReport();
                item.BaseSalary = (decimal)dr["基本工资"];
                item.Bouns = (decimal)dr["奖金"];
                item.EmployeeName = dr["姓名"].ToString();
                item.Fine = (decimal)dr["应扣"];
                item.Other = (decimal)dr["其他"];
                Items.Add(item);
            }
            rptSalaryReport report = new rptSalaryReport();
            report.SetDataSource(Items);
            report.SetParameterValue("Year", year);
            report.SetParameterValue("Month", month);
            report.SetParameterValue("Dept", cbbDept.Text);

            crvSalaryReport.ReportSource = report;
        }

        private void FormSalaryReport_Resize(object sender, EventArgs e)                                        // 自动改变控件大小
        {
            int W = this.Width, H = this.Height;
            this.gbOne.Width = W - 40;
            this.gbOne.Height = H - 105;
            this.btnInsure.Left = W - 123;
        }
    }
}
