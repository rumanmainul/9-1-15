using CalculatorApp.BLL;
using CalculatorApp.DAL.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApp
{
    public partial class CalculatorUI : System.Web.UI.Page
    {
        DepartmentManager deptManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {

            if(!IsPostBack)
            {
                departmentDropDownList.DataSource = deptManager.GetAllDepartments();
                departmentDropDownList.DataTextField = "Name";
                departmentDropDownList.DataValueField = "Id";
                departmentDropDownList.DataBind();
            }
           
            
        }

        
        protected void addButton_Click(object sender, EventArgs e)
        {
            EmployeeManger employeeManager = new EmployeeManger();
            
            Employee employee = new Employee();
            employee.Name = txtFirstName.Text;
            employee.Address = txtAddress.Text;
            employee.DepartmentId = Convert.ToInt32(departmentDropDownList.SelectedValue);
            employee.IsConfirmed = false;

            int Id =  employeeManager.Insert(employee);

            if(Id>0)
            {
                idLabel.Text = Id.ToString();
            }
            else
            {
                idLabel.Text = "";
                messageLabel.Text = "Insertion Failed!";
            }
           
            

            //ViewState["Employee"] = person;
        }

        protected void retrieveButton_Click(object sender, EventArgs e)
        {
            //Person person = (Person)ViewState["Employee"];
            //txtFirstName.Text = person.FirstName;
            //txtAddress.Text = person.Addess;
        }
    }
}