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
    public class SalaryServer
    {
        public static Guid GetSheetId(int year,int month,Guid DeptId)                                               // 查询并返回薪资表
        {
            string sql = "SELECT Id From SalarySheet Where Year=@Year And Month=@Month And DepartmentId=@DepartmentId";
            SqlParameter[] p =
            {
                new SqlParameter("@Year",year),
                new SqlParameter("@Month",month),
                new SqlParameter("@DepartmentId",DeptId)
            };
            Guid SheetId = Guid.Empty;
            using (SqlDataReader sdr = SqlHelper.ExecuteReader(sql, p))
            {
                if (sdr.Read())
                {
                    SheetId = (Guid)sdr["Id"];
                }
            }
            return SheetId;
        }

        public static Guid NewSheet(int year, int month, Guid DeptId)                                               // 新建薪资表
        {
            Guid SheetId = Guid.NewGuid();
            string sql = "Insert into SalarySheet values(@Id, @Year, @Month, @DepartmentId)";
            SqlParameter[] p =
            {
                new SqlParameter("@Id",SheetId),
                new SqlParameter("@Year",year),
                new SqlParameter("@Month",month),
                new SqlParameter("@DepartmentId",DeptId)
            };
            int ct = SqlHelper.ExecuteNonQuery(sql, p);
            if (ct == 0)
            {
                return Guid.Empty;  //failed
            }
            SalarySheet sheet = new SalarySheet();
                sheet.DepartmentId = DeptId;
                sheet.Id = SheetId;
                sheet.Month = month;
                sheet.Year = year;
            InitSheetItems(sheet);
            return sheet.Id;
        }

        public static void InitSheetItems(SalarySheet sheet)                                                              // 初始化薪资表
        {
            string sql = "Delete From SalarySheetItem where SheetId=@SheetId";
            SqlHelper.ExecuteNonQuery(sql, new SqlParameter("@SheetId", sheet.Id));
            List<Employee> list = EmployeeServer.GetListOfEmployee();
            sql = "Insert into SalarySheetItem values(@Id, @SheetId, @EmployeeId, 0, 0, 0, 0)";
            
            foreach(Employee emp in list)
            {
                if (emp.DepartmentId != sheet.DepartmentId) continue;
                SqlParameter[] p =
                {
                    new SqlParameter("@Id",Guid.NewGuid()),
                    new SqlParameter("@SheetId",sheet.Id),
                    new SqlParameter("@EmployeeId",emp.Id),
                };
                SqlHelper.ExecuteNonQuery(sql, p);
            }
        }

        public static DataTable GetTableOfSalary(Guid SheetId)                                                      // 获取薪资表的项
        {
            string sql = "select item.Id 编号,emp.Name 姓名,item.BaseSalary 基本工资,item.Bonus 奖金,item.Fine 应扣,item.Other 其他 " +
                "from Employee emp,SalarySheetItem item " +
                "where emp.Id=item.EmployeeId and item.SheetId=@SheetId";
            return SqlHelper.GetDataTable(sql, new SqlParameter("@SheetId", SheetId));
        }

        public static void UpdateSalaryItem(SalarySheetItem item)                                                  // 更新薪资表
        {
            string sql = "update SalarySheetItem set BaseSalary=@BaseSalary, Bonus=@Bonus, Fine=@Fine, Other=@Other " +
                "where Id=@ItemId";
            SqlParameter[] p =
            {
                new SqlParameter("ItemId",item.Id),
                new SqlParameter("BaseSalary",item.BaseSalary),
                new SqlParameter("Bonus",item.Bonus),
                new SqlParameter("Fine",item.Fine),
                new SqlParameter("Other",item.Other)
            };
            SqlHelper.ExecuteNonQuery(sql, p);
        }
    }
}
