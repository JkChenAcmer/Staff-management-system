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
using System.IO;

namespace HRMserver
{
    public partial class FormEmployeeAddOrUpdate : Form
    {
        private List<DictionaryField> Dic;
        private List<Department> Depts = new List<Department>();
        private byte[] photo;
        private Employee emp;

        public FormEmployeeAddOrUpdate()
        {
            InitializeComponent();
        }
        public FormEmployeeAddOrUpdate(Employee emp)                                // 重载构造方法
        {
            InitializeComponent();
            this.emp = emp;
        }

        private void FromEmployeeAddOrUpdate_Load(object sender, EventArgs e)       // 载入窗体
        {
            InitDictionary();
            Depts = Business.DepartmentList();
            cbbDepartmentId.DataSource = Depts;
            cbbDepartmentId.DisplayMember = "Name";
            cbbDepartmentId.ValueMember = "Id";
            if (emp!=null)
            {
                txtAddress.Text = emp.Address;
                txtEmail.Text = emp.Email;
                txtName.Text = emp.Name;
                txtNation.Text = emp.Nation;
                txtNativePlace.Text = emp.NativePlace;
                txtNumber.Text = emp.Number;
                txtRemarks.Text = emp.Remarks;
                txtResume.Text = emp.Resume;
                txtTelephone.Text = emp.Telephone;
                cbbDepartmentId.SelectedValue = emp.DepartmentId;
                cbbEducationId.SelectedValue = emp.EducationId;
                cbbGenderId.SelectedValue = emp.GenderId;
                cbbMarriageId.SelectedValue = emp.MarriageId;
                cbbPartyId.SelectedValue = emp.PartyId;
                foreach (DictionaryField df in Dic)
                {
                    if (df.Id == emp.DepartmentId)
                    {
                        cbbDepartmentId.Text = df.Name;
                    }
                    if (df.Id == emp.EducationId)
                    {
                        cbbEducationId.Text = df.Name;
                    }
                    if (df.Id == emp.GenderId)
                    {
                        cbbGenderId.Text = df.Name;
                    }
                    if (df.Id == emp.MarriageId)
                    {
                        cbbMarriageId.Text = df.Name;
                    }
                    if (df.Id == emp.PartyId)
                    {
                        cbbPartyId.Text = df.Name;
                    }
                }
                photo = emp.Photo;                // 二进制数组变成图片
                MemoryStream stream = new MemoryStream(photo);
                picPhoto.Image = Image.FromStream(stream);
            }
        }

        private void InitDictionary()                                               // 初始化字典字段
        {
            Dic = Business.GetListOfDictionary();
            List<DictionaryField> L1 = new List<DictionaryField>(), L2 = new List<DictionaryField>(), L3 = new List<DictionaryField>(), L4 = new List<DictionaryField>();
            foreach (DictionaryField df in Dic)
            {
                if (df.Category == "学历")
                {
                    L1.Add(df);
                }
                else if(df.Category == "婚姻状况")
                {
                    L2.Add(df);
                }
                else if (df.Category == "性别")
                {
                    L3.Add(df);
                }
                else if (df.Category == "政治面貌")
                {
                    L4.Add(df);
                }
            }
            cbbEducationId.DataSource = L1;
            cbbMarriageId.DataSource = L2;
            cbbGenderId.DataSource = L3;
            cbbPartyId.DataSource = L4;

            cbbEducationId.DisplayMember = "Name";
            cbbEducationId.ValueMember = "Id";
            cbbGenderId.DisplayMember = "Name";
            cbbGenderId.ValueMember = "Id";
            cbbMarriageId.DisplayMember = "Name";
            cbbMarriageId.ValueMember = "Id";
            cbbPartyId.DisplayMember = "Name";
            cbbPartyId.ValueMember = "Id";
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)               // 选择照片按钮
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "所有文件|*.*|JPG|*.jpg|GIF|*.gif|BMP|*.bmp|PNG|*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                photo = File.ReadAllBytes(fd.FileName);
                this.picPhoto.Image = new Bitmap(fd.FileName);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)               // 添加或更新按钮
        {
            Employee emp = new Employee()
            {
                Id = Guid.NewGuid(),
                Name = txtName.Text.Trim(),
                GenderId = (Guid)cbbGenderId.SelectedValue,
                MarriageId = (Guid)cbbMarriageId.SelectedValue,
                EducationId = (Guid)cbbEducationId.SelectedValue,
                DepartmentId = (Guid)cbbDepartmentId.SelectedValue,
                PartyId = (Guid)cbbPartyId.SelectedValue,
                BirthDay = dtpBirthDay.Value,
                InDay = dtpInDay.Value,
                Number = txtNumber.Text.Trim(),
                Nation = txtNation.Text.Trim(),
                NativePlace = txtNativePlace.Text.Trim(),
                Telephone = txtTelephone.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                Remarks = txtRemarks.Text.Trim(),
                Resume = txtResume.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Photo = photo
            };
            if (this.emp != null)
            {
                emp.Id = this.emp.Id;
                if (Business.UpdateEmployee(emp))
                {
                    Helper.ShowSuccess("更新成功！");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Helper.ShowFail("更新失败！");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                if (Business.AddEmployee(emp))
                {
                    Helper.ShowSuccess("添加成功！");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    Helper.ShowFail("添加失败！");
                    this.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)                    // 取消按钮
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
