using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using  EmployeeDepartmentApp.DAL.DAO;

namespace EmployeeDepartmentApp.DAL.DbGateway
{
    public class DbGateway
    {
        private DatabaseConnection aDbConnection;
        internal List<Department> GetAllDepartmentFromDb()
        {
            List<Department> aDepartmentList = new List<Department>();
            aDbConnection = new DatabaseConnection();
            string DepartmentQuery = "SELECT * FROM Departments";
            SqlCommand aCommand = new SqlCommand(DepartmentQuery, aDbConnection.GetConnection());
            SqlDataReader aReader = aCommand.ExecuteReader();
            while (aReader.Read())
            {
                Department aDepartment = new Department();
                aDepartment.Dpt_Id = aReader["Id"].ToString();
                aDepartment.DepartmentName = aReader["Name"].ToString();
                aDepartmentList.Add(aDepartment);
            }
            aDbConnection.CloseConnection();
            return aDepartmentList;
        }

        internal int SaveEmployeeToDB(Employee aEmployee)
        {
            int Id = 0;
            string EmployeeInsertQuery = "INSERT INTO Employees VALUES('"+aEmployee.EmployeeName+"', '"+aEmployee.Address+"', '"+aEmployee.DepartmentId+"', '"+aEmployee.IsConfirmed+"')";
            string idQuery = "SELECT MAX(Id) as ID from Employees";
            aDbConnection = new DatabaseConnection();
            SqlCommand aCommand = new SqlCommand(EmployeeInsertQuery, aDbConnection.GetConnection());
            int RowEffected = aCommand.ExecuteNonQuery();
            if (RowEffected > 0)
            {
                aCommand.CommandText = idQuery;
                SqlDataReader aReader = aCommand.ExecuteReader();
                aReader.Read();
                Id = Convert.ToInt32(aReader["ID"]);
            }
            return Id;
        }
    }
}