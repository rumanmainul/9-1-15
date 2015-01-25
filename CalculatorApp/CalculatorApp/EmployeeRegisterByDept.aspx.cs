using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculatorApp.BLL;
using CalculatorApp.DAL.DAO;

namespace CalculatorApp
{
    public partial class EmployeeRegisterByDept : System.Web.UI.Page
    {
        EmployeeManger employeeManager = new EmployeeManger();
        DepartmentManager deptManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                departmentDropDownList.DataSource = deptManager.GetAllDepartments();
                departmentDropDownList.DataTextField = "Name";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataBind();
            }
        }

        protected void departmentDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {


            //selected department 
            int deptId = Convert.ToInt32(departmentDropDownList.SelectedValue);

            //get employees by selected department
            List<Employee> employees = employeeManager.GetEmployeesByDeptId(deptId);

            employeeDropDownList.DataSource = employees;
            employeeDropDownList.DataTextField = "FirstName";
            employeeDropDownList.DataValueField = "Id";
            employeeDropDownList.DataBind();




            
        }

        protected void confirmButton_Click(object sender, EventArgs e)
        {
            int selectedEmployeeId = Convert.ToInt32(employeeDropDownList.SelectedValue);

            employeeManager.ConfirmEmployee(selectedEmployeeId);
            
        }
    }
}