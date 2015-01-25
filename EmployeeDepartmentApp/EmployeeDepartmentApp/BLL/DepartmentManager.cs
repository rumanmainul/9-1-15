using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDepartmentApp.DAL.DAO;
using EmployeeDepartmentApp.DAL.DbGateway;

namespace EmployeeDepartmentApp.BLL
{
    public class DepartmentManager
    {
        DbGateway aDbGateway = new DbGateway();

        internal List<Department> GetAllDepartment()
        {
            List<Department> aDepartments = new List<Department>();
            aDepartments = aDbGateway.GetAllDepartmentFromDb();
            return aDepartments;
        }
    }
}