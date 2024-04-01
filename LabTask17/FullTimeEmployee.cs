using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask17
{
    internal class FullTimeEmployee : Employee
    {
        int VacationDays { get; set; }

        public FullTimeEmployee(string name, int id, double salary, int vacationDays) : base(name, id, salary)
        {
            VacationDays = vacationDays;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($", VacationDays = {VacationDays}");
        }
    }
}
