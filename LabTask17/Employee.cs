using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask17
{
    internal class Employee
    {
        protected string Name { get; set; }
        protected int Id { get; set; }
        protected double Salary { get; set; }

        public Employee(string name, int id, double salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public virtual void DisplayInfo()
        {
            Console.Write($"Name = {Name}, Id = {Id}, Salary = {Salary}");
        }
    }
}
