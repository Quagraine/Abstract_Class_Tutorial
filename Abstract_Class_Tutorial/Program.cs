using System;

namespace Abstract_Class_Tutorial
{
    class Program
    {
         public static void Main(string[] args)
        {
            FullTimeEmployee fte = new FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Mark",
                LastName = "Tonto",
                AnnualSalary = 600000
            };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());
            Console.WriteLine("----------------------");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Jane",
                LastName = "Friend",
                HourlyRate = 390,
                TotalHoursWorked = 40
            };

            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());
            Console.WriteLine("----------------------");
            Console.ReadLine();
        }
    }
}
