using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace HRMserver
{
    public partial class FormDraw : Form
    {
        public FormDraw()
        {
            InitializeComponent();
            this.pictureBox.MouseWheel += new MouseEventHandler(PictureBox_MouseWheel);
            // pictureBox没有焦点，需要自己手动加入鼠标滚动事件
        }
        private Bitmap image;  
        int width;              //画布大小
        int height;
        int currentXpos = 0;
        int currentYpos = 0;

        int PenSize = 4;                                        // 画笔大小
        Color PenColor = Color.Black;                 // 画笔颜色
        Color BackColor = Color.Honeydew;       // 画布颜色
        
        bool beginMove = false;                           // 是否在画图
        bool IsEraser = false;                               // 是否是橡皮

        private void FormDraw_Load(object sender, EventArgs e)              // 载入画布
        {
            width = this.pictureBox.Width;
            height = this.pictureBox.Height;
            image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.Clear(BackColor);
            pictureBox.Image = image;
            RefreshLabel();
        }

        private void RefreshLabel()                                                                 // 显示当前画笔设置
        {
            this.lblSize.Text = PenSize.ToString();
            string res = PenColor.ToString();
            res = res.Remove(res.Length - 1, 1);
            int i;
            for (i = 0; i < res.Length; i++)
            {
                if (res[i] == '[')
                {
                    i++; break;
                }
            }
            this.lblColor.Text = res.Substring(i);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)      // 鼠标左键
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXpos = e.X;
                currentYpos = e.Y;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)      // 鼠标移动
        {
            if (beginMove)
            {
                Graphics g = Graphics.FromImage(image);
                Pen pen = new Pen(PenColor, PenSize);
                if (IsEraser)   // 橡皮画出背景色即可
                {
                    pen.Color = BackColor;
                    pen.Width *= 2;
                }
                g.DrawLine(pen, currentXpos, currentYpos, e.X, e.Y);

                pictureBox.Image = image;
                g.Dispose();
                currentXpos = e.X;
                currentYpos = e.Y;
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)      // 鼠标放开
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = false;
                currentXpos = currentYpos = 0;
            }
        }

        private void tsmiClear_Click(object sender, EventArgs e)                            // 清空
        {
            image = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(image);
            g.Clear(Color.Honeydew);
            pictureBox.Image = image;
        }

        private void PictureBox_MouseWheel(object sender, MouseEventArgs e)     // 滚轮设置画笔大小
        {
            if (e.Delta > 0)
            {
                this.PenSize += 2;
                if (PenSize > 16)
                {
                    PenSize = 16;
                }
            }
            else
            {
                this.PenSize -= 2;
                if (PenSize < 2)
                {
                    PenSize = 2;
                }
            }
            RefreshLabel();
        }

        private void tsmiBack_Click(object sender, EventArgs e)                                     // 退出
        {
            this.Close();
        }

        private void tsmiSave_Click(object sender, EventArgs e)                                     // 保存
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                image.Save(sfd.FileName + @".jpeg", ImageFormat.Jpeg);
            }
        }

        private void tsmiSet_Click(object sender, EventArgs e)                                      // 设置画笔
        {
            FormDrawSet fds = new FormDrawSet(PenSize, PenColor);
            if (fds.ShowDialog() == DialogResult.OK)
            {
                this.PenColor = fds.PenColor;
                this.PenSize = fds.PenSize;
                RefreshLabel();
            }
        }

        private void tsmiChange_Click(object sender, EventArgs e)                                   // 橡皮擦 
        {
            IsEraser = !IsEraser;
            if (IsEraser)
            {
                tsmiChange.Text = "画笔(P)";
            }
            else
            {
                tsmiChange.Text = "橡皮(E)";
            }
        }
    }
}
