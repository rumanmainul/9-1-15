using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentApp.DAL.DAO
{
    public class Employee
    {
        public string EmployeeId { set; get; }
        public string EmployeeName { set; get; }
        public string Address { set; get; }
        public string DepartmentId { set; get; }
        public bool IsConfirmed { set; get; }
    }
}