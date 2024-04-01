using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask17
{
    internal class PartTimeEmployee : Employee
    {
        int HoursWorked { get; set; }

        public PartTimeEmployee(string name, int id, double salary, int hoursWorked) : base (name, id, salary)
        {
            HoursWorked = hoursWorked;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($", HoursWorked = {HoursWorked}");
        }
    }
}
