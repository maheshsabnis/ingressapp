using System;
using System.Collections.Generic;

namespace DeptAPI.Models
{
    public class Department
    {
        public int DeptNo { get; set; }
        public string DeptName { get; set; }
    }


    public class Departments : List<Department>
    {
        public Departments()
        {
            Add(new Department() { DeptNo=10,DeptName="D1"});
            Add(new Department() { DeptNo = 20, DeptName = "D2" });
        }
    }
}
