using CalculatorApp.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CalculatorApp.DAL
{
    public class EmployeeGateway
    {
        public int Insert(Employee employee)
        {
            int Id = 0;
            string connectionString = @"Data Source= (local)\sqlexpress; Database=EmployeeDepartment; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            var query = String.Format("INSERT INTO Employees(FirstName,Address,Dept_Id,IsConfirmed) Values('{0}','{1}','{2}', '{3}')", employee.Name, employee.Address, employee.DepartmentId, employee.IsConfirmed);
            var idRetrievalQuery = "SELECT MAX(Id) FROM Employees";
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            
            if(rowAffected>0)
            {
                command.CommandText = idRetrievalQuery;
                
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Id = Convert.ToInt32(reader[0]);
                reader.Close();
                connection.Close();
            }

            return Id;

        }

        public void ConfirmEmployee(int selectedEmployeeId)
        {
            string connectionString = @"Data Source= (local)\sqlexpress; Database=EmployeeDepartment; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            //var query = String.Format("INSERT INTO Employees(FirstName,Address,Dept_Id) Values('{0}','{1}','{2}')", employee.Name, employee.Address, employee.DepartmentId);
        }

        public List<Employee> GetEmployeesByDeptId(int deptId)
        {
            string connectionString = @"Data Source= (local)\sqlexpress; Database=EmployeeDepartment; Integrated Security = true";

            SqlConnection connection = new SqlConnection(connectionString);

            return null;
            //var query = String.Format("INSERT INTO Employees(FirstName,Address,Dept_Id) Values('{0}','{1}','{2}')", employee.Name, employee.Address, employee.DepartmentId);
        }
    }
}