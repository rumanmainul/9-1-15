using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EmployeeDepartmentApp.DAL.DbGateway
{
    public class DatabaseConnection
    {
        private SqlConnection aSqlConnection;

        public SqlConnection GetConnection()
        {
            string ConectionStr = @"Data Source=(local)\sqlexpress; Database=EmployeeDepartment; Integrated Security = true";
            aSqlConnection = new SqlConnection(ConectionStr);
            aSqlConnection.Open();
            return aSqlConnection;
        }

        public void CloseConnection()
        {
            if (aSqlConnection != null)
            {
                aSqlConnection.Close();
            }

        }
    }
}