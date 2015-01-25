using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeDepartmentApp.BLL;
using EmployeeDepartmentApp.DAL.DAO;

namespace EmployeeDepartmentApp.UI
{
    public partial class AddEmployeeUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DepartmentManager aDepartmentManager = new DepartmentManager();
            List<Department> aDepartmentsList = new List<Department>();
            if (!IsPostBack)
            {
                aDepartmentsList = aDepartmentManager.GetAllDepartment();
                DropDownListDptName.DataSource = aDepartmentsList;
                DropDownListDptName.DataValueField = "Dpt_Id";
                DropDownListDptName.DataTextField = "DepartmentName";
                DropDownListDptName.DataBind();
                DropDownListDptName.Items.Insert(0,"Select");
            }
            
        }

        protected void SaveButton_Click(object sender, EventArgs e)
        {
            Employee aEmployee = new Employee();
            aEmployee.EmployeeName = EmployeeNameTextBox.Text;
            aEmployee.Address = AddressTextBox.Text;
            aEmployee.DepartmentId = DropDownListDptName.SelectedValue;
            aEmployee.IsConfirmed = false;
            EmployeeManager aEmployeeManager = new EmployeeManager();
            string alert = aEmployeeManager.SaveEmployee(aEmployee);
            EmployeeLabel.Text = alert;
            if (alert != "")
            {
                AlertLabel.Text = "Data save Successfully";
            }
        }
    }
}