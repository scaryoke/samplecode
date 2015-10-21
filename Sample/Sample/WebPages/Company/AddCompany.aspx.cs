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
    public partial class AddCompany : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CompanyAdd_Click(object sender, EventArgs e)
        {
            AppData.Instance.company.CompanyName = CompanyUC.CompanyName.Text;
            AppData.Instance.company.CompanyContactNumber = CompanyUC.ContactNum.Text;
            CompanyRepository comRepos = new CompanyRepository();
            lbMessage.Text = comRepos.AddCompany(AppData.Instance.company);
        }

        protected void returnToMain_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Default.aspx");
        }


    }
}