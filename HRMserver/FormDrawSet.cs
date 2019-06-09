using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMserver
{
    public partial class FormDrawSet : Form
    {
        public FormDrawSet()
        {
            InitializeComponent();
        }

        public Color PenColor;
        public int PenSize;

        public FormDrawSet(int size,Color c)
        {
            InitializeComponent();
            PenColor = c;
            PenSize = size;
        }

        private void FormDrawSet_Load(object sender, EventArgs e)
        {
            this.tbSize.Maximum = 16;
            this.tbSize.Minimum = 2;
            RefreshForm();
        }

        private void RefreshForm()
        {
            this.tbSize.Value = PenSize;
            this.lblSize.Text = PenSize.ToString();
            string res = PenColor.ToString();
            res = res.Remove(res.Length - 1, 1);
            int i;
            for (i = 0; i < res.Length; i++)
            {
                if (res[i] == '[')
                {
                    i++;break;
                }
            }
            this.lblColor.Text = res.Substring(i);
        }

        private void tbSize_ValueChanged(object sender, EventArgs e)
        {
            this.PenSize = tbSize.Value;
            RefreshForm();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                PenColor = cd.Color;
            }
            RefreshForm();
        }

        private void btnInsure_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
