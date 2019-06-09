using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMserver.Model;
using HRMserver.DAL;
using System.Data;

namespace HRMserver.BLL
{
    public class Business
    {
        public enum FindResult { OK, UserError, PasswordError, IsDeleted, IsLocked };
        public enum DeleteDepartmentResult { HaveEmployee, DepartmentError, Ok };
        public enum InsertDepartmentResult { IdError, ExistNow, Ok};
        public enum UpdateDepartmentResult { DepartmentError, Ok };
        public enum UpdatePasswordResult { OK, PasswordError };

        static public FindResult FindOperator(string user,string pwd)       // 登陆信息
        {
            Operator op = OperatorAndLogServer.Find(user);
            Log log;
            FindResult fr;
            if (op == null)
            {
                log = new Log(Guid.Empty, DateTime.Now, user + ":用户名不存在！");
                fr = FindResult.UserError;
            }
            else if (op.Password.CompareTo(pwd) != 0)
            {
                log = new Log(op.Id, DateTime.Now, user + ":密码错误！");
                fr = FindResult.PasswordError;
            }
            else if (op.IsDeleted)
            {
                log = new Log(op.Id, DateTime.Now, user + ":此用户被删除！");
                fr = FindResult.IsDeleted;
            }
            else if (op.IsLocked)
            {
                log = new Log(op.Id, DateTime.Now, user + ":此用户被锁定！");
                fr = FindResult.IsLocked;
            }
            else
            {
                log = new Log(op.Id, DateTime.Now, user + ":登陆成功！");
                User us = User.GetUser();
                us.Id = op.Id;
                us.Name = op.UserName;
                us.Password = op.Password;
                us.RealName = op.RealName;

                fr = FindResult.OK;
            }
            OperatorAndLogServer.Addlog(log);
            return fr;
        }

 // 操作员管理
        static public string GetOperatorInfor(string user)                  // 查询操作员信息
        {
            Operator op = OperatorAndLogServer.Find(user);
            string res = "";
            if (op == null)
            {
                res = "查询不到此用户!";
            }
            else
            {
                res = "所查询的信息为：\n";
                res = op.Information();
            }
            return res;
        }

        static public void UpdateOperatorName(string user, string name)
        {
            OperatorAndLogServer.UpdateOperatorName(user, name);
        }

        static public void LockOperator(string user)                        // 锁定用户
        {
            OperatorAndLogServer.Lock(user);
        }

        static public void UnLockOperator(string user)                        // 解锁用户
        {
            OperatorAndLogServer.UnLock(user);
        }

        static public void DeleteOperator(string user)                      // 删除用户 
        {
            OperatorAndLogServer.Delete(user);
        }

        static public void UpdateOperatorPassword(string user, string pwd)  // 更新用户密码
        {
            OperatorAndLogServer.UpdatePassword(user, pwd);
            User us = User.GetUser();
            us.Password = pwd;
        }

        static public bool CreateOperator(Operator op)                      // 新建操作员
        {
            return OperatorAndLogServer.Insert(op);
        }

        static public string OperatorList()                                 // 操作员列表
        {
            return OperatorAndLogServer.GetOperatorList();
        }

 // 日志管理
        static public void InitPages(ref int Pnum,ref int Pages)            // 日志表-初始化页数
        {
            OperatorAndLogServer.InitPages(ref Pnum, ref Pages);
        }
        static public DataTable GetDataTableOfLog(int begin,int end)        // 日志表-翻页
        {
            return OperatorAndLogServer.GetDataTableOfLog(begin, end);
        }


 // 部门管理        
        static public List<Department> DepartmentList()                     // 部门列表
        {
            List<Department> res = new List<Department>();
        DepartmentServer.FullListOfDepartment(res);
            return res;
        }
        static public DeleteDepartmentResult DeleteDepartment(Guid Id)      // 删除部门
        {
            int res = DepartmentServer.DeleteDepartment(Id);
            if(res == -1)
            {
                return DeleteDepartmentResult.HaveEmployee;
            }
            else
            {
                if(res == 0)
                {
                    return DeleteDepartmentResult.DepartmentError;
                }
                else
                {
                    return DeleteDepartmentResult.Ok;
                }
            }
        }

        static public UpdateDepartmentResult UpdateDepartment(Guid id,string toName)    // 更改部门名称
        {
            int res = DepartmentServer.UpdateDepartment(id, toName);
            if(res == 0)
            {
                return UpdateDepartmentResult.DepartmentError;
            }
            else
            {
                return UpdateDepartmentResult.Ok;
            }
        }

        static public InsertDepartmentResult InsertDepartment(string name)  // 新建部门
        {
            if( DepartmentServer.SearchDepartment(name) > 0)
            {
                return InsertDepartmentResult.ExistNow;
            }
            Guid Id = Guid.NewGuid();
            if( DepartmentServer.SearchDepartment(Id) > 0)
            {
                return InsertDepartmentResult.IdError;
            }
            DepartmentServer.insertDepartment(Id, name);
            return InsertDepartmentResult.Ok;
        }



 // 雇员管理
        static public bool AddEmployee(Employee emp)
        {
            return EmployeeServer.AddEmployee(emp) > 0;
        }

        static public Employee GetEmployee(Guid Id)
        {
            return EmployeeServer.GetEmployee(Id);
        }

        static public bool UpdateEmployee(Employee emp)
        {
            return EmployeeServer.UpdateEmployee(emp) > 0;
        }

        static public bool EraseEmployee(Guid Id)
        {
            return EmployeeServer.EraseEmployee(Id) > 0;
        }

        static public List<Employee> GetListOfEmployee()
        {
            return EmployeeServer.GetListOfEmployee();
        }

        static public DataTable GetDataTableOfEmployee(List<string> sqls)   // 雇员数据表
        {
            return EmployeeServer.GetDataTableOfEmployee(sqls);
        }

 // 薪资表管理
        static public Guid GetSheetId(int year, int month, Guid DeptId)
        {
            return SalaryServer.GetSheetId(year, month, DeptId);
        }
        static public Guid NewSheet(int year, int month, Guid DeptId)
        {
            return SalaryServer.NewSheet(year, month, DeptId);
        }

        static public void InitSheetItems(SalarySheet sheet)
        {
            SalaryServer.InitSheetItems(sheet);
        }

        static public DataTable GetTableOfSalary(Guid SheetId)
        {
            return SalaryServer.GetTableOfSalary(SheetId);
        }

        static public void UpdateSalaryItem(SalarySheetItem item)
        {
            SalaryServer.UpdateSalaryItem(item);
        }

 // 字典管理
        static public List<DictionaryField> GetListOfDictionary()
        {
            return DictionaryServer.GetListOfDictionary();
        }
        public static bool AddDictionary(string Category, string Name)
        {
            return DictionaryServer.AddDictionary(Category, Name) > 0;
        }
        public static bool EraseDictionary(string Category, string Name)
        {
            int ct = DictionaryServer.EraseDictionary(Category, Name);
            return ct > 0;
        }
        public static bool UpdateDictionary(string Category, string Name, string ToName)
        {
            return DictionaryServer.UpdateDictionary(Category, Name, ToName) > 0;
        }
        public static List<DictionaryField> SelectDictionary(string Category)
        {
            return DictionaryServer.SelectDictionary(Category);
        }
    }
}
