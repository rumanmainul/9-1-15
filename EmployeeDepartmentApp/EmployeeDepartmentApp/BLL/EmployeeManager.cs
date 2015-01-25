using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeDepartmentApp.DAL.DAO;
using EmployeeDepartmentApp.DAL.DbGateway;

namespace EmployeeDepartmentApp.BLL
{
    public class EmployeeManager
    {

        internal string SaveEmployee(Employee aEmployee)
        {
            DbGateway aDbGateway = new DbGateway();
            int SaveData = aDbGateway.SaveEmployeeToDB(aEmployee);
            string Em_Id = Convert.ToString(SaveData);
            return Em_Id;
        }
    }
}