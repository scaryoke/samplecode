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
    public partial class EditEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EmployeeUC.UserName.Text = AppData.Instance.employee.UserName;
                EmployeeUC.FirstName.Text = AppData.Instance.employee.FirstName;
                EmployeeUC.LastName.Text = AppData.Instance.employee.LastName;
            }
        }

        protected void btEditEmployee_Click(object sender, EventArgs e)
        {
            AppData.Instance.employee.FirstName = EmployeeUC.FirstName.Text;
             AppData.Instance.employee.LastName = EmployeeUC.LastName.Text;
            EmployeeRepository empRepos = new EmployeeRepository();
            lbResponse.Text = empRepos.UpdateEmployee(AppData.Instance.employee);
        }
    }
}