using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMserver.Model
{
    public class Operator
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsLocked { get; set; }
        public string RealName { get; set; }

        public Operator() { }
        public Operator(string userName, string password, string realName, bool isDelete, bool isLocked)
        {
            this.UserName = userName;
            this.Password = password;
            this.RealName = realName;
            this.IsDeleted = isDelete;
            this.IsLocked = isLocked;
        }

        public string Information()
        {
            string res = "";
            res += "用户名：" + UserName + "\n";
            res += "真实姓名：" + RealName + "\n";
            if (IsDeleted) res += "已被删除\n";
            if (IsLocked) res += "已被锁定\n";
            return res;
        }
    }


}
