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
    public class DictionaryServer
    {
        public static List<DictionaryField> GetListOfDictionary()                             // 获取字典中的字段   
        {
            string sql = "select * from Dictionary";
            List<DictionaryField> Res = new List<DictionaryField>();
            using (SqlDataReader sdr = SqlHelper.ExecuteReader(sql))
            {
                while (sdr.Read())
                {
                    DictionaryField df = new DictionaryField();
                    df.Id = (Guid)sdr["Id"];
                    df.Name = sdr["Name"].ToString();
                    df.Category = sdr["Category"].ToString();
                    Res.Add(df);
                }
            }
            return Res;
        }

        public static int AddDictionary(string Category,string Name)                        // 增加字典字段
        {
            string sql = "insert into Dictionary values(@Id,@Name,@Category)";
            SqlParameter[] p =
            {
                new SqlParameter("@Id",Guid.NewGuid()),
                new SqlParameter("@Name",Name),
                new SqlParameter("@Category",Category)
            };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public static int EraseDictionary(string Category, string Name)                     // 删除字典字段
        {
            string sql = "delete from Dictionary where Name=@Name and Category=@Category";
            SqlParameter[] p =
            {
                new SqlParameter("@Name",Name.Trim()),
                new SqlParameter("@Category",Category.Trim())
            };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public static int UpdateDictionary(string Category, string Name,string ToName)          // 修改字典字段
        {
            string sql = "update Dictionary set Name=@ToName where Name=@Name and Category=@Category";
            SqlParameter[] p =
            {
                new SqlParameter("@Name",Name),
                new SqlParameter("@Category",Category),
                new SqlParameter("@ToName",ToName)
            };
            return SqlHelper.ExecuteNonQuery(sql, p);
        }

        public static List<DictionaryField> SelectDictionary(string Category)           // 某分类的字段列表
        {
            string sql = "select * From Dictionary where Category=@Category)";
            SqlParameter[] p =
            {
                new SqlParameter("@Category",Category)
            };
            List<DictionaryField> list = new List<DictionaryField>();
            using (SqlDataReader sdr = SqlHelper.ExecuteReader(sql, p))
            {
                while (sdr.Read())
                {
                    DictionaryField df = new DictionaryField();
                    df.Category = Category;
                    df.Id = (Guid)sdr["Id"];
                    df.Name = sdr["Id"].ToString();
                    list.Add(df);
                }
            }
            return list;
        }
    }
}
