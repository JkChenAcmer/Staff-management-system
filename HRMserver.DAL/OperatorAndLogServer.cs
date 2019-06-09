using HRMserver.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.ComponentModel;
using System.Drawing;

namespace HRMserver.DAL
{
    public class OperatorAndLogServer
    {
        public static Operator Find(string user)                                        //查询操作员
        {
            Operator op = null;
            string sql = "SELECT * FROM Operator WHERE UserName=@UserName";

            using (SqlDataReader sdr = SqlHelper.ExecuteReader(sql, new SqlParameter("@UserName", user)))
            {
                if (sdr.Read())
                {
                    op = new Operator();
                    op.Id = (Guid)sdr["Id"];
                    op.IsDeleted = (bool)sdr["IsDeleted"];
                    op.IsLocked = (bool)sdr["IsLocked"];
                    op.UserName = sdr["UserName"].ToString();
                    op.Password = sdr["Password"].ToString();
                    op.RealName = sdr["RealName"].ToString();
                }
                sdr.Close();
            }

            return op;
        }

        public static bool Insert(Operator op)                                          // 添加操作员
        {
            Operator result = Find(op.UserName);
            if (result != null) // 已存在
            {
                return false;
            }

            Guid g = Guid.NewGuid();
            string sql = string.Format("INSERT INTO Operator(Id,UserName,Password,RealName,IsDeleted,IsLocked) VALUES('{0}','{1}','{2}','{3}','0','0')", g, op.UserName, op.Password, op.RealName);
            SqlHelper.ExecuteNonQuery(sql);
            return true;
        }

        public static void UpdateOperatorName(string user,string name)
        {
            string sql = string.Format("UPDATE Operator SET RealName='{0}' WHERE UserName='{1}'", name, user);
            SqlHelper.ExecuteNonQuery(sql);
        }

        public static void Delete(string user)                                          // 删除操作员
        {
            string sql = string.Format("UPDATE Operator SET IsDeleted=1 WHERE UserName='{0}'", user);
            SqlHelper.ExecuteNonQuery(sql);
        }

        public static void Lock(string user)                                            // 锁定操作员
        {
            string sql = string.Format("UPDATE Operator SET IsLocked=1 WHERE UserName='{0}'", user);
            SqlHelper.ExecuteNonQuery(sql);
        }

        public static void UnLock(string user)                                            // 解锁操作员
        {
            string sql = string.Format("UPDATE Operator SET IsLocked=0 WHERE UserName='{0}'", user);
            SqlHelper.ExecuteNonQuery(sql);
        }

        public static bool UpdatePassword(string user,string pwd)       // 修改操作员密码
        {
            string sql = string.Format("UPDATE Operator SET Password='{0}'WHERE UserName='{1}'", pwd, user);

            SqlHelper.ExecuteNonQuery(sql);
            return true;
        }

        public static string GetOperatorList()                                                  // 操作员列表
        {
            string res = "";
            
            string sql = string.Format("SELECT * FROM Operator");

            List<string> Lock = new List<string>();
            List<string> Delete = new List<string>();

            using (SqlDataReader sdr = SqlHelper.ExecuteReader(sql))
            {
                while (sdr.Read())
                {
                    bool sta = false;
                    if ((bool)sdr["IsLocked"])
                    {
                        Lock.Add(sdr["UserName"].ToString());
                        sta = true;
                    }
                    if ((bool)sdr["IsDeleted"])
                    {
                        Delete.Add(sdr["UserName"].ToString());
                        sta = true;
                    }
                    if (sta) continue;
                    res += sdr["UserName"].ToString();
                    res += "\n";
                }
                sdr.Close();
            }

            res += "\n被锁定名单：\n";
            foreach(string s in Lock)
            {
                res += s + "\n";
            }
            res += "\n被删除名单：\n";
            foreach (string s in Delete)
            {
                res += s + "\n";
            }
            return res;
        }


        /*****************************************************************************************************/


        public static bool Addlog(Log log) // 添加日志
        {
            string sql = string.Format("INSERT INTO OperationLog VALUES(NEWID(),@OpId,@Time,@Desc)");
            int n = SqlHelper.ExecuteNonQuery(sql,
                    new SqlParameter("@OpId", log.OperatorID),
                    new SqlParameter("@Time", log.LoginTime),
                    new SqlParameter("@Desc", log.LoginDesc)
                );

            if (n > 0) return true;
            return false;
        }

        public static void InitPages(ref int num,ref int page) // 初始化页数
        {
            string sql = string.Format("select count(*) from OperationLog");
            int ct = (int)SqlHelper.ExecuteScalar(sql);
            num = ct;
            page = (ct + 13) / 14;
        }

        public static DataTable GetDataTableOfLog(int begin, int end) // 填充日志表－翻页
        {
            string sql = string.Format("select top {0} * from OperationLog where id not in(select top {1} id from OperationLog)", end - begin + 1, begin - 1);
            return SqlHelper.GetDataTable(sql);
        }
    }
    
}
