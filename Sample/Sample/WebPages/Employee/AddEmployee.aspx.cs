using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Employee
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
            }
        }

        protected void AddNewEmployee(object sender, EventArgs e)
        {
            AppData.Instance.employee.FirstName = EmployeeUC.FirstName.Text;
            AppData.Instance.employee.LastName = EmployeeUC.LastName.Text;
            AppData.Instance.employee.UserName = EmployeeUC.UserName.Text;

            EmployeeRepository empRepos = new EmployeeRepository();
            response.Visible = true;
            response.Text = empRepos.AddEmployee(AppData.Instance.employee);
        }
    }
}