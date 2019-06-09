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
    public class DepartmentServer
    {
        public static void FullListOfDepartment(List<Department> list)                      // 返回部门列表
        {
            list.Clear();
            string sql = "SELECT * FROM Department";
            using (SqlDataReader sdr = SqlHelper.ExecuteReader(sql))
            {
                while(sdr.Read())
                {
                    Department d = new Department();
                    d.Id = (Guid)sdr["Id"];
                    d.Name = sdr["Name"].ToString();
                    list.Add(d);
                }
            }
        }

        public static int DeleteDepartment(Guid id)                                         // 删除部门，部门有员工则返回-1
        {
            int ct = SearchDepartmentExistEmployee(id);
            if (ct > 0)
            {
                return -1;
            }
            string sql = "DELETE FROM Department WHERE id = @Id";
            SqlParameter sp = new SqlParameter("@Id", id);
            ct = SqlHelper.ExecuteNonQuery(sql, sp);
            return ct;
        }

        public static int UpdateDepartment(Guid id,string ToName)
        {
            string sql = "UPDATE Department SET Name = @Name WHERE Id = @Id";
            SqlParameter sp1 = new SqlParameter("@Id", id);
            SqlParameter sp2 = new SqlParameter("@Name", ToName);
            int ct = SqlHelper.ExecuteNonQuery(sql, sp1, sp2);
            return ct;
        }

        public static int SearchDepartmentExistEmployee(Guid id)                             // 查找部门是否有员工
        {
            string sql = "SELECT COUNT(*) FROM Employee WHERE departmentId = @deptId";
            SqlParameter sp = new SqlParameter("@deptId", id);
            int ct = (int)SqlHelper.ExecuteScalar(sql, sp);
            return ct;
        }

        public static int SearchDepartment(Guid id)                                         // 检查是否存在当前部门Id
        {
            string sql = "SELECT COUNT(*) FROM Department WHERE Id = @Id";
            SqlParameter sp = new SqlParameter("@Id", id);
            int ct = (int)SqlHelper.ExecuteScalar(sql, sp);
            return ct;
        }

        public static int SearchDepartment(string name)                                     // 检查是否存在当前部门名字
        {
            string sql = "SELECT COUNT(*) FROM Department WHERE Name = @Name";
            SqlParameter sp = new SqlParameter("@Name", name);
            int ct = (int)SqlHelper.ExecuteScalar(sql, sp);
            return ct;
        }

        public static void insertDepartment(Guid id,string name)                            // 新建部门
        {
            if (SearchDepartment(id) > 0) return;
            string sql = "INSERT INTO Department VALUES(@Id,@Name)";
            SqlParameter sp1 = new SqlParameter("@Id", id);
            SqlParameter sp2 = new SqlParameter("@Name", name);
            SqlHelper.ExecuteNonQuery(sql, sp1, sp2);
        }
    }
}
