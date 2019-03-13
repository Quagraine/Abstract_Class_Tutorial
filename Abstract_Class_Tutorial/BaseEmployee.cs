using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_Class_Tutorial
{
    public abstract class BaseEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public abstract int GetMonthlySalary();
    }
}