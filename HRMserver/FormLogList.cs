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

namespace HRMserver
{
    public partial class FormLogList : Form
    {
        private int Page = 1, Pages=0, Pnum=0;                          // 当前页，总页数，总条数
        private bool Locked;

        public FormLogList()
        {
            InitializeComponent();
        }

        private void showPage()                                         // 显示页数
        {   
            this.lblPageNow.Text = string.Format("第{0}页", Page);
        }
        private void btnPre_Click(object sender, EventArgs e)           // 往前翻页
        {
            Page--;
            if (Page == 0) Page++;
            Flip(Page);
        }
        private void btnBegin_Click(object sender, EventArgs e)         // 翻到第一页
        {
            Page = 1;
            Flip(Page);
        }
        private void btnNext_Click(object sender, EventArgs e)          // 往后翻页
        {
            Page++;
            if (Page > Pages) Page--;
            Flip(Page);
        }
        private void btnLast_Click(object sender, EventArgs e)          // 翻到最后一页
        {
            Page = Pages;
            Flip(Page);
        }

        private void FormLogList_Load(object sender, EventArgs e)       // 载入窗体
        {
            Business.InitPages(ref Pnum, ref Pages);
            this.lblPages.Text = string.Format("共{0}页", Pages);
            Flip(1);
        }

        private void Flip(int p)                                        // 翻到第p页
        {
            if (p > Pages || p < 1) return;
            int p1 = p * 14 - 13;
            int p2 = p * 14;
            if (p2 > Pnum) p2 = Pnum;
            DataTable dt = Business.GetDataTableOfLog(p1, p2);
            this.dgvLog.DataSource = dt;
            showPage();
        }
    }
}
