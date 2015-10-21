using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Sample.ClassLib;
using Sample.ClassLib.Repository;

namespace Sample.WebPages.Company
{
    public partial class SearchCompanies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CompanyRepository compRepos = new CompanyRepository();
                companyGrid.DataSource = compRepos.GetCompanies();
                companyGrid.DataBind();
            }
        }

        protected void companyGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int Index = Convert.ToInt32(e.CommandArgument.ToString());
            AppData.Instance.company.CompanyName = AppData.Instance.company.CompanyTable.Rows[Index]["Company"].ToString();
            AppData.Instance.company.CompanyContactNumber = AppData.Instance.company.CompanyTable.Rows[Index]["CompanyContactNumber"].ToString();
            AppData.Instance.company.CompanyID = Convert.ToInt32(AppData.Instance.company.CompanyTable.Rows[Index]["Company_ID"].ToString());
            Response.Redirect("~/WebPages/Company/EditCompany.aspx");
        }
    }
}