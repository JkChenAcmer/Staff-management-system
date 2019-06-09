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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        double num;
        string now;
        bool haveDot;
        char flag;
        bool preIsFlag;

        private void FormCalculator_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void RefreshResult()                                                                    // 显示答案
        {
            lblTmp.Text = num.ToString();
            lblResult.Text = num.ToString();
        }

        private void ShowNow()                                                                          // 显示当前输入
        {
            lblTmp.Text = now;
            lblResult.Text = num.ToString();
        }

        private void Clear()                                                                                  // 清空
        {
            num = 0;
            now = "0";
            haveDot = false;
            flag = ' ';
            RefreshResult();
            preIsFlag = true;
        }

        private void MidClear()                                                                             // 部分清空          
        {
            now = "0";
            haveDot = false;
            preIsFlag = true;
        }

        private void append(string ap)                                                                  // 输入
        {
            if (flag == '=')                    // 前一个操作为=后，下一个输入数字重新开始
            {
                Clear();
            }
            now += ap;
            while (now.Length > 1)
            {
                if (now[0] == '0' && now[1] != '.')
                {
                    now = now.Remove(0, 1);
                }
                else break;
            }
            ShowNow();
            preIsFlag = false;
        }

        private void Solve()                                                                                    // 计算
        {
            if (now == "" || preIsFlag) return; // 连续键入操作符，无视前一个
            double num2 = double.Parse(now);
            if(flag == ' ')
            {
                num = num2;
            }
            else if (flag == '=')   // 前一次为=时，符号可以继续操作
            {
                return;
            }
            else if(flag == '+')
            {
                num += num2;
            }
            else if (flag == '-')
            {
                num -= num2;
            }
            else if (flag == '*')
            {
                num *= num2;
            }
            else if (flag == '/')
            {
                num /= num2;
            }
            flag = ' ';
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            append("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            append("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            append("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            append("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            append("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            append("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            append("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            append("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            append("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            append("0");
        }

        private void btnDot_Click(object sender, EventArgs e)                                           // 点
        {
            if (!haveDot)
            {
                append(".");
                haveDot = true;
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)                                         // 等于
        {
            Solve();
            MidClear();
            RefreshResult();
            flag = '=';
        }

        private void btnClear_Click(object sender, EventArgs e)                                              // 清除
        {
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)                                               // 加
        {
            Solve();
            MidClear();
            ShowNow();
            flag = '+';
        }

        private void btnSub_Click(object sender, EventArgs e)                                              // 减
        {
            Solve();
            MidClear();
            ShowNow();
            flag = '-';
        }

        private void btnMul_Click(object sender, EventArgs e)                                              // 乘
        {
            Solve();
            MidClear();
            ShowNow();
            flag = '*';
        }

        private void btnDivide_Click(object sender, EventArgs e)                                              // 除
        {
            Solve();
            MidClear();
            ShowNow();
            flag = '/';
        }

        private void btnBack_Click(object sender, EventArgs e)                               // 后退
        {
            if (now.Length == 1)
            {
                now = "0";
            }
            else if (now.Length > 1)
            {
                now=now.Remove(now.Length - 1, 1);
            }
            ShowNow();
        }

        private void btnPow_Click(object sender, EventArgs e)                               // 操作等同于=
        {
            Solve();
            MidClear();
            num *= num;
            RefreshResult();
            flag = '=';
        }

        private void btnSqrt_Click(object sender, EventArgs e)                               // 操作等同于=
        {
            Solve();
            MidClear();
            num = Math.Sqrt(num);
            RefreshResult();
            flag = '=';
        }

        private void FormCalculator_Resize(object sender, EventArgs e)
        {
            int X = this.Width, Y = this.Height;
            int x = this.gbAll.Width, y = this.gbAll.Height;
            this.gbAll.Left = (X - x) / 2;
            this.gbAll.Top = (Y - y) / 2;
        }
    }
}
