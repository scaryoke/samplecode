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
    public partial class EditCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CompanyUC.CompanyName.Text = AppData.Instance.company.CompanyName;
                CompanyUC.ContactNum.Text = AppData.Instance.company.CompanyContactNumber;
            }
        }

        protected void CompanyAdd_Click(object sender, EventArgs e)
        {
            AppData.Instance.company.CompanyName = CompanyUC.CompanyName.Text;
            AppData.Instance.company.CompanyContactNumber = CompanyUC.ContactNum.Text;
            CompanyRepository compRepos = new CompanyRepository();
            lbMessage.Text = compRepos.UpdateCompany(AppData.Instance.company);
            btReturn.Visible = true;
            CompanyAdd.Visible = false;
        }

        protected void btReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebPages/Company/SearchCompanies.aspx");
        }
    }
}