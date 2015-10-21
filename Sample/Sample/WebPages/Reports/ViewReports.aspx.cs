using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Reports
{
    public partial class ViewReports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                EmployeeRepository empRepos = new EmployeeRepository();
                DataTable dt = empRepos.GetAllEmployees();
                foreach (DataRow row in AppData.Instance.employee.EmployeeTable.Rows)
                {
                    ddEmployeeList.Items.Add(new ListItem(row["FirstName"].ToString() + " " + row["LastName"].ToString(), row["Employee_ID"].ToString()));
                }
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {

        }

        protected void btViewReports_Click(object sender, EventArgs e)
        {
            ReportRepository reportRepos = new ReportRepository();
            tbReport.Text = reportRepos.ViewReports(Convert.ToInt32(ddEmployeeList.SelectedValue));
        }
    }
}