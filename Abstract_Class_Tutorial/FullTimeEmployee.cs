using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Tutorial
{
    class FullTimeEmployee : BaseEmployee
    {
        public int AnnualSalary { get; set; }

        public override int GetMonthlySalary()
        {
            return this.AnnualSalary / 12;
        }
    }
}