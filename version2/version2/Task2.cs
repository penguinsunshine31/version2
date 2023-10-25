using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace version2
{
    public class Task2
    {
        class Employee
        {
            private string _employeeName;
            public string Salary { get; set; }

            public Employee(string name, string salary)
            {
                _employeeName = name;
                Salary = salary;
            }

            public string DisplayInfo()
            {
                return $"Hi, I'm {_employeeName} and I earn {Salary} per year.";
            }
        }
        public void task2()
        {
            Employee employee = new Employee("John", "$60,000");

            string info = employee.DisplayInfo();
            Console.WriteLine(info);




        }


    }
}
