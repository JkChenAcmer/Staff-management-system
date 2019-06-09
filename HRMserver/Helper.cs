using HRMserver.DAL;
using HRMserver.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMserver
{
    public class Helper
    {
        public static void ShowFail(string str)
        {
            MessageBox.Show(str, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ShowSuccess(string str)
        {
            MessageBox.Show(str, "成功信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static string GetMD5(string pwd)
        {
            MD5 md5 = MD5.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(pwd);
            byte[] bytesMd5 = md5.ComputeHash(bytes);

            StringBuilder sb = new StringBuilder();
            foreach(byte b in bytesMd5)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }
        
    }
}
