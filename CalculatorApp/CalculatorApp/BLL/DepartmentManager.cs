using CalculatorApp.DAL;
using CalculatorApp.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CalculatorApp.BLL
{
    public class DepartmentManager
    {
        DepartmentGateway gateway = new DepartmentGateway();
        public List<Department> GetAllDepartments()
        {
            return gateway.GetAllDepartments();
        }
    }
}