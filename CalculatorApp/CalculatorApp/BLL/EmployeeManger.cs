using CalculatorApp.DAL;
using CalculatorApp.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorApp.BLL
{
    public class EmployeeManger
    {
        EmployeeGateway employeeGateway = new EmployeeGateway();
        public int Insert(Employee employee)
        {
           return employeeGateway.Insert(employee);
        }

        internal List<Employee> GetEmployeesByDeptId(int deptId)
        {
            return employeeGateway.GetEmployeesByDeptId(deptId);
        }

        internal void ConfirmEmployee(int selectedEmployeeId)
        {
             employeeGateway.ConfirmEmployee(selectedEmployeeId);
        }
    }
}