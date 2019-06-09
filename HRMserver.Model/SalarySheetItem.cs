using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMserver.Model
{
    public class SalarySheetItem
    {
        public SalarySheetItem() { }

        public SalarySheetItem(Guid Id, Guid SheetId, string EmployeeName,Guid EmployeeId, double BaseSalary, double Bonus, double Fine, double Other)
        {
            this.Id = Id;
            this.SheetId = SheetId;
            this.EmployeeName = EmployeeName;
            this.EmployeeId = EmployeeId;
            this.BaseSalary = BaseSalary;
            this.Bonus = Bonus;
            this.Fine = Fine;
            this.Other = Other;
        }
        public Guid Id { get; set; }
        public Guid SheetId { get; set; }
        public string EmployeeName { get; set; }
        public Guid EmployeeId { get; set; }
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }
        public double Fine { get; set; }
        public double Other { get; set; }
    }
}
