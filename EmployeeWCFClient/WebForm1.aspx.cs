using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeWCFClient
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeWCFService.EmployeeWCFServiceClient client = new EmployeeWCFService.EmployeeWCFServiceClient();
            EmployeeWCFService.Employee employee = client.GetEmployeeWCF(Convert.ToInt32(txtID.Text));

            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            lblMessage.Text = "Employee Retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeWCFService.EmployeeWCFServiceClient client = new EmployeeWCFService.EmployeeWCFServiceClient();
            EmployeeWCFService.Employee employee = new EmployeeWCFService.Employee();

            employee.ID = Convert.ToInt32(txtID.Text);
            employee.Name = txtName.Text;
            employee.Gender = txtGender.Text;
            employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

            client.SaveEmployeeWCF(employee);
            lblMessage.Text = "Employee Saved";
        }
    }
}