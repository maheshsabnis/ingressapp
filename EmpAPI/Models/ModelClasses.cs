using System;
using System.Collections.Generic;

namespace EmpAPI.Models
{
    public class Employee
    {
        public int EmpNo { get; set; }
        public string EmpName { get; set; }
    }

    public class Employees : List<Employee>
    {
        public Employees()
        {
            Add(new Employee() { EmpNo = 101, EmpName = "A"});
            Add(new Employee() { EmpNo = 102, EmpName = "B"});
        }
    }
}
