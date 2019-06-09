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
    public class EmployeeServer
    {
        public static DataTable GetDataTableOfEmployee(List<string> sqls)               // 雇员-数据表
        {
            string sql = "select a.Id 编号,a.Number 工号,a.Name 姓名,a.InDay 入职时间,a.Nation 民族,a.NativePlace 籍贯  from Employee a,Department b WHERE a.DepartmentId=b.Id";
            foreach(string s in sqls)
            {
                sql += " AND " + s;
            }
            return SqlHelper.GetDataTable(sql);
        }

        public static Employee GetEmployee(Guid Id)                                     // 通过Id获取雇员对象
        {
            string sql = "select * from Employee where Id=@Id";
            Employee emp = new Employee();
            using (SqlDataReader sdr = SqlHelper.ExecuteReader(sql, new SqlParameter("@Id", Id)))
            {
                if (sdr.Read())
                {
                    emp = new Employee()
                    {
                        Id = Id,
                        Name = sdr["Name"].ToString(),
                        GenderId = (Guid)sdr["GenderId"],
                        MarriageId = (Guid)sdr["MarriageId"],
                        EducationId = (Guid)sdr["EducationId"],
                        DepartmentId = (Guid)sdr["DepartmentId"],
                        PartyId = (Guid)sdr["PartyId"],
                        BirthDay = (DateTime)sdr["BirthDay"],
                        InDay = (DateTime)sdr["InDay"],
                        Number = sdr["Number"].ToString(),
                        Nation = sdr["Nation"].ToString(),
                        NativePlace = sdr["NativePlace"].ToString(),
                        Telephone = sdr["Telephone"].ToString(),
                        Address = sdr["Address"].ToString(),
                        Remarks = sdr["Remarks"].ToString(),
                        Resume = sdr["Resume"].ToString(),
                        Email = sdr["Email"].ToString()
                    };
                    if (sdr["Photo"] == DBNull.Value)
                    {
                        emp.Photo = null;
                    }
                    else
                    {
                        emp.Photo = (byte[])sdr["Photo"];
                    }
                }
            }
            return emp;
        }

        public static SqlParameter[] GetParametersOfEmployee(Employee emp)              // 获取雇员对象的参数列表
        {
            SqlParameter paramPhoto = new SqlParameter("@Photo", SqlDbType.Image);
            if (emp.Photo == null)
            {
                paramPhoto.Value = DBNull.Value;
            }
            else
            {
                paramPhoto.Value = emp.Photo;
            }
            SqlParameter[] ps = new SqlParameter[]
            {
                new SqlParameter("@Id",emp.Id),
                new SqlParameter("@Number",emp.Number),
                new SqlParameter("@Name",emp.Name),
                new SqlParameter("@InDay",emp.InDay),
                new SqlParameter("@BirthDay",emp.BirthDay),
                new SqlParameter("@MarriageId",emp.MarriageId),
                new SqlParameter("@PartyId",emp.PartyId),
                new SqlParameter("@EducationId",emp.EducationId),
                new SqlParameter("@GenderId",emp.GenderId),
                new SqlParameter("@DepartmentId",emp.DepartmentId),
                new SqlParameter("@Telephone",emp.Telephone),
                new SqlParameter("@Address",emp.Address),
                new SqlParameter("@Email",emp.Email),
                new SqlParameter("@Remarks",emp.Remarks),
                new SqlParameter("@Resume",emp.Resume),
                new SqlParameter("@Nation",emp.Nation),
                new SqlParameter("@NativePlace",emp.NativePlace),
                paramPhoto
            };
            return ps;
        }

        public static int UpdateEmployee(Employee emp)                                  // 修改雇员信息
        {
            string sql = "update Employee set Number=@Number,Name=@Name,InDay=@InDay,BirthDay=@BirthDay,MarriageId=@MarriageId,PartyId=@PartyId,EducationId=@EducationId,GenderId=@GenderId,DepartmentId=@DepartmentId,Telephone=@Telephone,Address=@Address,Email=@Email,Remarks=@Remarks,Resume=@Resume,Photo=@Photo,Nation=@Nation,NativePlace=@NativePlace where Id=@Id";
            SqlParameter[] ps = GetParametersOfEmployee(emp);
            int res = SqlHelper.ExecuteNonQuery(sql, ps);
            return res;
        }

        public static int AddEmployee(Employee emp)                                     // 添加雇员
        {
            string sql = "insert into Employee values(@Id,@Number,@Name,@InDay,@BirthDay,@MarriageId,@PartyId,@EducationId" +
                ",@GenderId,@DepartmentId,@Telephone,@Address,@Email,@Remarks,@Resume,@Photo,@Nation,@NativePlace)";
            SqlParameter[] ps = GetParametersOfEmployee(emp);
            return SqlHelper.ExecuteNonQuery(sql, ps);
        }

        public static int EraseEmployee(Guid Id)                                                 // 删除雇员
        {
            string sql = "delete from Employee where Id=@Id";
            return SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@Id", Id));
        }

        public static List<Employee> GetListOfEmployee()                                // 雇员列表
        {
            List<Employee> list=new List<Employee>();
            string sql = "select Id From Employee";
            using (SqlDataReader sdr = SqlHelper.ExecuteReader(sql))
            {
                while (sdr.Read())
                {
                    Guid id = (Guid)sdr["Id"];
                    list.Add(GetEmployee(id));
                }
            }
            return list;
        }
    }
}
