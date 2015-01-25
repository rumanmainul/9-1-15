using CalculatorApp.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CalculatorApp.DAL
{
    public class DepartmentGateway
    {
        public List<Department> GetAllDepartments()
        {

            List<Department> departments = new List<Department>();
            string connectionString = @"Data Source= (local)\sqlexpress; Database=EmployeeDepartment; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            var query = "SELECT * FROM Departments";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Department dept = new Department();
                dept.Id = (int)reader["Id"];
                dept.Name = reader["Name"].ToString();
                departments.Add(dept);
            }

            reader.Close();
            connection.Close();

            return departments;
        }
    }
}