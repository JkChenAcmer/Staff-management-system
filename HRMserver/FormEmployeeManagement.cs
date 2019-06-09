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
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace HRMserver
{
    public partial class FormEmployeeManagement : Form
    {
        private bool SystemLocked;
        public FormEmployeeManagement(bool SystemLocked)
        {
            InitializeComponent();
            this.SystemLocked = SystemLocked;
        }

        private void FormEmployeeManagement_Load(object sender, EventArgs e)            // 载入窗体
        {
            cbbDepartment.Items.Clear();
            cbbDepartment.DataSource = Business.DepartmentList();
            cbbDepartment.DisplayMember = "Name";
            cbbDepartment.ValueMember = "Id";

            List<string> Empty = new List<string>();
            this.dgvEmployee.DataSource = Business.GetDataTableOfEmployee(Empty);
        }

        private void btnSearch_Click(object sender, EventArgs e)                        // 按条件检索员工
        {
            List<String> sqls = new List<string>();
            string sql = "";
            if (ckbName.Checked)
            {
                sql = string.Format("a.Name like '%{0}%'", txtName.Text);
                sqls.Add(sql);
            }
            if (ckbDepartment.Checked)
            {
                sql = string.Format("a.DepartmentId=(SELECT Id FROM Department WHERE Name='{0}')", cbbDepartment.Text);
                sqls.Add(sql);
            }
            if (ckbTime.Checked)
            {
                sql = string.Format("(a.InDay>='{0}' and a.InDay<='{1}')", dtpFrom.Value.ToString(), dtpTo.Value.ToString());
                sqls.Add(sql);
            }

            this.dgvEmployee.DataSource = Business.GetDataTableOfEmployee(sqls);
            
        }

        private void tsbAddEmployee_Click(object sender, EventArgs e)                   // 打开添加员工窗口
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            FormEmployeeAddOrUpdate fe = new FormEmployeeAddOrUpdate();
            fe.ShowDialog();
            List<string> Empty = new List<string>();
            this.dgvEmployee.DataSource = Business.GetDataTableOfEmployee(Empty);
        }

        private void tsbUpdateEmployee_Click(object sender, EventArgs e)                // 打开更新员工窗口
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                string Id = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(Id))
                {
                    Helper.ShowFail("请选择一个正确的行！");
                }
                else
                {
                    Guid id = Guid.Parse(Id);
                    Employee emp = Business.GetEmployee(id);
                    FormEmployeeAddOrUpdate fem = new FormEmployeeAddOrUpdate(emp);
                    if (fem.ShowDialog() == DialogResult.OK)
                    {
                        List<string> Empty = new List<string>();
                        this.dgvEmployee.DataSource = Business.GetDataTableOfEmployee(Empty);
                    }
                }
            }
            else
            {
                Helper.ShowFail("请选择至少一行！");
            }
        }

        private void tsbEraseEmployee_Click(object sender, EventArgs e)                     // 删除员工
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            if (dgvEmployee.SelectedRows.Count > 0)
            {
                string Id = dgvEmployee.SelectedRows[0].Cells[0].Value.ToString();
                if (string.IsNullOrEmpty(Id))
                {
                    Helper.ShowFail("请选择一个正确的行！");
                }
                else
                {
                    Employee emp = Business.GetEmployee(Guid.Parse(Id));
                    if (MessageBox.Show(string.Format("确认要删除员工：{0}?", emp.Name), "确认信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK) return;
                    Guid id = Guid.Parse(Id);

                    if (Business.EraseEmployee(id))
                    {
                        Helper.ShowSuccess("删除成功！");
                        List<string> Empty = new List<string>();
                        this.dgvEmployee.DataSource = Business.GetDataTableOfEmployee(Empty);
                    }
                    else
                    {
                        Helper.ShowFail("删除失败！");
                    }
                }
            }
            else
            {
                Helper.ShowFail("请选择至少一行！");
            }
        }

        private void tsbExpert_Click(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Excel(97-2003)|*.xls";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.Cancel)
            {
                return;
            }
            dgvEmployee.AllowUserToAddRows = false;
            HSSFWorkbook workbook = new HSSFWorkbook();
            ISheet sheet = workbook.CreateSheet("employee");
            IRow rowHead = sheet.CreateRow(0);
            
            for (int i = 0; i < dgvEmployee.Columns.Count; i++)
            {
                rowHead.CreateCell(i, CellType.String).SetCellValue(dgvEmployee.Columns[i].HeaderText.ToString());
            }

            for (int i = 0; i < dgvEmployee.Rows.Count; i++)
            {
                IRow row = sheet.CreateRow(i + 1);
                for (int j = 0; j < dgvEmployee.Columns.Count; j++)
                {
                    row.CreateCell(j, CellType.String).SetCellValue(dgvEmployee.Rows[i].Cells[j].Value.ToString());
                }
            }

            using (FileStream stream = File.OpenWrite(fileDialog.FileName))
            {
                workbook.Write(stream);
                stream.Close();
            }
            Helper.ShowSuccess("导出数据成功！");
            GC.Collect();
        }

    }
}
