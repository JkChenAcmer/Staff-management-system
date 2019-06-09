using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMserver
{
    class SalarySheetItemForReport
    {
        public string EmployeeName { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bouns { get; set; }
        public decimal Fine { get; set; }
        public decimal Other { get; set; }
    }
}
