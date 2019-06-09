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
    public partial class FormDictionaryManagement : Form
    {
        private bool SystemLocked;
        public FormDictionaryManagement(bool SystemLocked)
        {
            InitializeComponent();
            this.SystemLocked = SystemLocked;
        }

        List<string> listCategory = new List<string>();
        List<DictionaryField> listDictionary = new List<DictionaryField>();

        private void FormDictionarymanagement_Load(object sender, EventArgs e)                  // 载入复选框
        {
            listCategory.Clear();
            listDictionary = Business.GetListOfDictionary();
            foreach(DictionaryField df in listDictionary)
            {
                listCategory.Add(df.Category);
            }
            for(int i = 0; i < listCategory.Count; i++)
            {
                for(int j = i+1; j < listCategory.Count; j++)
                {
                    if (listCategory[i].CompareTo(listCategory[j])==0)
                    {
                        listCategory.RemoveAt(j);
                        j--;
                    }
                }
            }
            cbbCategory.Items.Clear();
            cbbCategory.DataSource = listCategory;
            cbbCategory.SelectedIndex = -1;
            lsvItems.Clear();
        }

        private void RefreshList()                                                                                                      // 刷新列表
        {
            if (cbbCategory.SelectedIndex < 0) return;
            listDictionary = Business.GetListOfDictionary();
            lsvItems.Items.Clear();
            foreach (DictionaryField df in listDictionary)
            {
                if (df.Category == cbbCategory.SelectedValue.ToString())
                {
                    lsvItems.Items.Add(df.Name);
                }
            }
        }

        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)               // 改变分类时自动刷新列表
        {
            RefreshList();
        }

        private void btnInsert_Click(object sender, EventArgs e)                                                  // 新建字典项
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            if (cbbCategory.SelectedIndex < 0)
            {
                Helper.ShowFail("请选择一个分类！");
                return;
            }
            string Name = txtName.Text.Trim();
            if (Name == "")
            {
                Helper.ShowFail("请输入正确的项！");
                return;
            }
            Business.AddDictionary(cbbCategory.SelectedValue.ToString(), Name);
            Helper.ShowSuccess("新增成功！");
            RefreshList();
        }

        private void btnDelete_Click(object sender, EventArgs e)                                                // 删除字典项
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            if (cbbCategory.SelectedIndex < 0)
            {
                Helper.ShowFail("请选择一个分类！");
                return;
            }
            if (lsvItems.SelectedItems.Count == 0)
            {
                Helper.ShowFail("请选择一个项！");
                return;
            }
            DialogResult dr = MessageBox.Show("是否删除选定项？", "操作询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Business.EraseDictionary(cbbCategory.SelectedValue.ToString().Trim(), lsvItems.SelectedItems[0].Text.Trim());
                // lsvItems.SelectedItems[0].ToString().Trim()会返回:  "ListViewItem: {Name}"
                Helper.ShowSuccess("删除成功！");
                RefreshList();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)                                            // 修改字典项
        {
            if (SystemLocked)
            {
                Helper.ShowFail("System is Locked!");
                return;
            }
            if (cbbCategory.SelectedIndex < 0)
            {
                Helper.ShowFail("请选择一个分类！");
                return;
            }
            if (lsvItems.SelectedItems.Count == 0)
            {
                Helper.ShowFail("请选择一个项！");
                return;
            }
            string Name = txtName.Text.Trim();
            if (Name == "")
            {
                Helper.ShowFail("请输入正确的项！");
                return;
            }
            Business.UpdateDictionary(cbbCategory.SelectedValue.ToString(), lsvItems.SelectedItems[0].Text.Trim(), Name);
            Helper.ShowSuccess("修改成功！");
            RefreshList();
        }
    }
}
