using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Employee
{
    public partial class SearchEmployees : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EmployeeRepository empRepos = new EmployeeRepository();
                
                EmployeeView.DataSource = empRepos.GetAllEmployees();
                EmployeeView.DataBind();
            }
        }

        protected void EmployeeView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

            AppData.Instance.employee.FirstName = AppData.Instance.employee.EmployeeTable.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["FirstName"].ToString();
            AppData.Instance.employee.LastName = AppData.Instance.employee.EmployeeTable.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["LastName"].ToString();
            AppData.Instance.employee.UserName = AppData.Instance.employee.EmployeeTable.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["UserName"].ToString();
            AppData.Instance.employee.EmployeeID = Convert.ToInt32(AppData.Instance.employee.EmployeeTable.Rows[Convert.ToInt32(e.CommandArgument.ToString())]["Employee_ID"].ToString());
            Response.Redirect("~/WebPages/Employee/EditEmployee.aspx");
        }
    }
}