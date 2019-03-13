using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Tutorial
{
    public class ContractEmployee : BaseEmployee
    {
        public int HourlyRate { get; set; }
        public int TotalHoursWorked { get; set; }

        public override int GetMonthlySalary()
        {
            return this.HourlyRate * this.TotalHoursWorked;
        }
    }
}
